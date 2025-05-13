using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock.Data.Entites;
using GestionDeStock.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;

namespace GestionDeStock.AlertForm
{
    public partial class AlertForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private IProductRepository _productRepository;
        private Dictionary<int, string> _categoryNameMap = new Dictionary<int, string>();
        private List<Product> _zeroStockProducts = new List<Product>();
        private List<Product> _lowStockProducts = new List<Product>();

        public AlertForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            
            // Set up the DataGridView for category name display
            zeroStockDataGridView.CellFormatting += DataGridView_CellFormatting;
            lowStockDataGridView.CellFormatting += DataGridView_CellFormatting;

            // Configure DataGridViews appearance
            ConfigureDataGridViewsStyle();
        }

        private async void AlertForm_Load(object sender, EventArgs e)
        {
            await RefreshStockAlerts();
        }
        
        private async Task RefreshStockAlerts()
        {
            try
            {
                // Show loading indicator
                Cursor = Cursors.WaitCursor;
                
                // Check if service provider is initialized
                if (_serviceProvider == null)
                {
                    MessageBox.Show("Service provider is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // First load all categories to build our name map
                await LoadCategoryMap();
                
                // Get the product repository from DI
                _productRepository = _serviceProvider.GetRequiredService<IProductRepository>();
                
                if (_productRepository == null)
                {
                    MessageBox.Show("Product repository service could not be resolved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Get all products to check for zero stock
                var allProductsTask = _productRepository.GetAllProductsAsync();
                
                // Ensure UI is ready before loading data
                EnsureDataGridViewsInitialized();
                
                // Now wait for the data
                var allProducts = await allProductsTask;
                
                // Ensure we have a valid collection
                if (allProducts == null)
                {
                    _zeroStockProducts = new List<Product>();
                    _lowStockProducts = new List<Product>();
                }
                else
                {
                    // Filter for zero stock products
                    _zeroStockProducts = allProducts.Where(p => p != null && p.Quantity == 0).ToList();
                    
                    // Get products with stock below their AlertThreshold but not zero
                    var lowStockProducts = await _productRepository.GetLowStockProductsAsync();
                    
                    if (lowStockProducts == null)
                    {
                        _lowStockProducts = new List<Product>();
                    }
                    else
                    {
                        _lowStockProducts = lowStockProducts.Where(p => p != null && p.Quantity > 0).ToList();
                    }
                }
                
                // Update the UI for zero stock products
                UpdateZeroStockUI();
                
                // Update the UI for low stock products
                UpdateLowStockUI();
                
                // Wait for UI to update before showing notifications
                await Task.Delay(100); // Small delay to ensure UI updates
                Application.DoEvents(); // Process any pending UI events
                
                // Show notification if there are alerts
                ShowNotificationIfNeeded();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock alerts: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset cursor
                Cursor = Cursors.Default;
            }
        }
        
        private void UpdateZeroStockUI()
        {
            // Bind zero stock products to grid
            zeroStockBindingSource.DataSource = _zeroStockProducts;
            zeroStockDataGridView.DataSource = zeroStockBindingSource;
            
            // Configure columns for zero stock grid
            ConfigureDataGridViewColumns(zeroStockDataGridView);
            
            // Update count label
            int count = _zeroStockProducts.Count;
            if (count == 0)
            {
                zeroStockCountLabel.Text = "No products out of stock";
            }
            else if (count == 1)
            {
                zeroStockCountLabel.Text = "1 product out of stock";
            }
            else
            {
                zeroStockCountLabel.Text = $"{count} products out of stock";
            }
        }
        
        private void UpdateLowStockUI()
        {
            // Bind low stock products to grid
            lowStockBindingSource.DataSource = _lowStockProducts;
            lowStockDataGridView.DataSource = lowStockBindingSource;
            
            // Configure columns for low stock grid
            ConfigureDataGridViewColumns(lowStockDataGridView);
            
            // Update count label
            int count = _lowStockProducts.Count;
            if (count == 0)
            {
                lowStockCountLabel.Text = "No products with low stock";
            }
            else if (count == 1)
            {
                lowStockCountLabel.Text = "1 product with low stock";
            }
            else
            {
                lowStockCountLabel.Text = $"{count} products with low stock";
            }
        }
        
        private void ShowNotificationIfNeeded()
        {
            int totalAlerts = _zeroStockProducts.Count + _lowStockProducts.Count;
            
            if (totalAlerts == 0)
            {
                MessageBox.Show("All stocks are at acceptable levels.", 
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = "";
                
                if (_zeroStockProducts.Count > 0)
                {
                    message += $"⚠️ {_zeroStockProducts.Count} product(s) out of stock.\n";
                }
                
                if (_lowStockProducts.Count > 0)
                {
                    message += $"ℹ️ {_lowStockProducts.Count} product(s) with low stock.";
                }
                
                MessageBox.Show(message, "Stock Alerts", 
                    MessageBoxButtons.OK, _zeroStockProducts.Count > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
                
                // Auto-select the tab with the most critical alerts
                if (_zeroStockProducts.Count > 0)
                {
                    tabControl.SelectedTab = zeroStockTabPage;
                }
                else
                {
                    tabControl.SelectedTab = lowStockTabPage;
                }
            }
        }
        
        private void ConfigureDataGridViewsStyle()
        {
            // Style for both DataGridViews - add null checks
            if (zeroStockDataGridView == null || lowStockDataGridView == null)
                return;
                
            foreach (var grid in new[] { zeroStockDataGridView, lowStockDataGridView })
            {
                if (grid == null || grid.RowTemplate == null)
                    continue;
                    
                // Row appearance
                grid.RowTemplate.Height = 40;
                
                if (grid.DefaultCellStyle != null)
                {
                    grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                }
                
                if (grid.AlternatingRowsDefaultCellStyle != null)
                {
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
                }
                
                // Headers appearance
                grid.ColumnHeadersHeight = 45;
                
                if (grid.ColumnHeadersDefaultCellStyle != null)
                {
                    grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 52, 64);
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                grid.EnableHeadersVisualStyles = false;
                
                // Selection style
                if (grid.DefaultCellStyle != null)
                {
                    grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
                    grid.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                
                // Other settings
                grid.BorderStyle = BorderStyle.None;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                // Add double-click event for quick stock update
                grid.DoubleClick += DataGridView_DoubleClick;
                
                // Add context menu
                AddContextMenu(grid);
            }
            
            // Zero stock specific style
            if (zeroStockDataGridView.DefaultCellStyle != null)
            {
                zeroStockDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                zeroStockDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }
        
        private void AddContextMenu(DataGridView grid)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            
            // Add "Add Stock" menu item
            ToolStripMenuItem addStockItem = new ToolStripMenuItem("🔄 Add Stock");
            addStockItem.Click += async (sender, e) => await QuickAddStock(grid);
            contextMenu.Items.Add(addStockItem);
            
            // Add "Edit Product" menu item
            ToolStripMenuItem editProductItem = new ToolStripMenuItem("✏️ Edit Product");
            editProductItem.Click += (sender, e) => EditSelectedProduct(grid);
            contextMenu.Items.Add(editProductItem);
            
            // Set the context menu
            grid.ContextMenuStrip = contextMenu;
        }
        
        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (sender == null)
                return;
                
            DataGridView grid = sender as DataGridView;
            if (grid != null)
            {
                EditSelectedProduct(grid);
            }
        }
        
        private async Task QuickAddStock(DataGridView grid)
        {
            try
            {
                // Get the selected product
                if (grid == null || grid.CurrentRow == null)
                    return;
                
                Product selectedProduct = null;
                
                if (grid == zeroStockDataGridView && zeroStockBindingSource.Current is Product)
                {
                    selectedProduct = (Product)zeroStockBindingSource.Current;
                }
                else if (grid == lowStockDataGridView && lowStockBindingSource.Current is Product)
                {
                    selectedProduct = (Product)lowStockBindingSource.Current;
                }
                
                if (selectedProduct != null)
                {
                    // Show a dialog to get the quantity to add
                    string input = Microsoft.VisualBasic.Interaction.InputBox(
                        $"How many units of \"{selectedProduct.Name}\" would you like to add?",
                        "Add Stock",
                        "1");
                    
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int quantityToAdd) && quantityToAdd > 0)
                    {
                        // Update the product quantity directly
                        await QuickUpdateProductQuantity(selectedProduct, quantityToAdd);
                        
                        // Show success message
                        MessageBox.Show($"{quantityToAdd} units of \"{selectedProduct.Name}\" have been added successfully.",
                            "Stock Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Refresh the data
                        await RefreshStockAlerts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private async Task QuickUpdateProductQuantity(Product product, int quantityToAdd)
        {
            try
            {
                // Get the product repository
                var productRepo = _serviceProvider.GetRequiredService<IProductRepository>();
                
                // Update product quantity
                product.Quantity += quantityToAdd;
                
                // Save the updated product
                await productRepo.UpdateProductAsync(product);
                
                // Create a StockIn record but without using Notes field
                var stockIn = new StockIn
                {
                    ProductId = product.ProductId,
                    Quantity = quantityToAdd,
                    EntryDate = DateTime.Now,
                    Supplier = "Quick add from notifications"
                };
                
                // Add the StockIn record
                var stockRepo = _serviceProvider.GetRequiredService<IStockMovementRepository>();
                
                // We need to update the product quantity to what it was before our change
                // because AddStockInAsync will add the quantity again
                product.Quantity -= quantityToAdd;
                
                await stockRepo.AddStockInAsync(stockIn);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating product quantity: {ex.Message}", ex);
            }
        }
        
        private void EditSelectedProduct(DataGridView grid)
        {
            try
            {
                // Get the selected product
                if (grid.CurrentRow != null)
                {
                    Product selectedProduct = null;
                    
                    if (grid == zeroStockDataGridView && zeroStockBindingSource.Current is Product)
                    {
                        selectedProduct = (Product)zeroStockBindingSource.Current;
                    }
                    else if (grid == lowStockDataGridView && lowStockBindingSource.Current is Product)
                    {
                        selectedProduct = (Product)lowStockBindingSource.Current;
                    }
                    
                    if (selectedProduct != null)
                    {
                        // Open the product edit form
                        var productDetailsForm = new ProductForm.ProductDetailsForm(selectedProduct, _serviceProvider);
                        if (productDetailsForm.ShowDialog() == DialogResult.OK)
                        {
                            // If changes were made, update the product
                            var productRepo = _serviceProvider.GetRequiredService<IProductRepository>();
                            // Add the await keyword to make sure the product is updated properly
                            Task.Run(async () => await productRepo.UpdateProductAsync(selectedProduct)).Wait();
                            
                            // Refresh the data
                            RefreshStockAlerts();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns(DataGridView grid)
        {
            try
            {
                if (grid == null)
                {
                    System.Diagnostics.Debug.WriteLine("Grid is null in ConfigureDataGridViewColumns");
                    return;
                }
                    
                if (grid.Columns == null || grid.Columns.Count <= 0 || grid.IsDisposed)
                {
                    System.Diagnostics.Debug.WriteLine($"Grid columns not initialized or grid disposed: Columns null? {grid.Columns == null}, Count: {grid.Columns?.Count ?? 0}, IsDisposed: {grid.IsDisposed}");
                    return;
                }
                
                // Temporarily suspend layout to speed up changes
                grid.SuspendLayout();
                
                try
                {
                    // Add a visual indicator column for low stock items
                    if (grid == lowStockDataGridView)
                    {
                        try 
                        {
                            // Check if column already exists to avoid duplicates
                            if (!grid.Columns.Contains("StockLevelIndicator"))
                            {
                                DataGridViewTextBoxColumn indicatorColumn = new DataGridViewTextBoxColumn
                                {
                                    Name = "StockLevelIndicator",
                                    HeaderText = "Level",
                                    FillWeight = 5,
                                    DefaultCellStyle = new DataGridViewCellStyle
                                    {
                                        Alignment = DataGridViewContentAlignment.MiddleCenter
                                    }
                                };
                                
                                // Ensure the grid is ready to receive new columns
                                if (grid.AllowUserToAddRows || grid.DataSource != null)
                                {
                                    grid.Columns.Add(indicatorColumn);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error adding indicator column: {ex.Message}");
                        }
                    }
                    
                    // Cache current column information to avoid unnecessary changes
                    var processedColumns = new HashSet<string>();
                    
                    // Configure columns
                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        try
                        {
                            DataGridViewColumn column = grid.Columns[i];
                            
                            if (column == null || processedColumns.Contains(column.Name))
                                continue;
                            
                            processedColumns.Add(column.Name);
                            
                            // Ensure DefaultCellStyle is initialized
                            if (column.DefaultCellStyle == null)
                                column.DefaultCellStyle = new DataGridViewCellStyle();
                                
                            // Set header text for each column (English headers)
                            switch (column.Name)
                            {
                                case "StockLevelIndicator":
                                    try
                                    {
                                        column.DisplayIndex = 0;
                                        column.HeaderText = "";
                                        
                                        // Only set width properties if the column is fully initialized
                                        if (IsColumnReady(column))
                                        {
                                            SetColumnWidthSafely(column, 50);
                                            SetColumnMinWidthSafely(column, 50);
                                        }
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring StockLevelIndicator: {ex.Message}");
                                    }
                                    break;
                                case "ProductId":
                                    try
                                    {
                                        column.HeaderText = "ID";
                                        column.FillWeight = 5;
                                        
                                        if (IsColumnReady(column))
                                        {
                                            SetColumnWidthSafely(column, 50);
                                        }
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring ProductId: {ex.Message}");
                                    }
                                    break;
                                case "Name":
                                    try
                                    {
                                        column.HeaderText = "Product Name";
                                        column.FillWeight = 25;
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring Name: {ex.Message}"); 
                                    }
                                    break;
                                case "Quantity":
                                    try
                                    {
                                        column.HeaderText = "Current Quantity";
                                        column.FillWeight = 10;
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring Quantity: {ex.Message}"); 
                                    }
                                    break;
                                case "PurchasePrice":
                                    try
                                    {
                                        column.HeaderText = "Purchase Price";
                                        column.FillWeight = 15;
                                        if (column.DefaultCellStyle != null)
                                            column.DefaultCellStyle.Format = "C2";
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring PurchasePrice: {ex.Message}"); 
                                    }
                                    break;
                                case "SalePrice":
                                    try
                                    {
                                        column.HeaderText = "Sale Price";
                                        column.FillWeight = 15;
                                        if (column.DefaultCellStyle != null)
                                            column.DefaultCellStyle.Format = "C2";
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring SalePrice: {ex.Message}"); 
                                    }
                                    break;
                                case "AlertThreshold":
                                    try
                                    {
                                        column.HeaderText = "Alert Threshold";
                                        column.FillWeight = 10;
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring AlertThreshold: {ex.Message}"); 
                                    }
                                    break;
                                case "Description":
                                    try
                                    {
                                        column.HeaderText = "Description";
                                        column.FillWeight = 20;
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring Description: {ex.Message}"); 
                                    }
                                    break;
                                case "CategoryId":
                                    try
                                    {
                                        column.HeaderText = "Category";
                                        column.FillWeight = 15;
                                    }
                                    catch (Exception ex) 
                                    { 
                                        System.Diagnostics.Debug.WriteLine($"Error configuring CategoryId: {ex.Message}"); 
                                    }
                                    break;
                            }
                            
                            // Hide navigation properties/collections
                            try
                            {
                                if (column.Name == "Category" || column.Name == "StockIns" || column.Name == "StockOuts")
                                {
                                    column.Visible = false;
                                }
                            }
                            catch (Exception ex) 
                            { 
                                System.Diagnostics.Debug.WriteLine($"Error setting visibility for {column.Name}: {ex.Message}"); 
                            }
                            
                            // Also hide computed properties
                            try
                            {
                                if (column.Name == "IsOutOfStock" || column.Name == "IsLowStock" || 
                                    column.Name == "IsCriticalLowStock" || column.Name == "IsWarningLowStock" ||
                                    column.Name == "StockStatus")
                                {
                                    column.Visible = false;
                                }
                            }
                            catch (Exception ex) 
                            { 
                                System.Diagnostics.Debug.WriteLine($"Error hiding computed property {column.Name}: {ex.Message}"); 
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error configuring column at index {i}: {ex.Message}");
                        }
                    }
                }
                finally
                {
                    // Always make sure to resume layout
                    grid.ResumeLayout();
                    
                    // Force a refresh of the DataGridView
                    grid.Refresh();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in ConfigureDataGridViewColumns: {ex.Message}");
            }
        }
        
        // Check if a column is fully initialized and ready for width/property changes
        private bool IsColumnReady(DataGridViewColumn column)
        {
            if (column == null)
                return false;
                
            try
            {
                // Check all conditions that might indicate an uninitialized column
                bool isReady = column.DataGridView != null 
                    && !column.DataGridView.IsDisposed 
                    && column.DataGridView.IsHandleCreated
                    && column.Width >= 0;  // Test if Width is accessible
                    
                return isReady;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        // Helper method to safely set column width using reflection if necessary
        private void SetColumnWidthSafely(DataGridViewColumn column, int width)
        {
            if (column == null)
                return;
                
            try
            {
                // Try the direct approach first
                column.Width = width;
            }
            catch (NullReferenceException)
            {
                try
                {
                    // Use Invoke to set the property on the UI thread
                    if (column.DataGridView?.InvokeRequired == true)
                    {
                        column.DataGridView.Invoke(new Action(() => 
                        {
                            try 
                            { 
                                column.Width = width; 
                            }
                            catch 
                            { 
                                // Ignore further errors 
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to set column width: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error setting column width: {ex.Message}");
            }
        }
        
        // Helper method to safely set column minimum width
        private void SetColumnMinWidthSafely(DataGridViewColumn column, int minWidth)
        {
            if (column == null)
                return;
                
            try
            {
                column.MinimumWidth = minWidth;
            }
            catch (NullReferenceException)
            {
                try
                {
                    // Use Invoke to set the property on the UI thread
                    if (column.DataGridView?.InvokeRequired == true)
                    {
                        column.DataGridView.Invoke(new Action(() => 
                        {
                            try 
                            { 
                                column.MinimumWidth = minWidth; 
                            }
                            catch 
                            { 
                                // Ignore further errors 
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Failed to set column minimum width: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error setting column minimum width: {ex.Message}");
            }
        }
        
        private async Task LoadCategoryMap()
        {
            try
            {
                if (_serviceProvider == null)
                {
                    MessageBox.Show("Service provider is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var categoryRepo = _serviceProvider.GetRequiredService<ICategoryRepository>();
                var categories = await categoryRepo.GetAllCategoriesAsync();
                
                _categoryNameMap.Clear();
                if (categories != null)
                {
                    foreach (var category in categories)
                    {
                        if (category != null)
                        {
                            _categoryNameMap[category.CategoryId] = category.Name ?? string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            if (grid == null) return;

            // Add null check for grid.Columns and avoid index out of range
            if (e.ColumnIndex < 0 || e.ColumnIndex >= grid.Columns.Count)
                return;

            // Check if this is the category column and it has a value
            if (grid.Columns[e.ColumnIndex].Name == "CategoryId" && e.Value != null)
            {
                // Get the CategoryId value
                if (int.TryParse(e.Value.ToString(), out int categoryId))
                {
                    // Try to get the category name from our map
                    if (_categoryNameMap.ContainsKey(categoryId))
                    {
                        e.Value = _categoryNameMap[categoryId];
                        e.FormattingApplied = true;
                    }
                }
            }
            
            // Format the stock level indicator column
            if (grid == lowStockDataGridView && e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count && 
                grid.Columns[e.ColumnIndex].Name == "StockLevelIndicator" && e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                // Add null checks to avoid NullReferenceException
                if (grid.Rows[e.RowIndex].Cells["Quantity"].Value == null || 
                    grid.Rows[e.RowIndex].Cells["AlertThreshold"].Value == null)
                    return;

                var quantity = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Quantity"].Value);
                var threshold = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["AlertThreshold"].Value);
                
                // Calculate percentage of threshold
                double percentage = (double)quantity / threshold * 100;
                
                if (percentage <= 25)
                {
                    // Critical - less than 25% of threshold
                    e.Value = "🔴";
                    e.CellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                }
                else if (percentage <= 50)
                {
                    // Warning - less than 50% of threshold
                    e.Value = "🟠";
                    e.CellStyle.ForeColor = Color.FromArgb(255, 193, 7);
                }
                else if (percentage <= 75)
                {
                    // Notice - less than 75% of threshold
                    e.Value = "🟡";
                    e.CellStyle.ForeColor = Color.FromArgb(255, 193, 7);
                }
                else
                {
                    // Ok - between 75% and 100% of threshold
                    e.Value = "🟢";
                    e.CellStyle.ForeColor = Color.FromArgb(40, 167, 69);
                }
                
                e.FormattingApplied = true;
            }
            
            // Special formatting for Quantity column in low stock grid
            if (grid == lowStockDataGridView && e.ColumnIndex >= 0 && e.ColumnIndex < grid.Columns.Count && 
                grid.Columns[e.ColumnIndex].Name == "Quantity" && e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count && e.Value != null)
            {
                // Add null check for AlertThreshold
                if (grid.Rows[e.RowIndex].Cells["AlertThreshold"].Value == null)
                    return;

                var quantity = Convert.ToInt32(e.Value);
                var threshold = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["AlertThreshold"].Value);
                
                // Set font color based on remaining stock percentage compared to threshold
                if (quantity <= threshold * 0.25)
                {
                    // Critical - less than 25% of threshold
                    e.CellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                    e.CellStyle.Font = new Font(grid.DefaultCellStyle.Font, FontStyle.Bold);
                }
                else if (quantity <= threshold * 0.5)
                {
                    // Warning - less than 50% of threshold
                    e.CellStyle.ForeColor = Color.FromArgb(255, 193, 7);
                    e.CellStyle.Font = new Font(grid.DefaultCellStyle.Font, FontStyle.Bold);
                }
            }
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serviceProvider == null)
                {
                    MessageBox.Show("Service provider is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                
                // Get the dashboard form from the service provider
                var dashboardForm = _serviceProvider.GetRequiredService<DashboardForm.DashboardForm>();
                
                if (dashboardForm == null)
                {
                    MessageBox.Show("Could not create dashboard form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                
                // Show the dashboard form
                dashboardForm.Show();
                
                // Hide this form
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning to dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        private async void refreshButton_Click(object sender, EventArgs e)
        {
            await RefreshStockAlerts();
        }

        private void EnsureDataGridViewsInitialized()
        {
            try
            {
                // First make sure the DataGridViews are properly initialized
                if (zeroStockDataGridView == null || lowStockDataGridView == null)
                {
                    System.Diagnostics.Debug.WriteLine("One or more DataGridViews are null in EnsureDataGridViewsInitialized");
                    return;
                }
                
                // Reset DataGridViews
                zeroStockDataGridView.DataSource = null;
                lowStockDataGridView.DataSource = null;
                
                // Set up minimal configuration
                foreach (DataGridView dgv in new[] { zeroStockDataGridView, lowStockDataGridView })
                {
                    if (dgv == null) continue;
                    
                    // Initialize basic properties
                    dgv.AutoGenerateColumns = true;
                    dgv.ReadOnly = true;
                    dgv.AllowUserToAddRows = false;
                    dgv.AllowUserToDeleteRows = false;
                    dgv.AllowUserToOrderColumns = true;
                    
                    // Apply UI settings
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.RowHeadersVisible = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    
                    // Create default style for columns
                    DataGridViewCellStyle defaultStyle = new DataGridViewCellStyle();
                    defaultStyle.Font = new Font("Segoe UI", 10);
                    dgv.DefaultCellStyle = defaultStyle;
                    
                    // Apply alternating row style
                    DataGridViewCellStyle altStyle = new DataGridViewCellStyle();
                    altStyle.BackColor = Color.FromArgb(248, 249, 250);
                    dgv.AlternatingRowsDefaultCellStyle = altStyle;
                    
                    // Set headers style
                    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgv.ColumnHeadersHeight = 45;
                    
                    DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                    headerStyle.BackColor = Color.FromArgb(45, 52, 64);
                    headerStyle.ForeColor = Color.White;
                    headerStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgv.ColumnHeadersDefaultCellStyle = headerStyle;
                    
                    dgv.EnableHeadersVisualStyles = false;
                    
                    // Set row height
                    if (dgv.RowTemplate != null)
                    {
                        dgv.RowTemplate.Height = 40;
                    }
                    
                    // We'll initialize the events in a safer way
                    try
                    {
                        // Remove any existing event handlers and add them back
                        dgv.DoubleClick -= DataGridView_DoubleClick;
                        dgv.DoubleClick += DataGridView_DoubleClick;
                    }
                    catch (Exception evEx)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error setting up DoubleClick event: {evEx.Message}");
                    }
                    
                    // Add context menu if needed
                    if (dgv.ContextMenuStrip == null)
                    {
                        AddContextMenu(dgv);
                    }
                }
                
                // Specific style for zero stock grid
                if (zeroStockDataGridView?.DefaultCellStyle != null)
                {
                    zeroStockDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                    zeroStockDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                
                // Wait for the UI to update
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error initializing DataGridViews: {ex.Message}");
            }
        }
    }
}
