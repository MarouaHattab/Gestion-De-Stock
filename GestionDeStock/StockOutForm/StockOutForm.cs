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

namespace GestionDeStock.StockOutForm
{
    public partial class StockOutForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IStockOutRepository _stockOutRepository;
        private readonly IProductRepository _productRepository;
        private List<StockOut>? _stockOuts;
        private List<Product>? _products;
        private StockOut? _selectedStockOut;
        private FormMode _currentMode = FormMode.View;

        public StockOutForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _stockOutRepository = _serviceProvider.GetRequiredService<IStockOutRepository>();
            _productRepository = _serviceProvider.GetRequiredService<IProductRepository>();

            // Set form to maximize on startup
            this.WindowState = FormWindowState.Maximized;

            // Set up DataGridView
            ConfigureDataGridView();
            
            // Add the form load event handler
            this.Load += StockOutForm_Load;
        }

        private void ConfigureDataGridView()
        {
            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockOutId",
                HeaderText = "ID",
                Name = "StockOutIdColumn",
                Visible = false
            };

            DataGridViewTextBoxColumn productColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product",
                Name = "ProductColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25,
                ReadOnly = true,
                MinimumWidth = 120
            };

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Name = "QuantityColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
                ReadOnly = true,
                MinimumWidth = 80
            };

            DataGridViewTextBoxColumn exitDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExitDate",
                HeaderText = "Exit Date",
                Name = "ExitDateColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
                ReadOnly = true,
                MinimumWidth = 100
            };

            DataGridViewTextBoxColumn destinationColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Destination",
                HeaderText = "Destination",
                Name = "DestinationColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
                ReadOnly = true,
                MinimumWidth = 100
            };

            DataGridViewTextBoxColumn notesColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Notes",
                HeaderText = "Notes",
                Name = "NotesColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
                ReadOnly = true,
                MinimumWidth = 100
            };

            // Add columns to DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                idColumn,
                productColumn,
                quantityColumn,
                exitDateColumn,
                destinationColumn,
                notesColumn
            });
        }

        private async void StockOutForm_Load(object sender, EventArgs e)
        {
            await LoadData();
            SetFormMode(FormMode.View);
        }

        private async Task LoadData()
        {
            try
            {
                // Load products for dropdown
                _products = (await _productRepository.GetAllProductsAsync())?.ToList() ?? new List<Product>();
                
                // Configure combo box
                comboBox1.DataSource = null;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ProductId";
                comboBox1.DataSource = _products;
                
                // Add debugging information
                System.Diagnostics.Debug.WriteLine($"Loaded {_products.Count} products for dropdown");
                foreach (var product in _products)
                {
                    System.Diagnostics.Debug.WriteLine($"Product: {product.ProductId} - {product.Name}");
                }

                // Load StockOut records
                _stockOuts = (await _stockOutRepository.GetAllAsync())?.ToList() ?? new List<StockOut>();
                System.Diagnostics.Debug.WriteLine($"Loaded {_stockOuts.Count} stock out records");

                // Create a binding list with product names
                var bindingList = new BindingList<StockOutDisplayItem>();

                foreach (var stockOut in _stockOuts)
                {
                    // Find corresponding product
                    var product = _products.FirstOrDefault(p => p.ProductId == stockOut.ProductId);
                    var productName = product?.Name ?? "Unknown Product";
                    
                    bindingList.Add(new StockOutDisplayItem
                    {
                        StockOutId = stockOut.StockOutId,
                        ProductId = stockOut.ProductId,
                        ProductName = productName,
                        Quantity = stockOut.Quantity,
                        ExitDate = stockOut.ExitDate,
                        Destination = stockOut.Destination ?? string.Empty,
                        Notes = stockOut.Notes ?? string.Empty
                    });
                    
                    System.Diagnostics.Debug.WriteLine($"Added StockOut: ID={stockOut.StockOutId}, ProductID={stockOut.ProductId}, ProductName={productName}");
                }

                // Refresh the data grid
                dataGridView1.DataSource = new BindingSource { DataSource = bindingList };
                
                // Update button states
                UpdateButton.Enabled = _selectedStockOut != null;
                DeleteButton.Enabled = _selectedStockOut != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"LoadData Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
            }
        }

        private void SetFormMode(FormMode mode)
        {
            _currentMode = mode;

            // Enable/disable controls based on mode
            bool isViewMode = mode == FormMode.View;
            bool isAddEditMode = mode == FormMode.Add || mode == FormMode.Edit;

            // Button states
            AddButton.Enabled = isViewMode;
            UpdateButton.Enabled = isViewMode && _selectedStockOut != null;
            DeleteButton.Enabled = isViewMode && _selectedStockOut != null;
            ReloadButton.Enabled = isViewMode;

            // Detail panel controls
            comboBox1.Enabled = isAddEditMode;
            textBox2.Enabled = isAddEditMode;
            dateTimePicker1.Enabled = isAddEditMode;
            textBox3.Enabled = isAddEditMode;
            notesTextBox.Enabled = isAddEditMode;
            saveButton.Visible = isAddEditMode;
            cancelButton.Visible = isAddEditMode;

            // Select appropriate product in combo box if in edit mode
            if (mode == FormMode.Edit && _selectedStockOut != null)
            {
                comboBox1.SelectedValue = _selectedStockOut.ProductId;
                textBox2.Text = _selectedStockOut.Quantity.ToString();
                dateTimePicker1.Value = _selectedStockOut.ExitDate;
                textBox3.Text = _selectedStockOut.Destination ?? string.Empty;
                notesTextBox.Text = _selectedStockOut.Notes ?? string.Empty;
            }
            else if (mode == FormMode.Add)
            {
                // Clear fields for add
                comboBox1.SelectedIndex = -1;
                textBox2.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                textBox3.Text = string.Empty;
                notesTextBox.Text = string.Empty;
            }
        }

        private void ClearSelection()
        {
            _selectedStockOut = null;
            comboBox1.SelectedIndex = -1;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Text = string.Empty;
            notesTextBox.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells.Count > 0)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["StockOutIdColumn"] != null && 
                        dataGridView1.Rows[e.RowIndex].Cells["StockOutIdColumn"].Value != null)
                    {
                        int stockOutId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StockOutIdColumn"].Value);
                        _selectedStockOut = _stockOuts?.FirstOrDefault(s => s.StockOutId == stockOutId);

                        if (_selectedStockOut != null)
                        {
                            // Update the input fields with selected stock out
                            comboBox1.SelectedValue = _selectedStockOut.ProductId;
                            textBox2.Text = _selectedStockOut.Quantity.ToString();
                            dateTimePicker1.Value = _selectedStockOut.ExitDate;
                            textBox3.Text = _selectedStockOut.Destination ?? string.Empty;
                            notesTextBox.Text = _selectedStockOut.Notes ?? string.Empty;

                            // Update button states
                            UpdateButton.Enabled = true;
                            DeleteButton.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Selected stock out record could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    _selectedStockOut = null;
                    UpdateButton.Enabled = false;
                    DeleteButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting stock out record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearSelection();
            SetFormMode(FormMode.Add);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (_selectedStockOut != null)
            {
                SetFormMode(FormMode.Edit);
            }
            else
            {
                MessageBox.Show("Please select a stock out record to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedStockOut != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete this stock out record?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the stock out record
                        await _stockOutRepository.DeleteAsync(_selectedStockOut.StockOutId);

                        // Update product quantity by adding back the stock out quantity
                        var product = await _productRepository.GetProductByIdAsync(_selectedStockOut.ProductId);
                        if (product != null)
                        {
                            product.Quantity += _selectedStockOut.Quantity;
                            await _productRepository.UpdateProductAsync(product);
                        }

                        // Reload data
                        await LoadData();
                        ClearSelection();
                        MessageBox.Show("Stock out record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting stock out record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a stock out record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void ReloadButton_Click(object sender, EventArgs e)
        {
            await LoadData();
            ClearSelection();
            SetFormMode(FormMode.View);
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the dashboard form from the service provider
                var dashboardForm = _serviceProvider.GetRequiredService<DashboardForm.DashboardForm>();

                // Show the dashboard
                dashboardForm.Show();

                // Close this form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning to dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    // Get values from form
                    int productId = Convert.ToInt32(comboBox1.SelectedValue);
                    int quantity = Convert.ToInt32(textBox2.Text);
                    DateTime exitDate = dateTimePicker1.Value;
                    string destination = textBox3.Text;
                    // Set Notes to empty string by default (prevents null)
                    string notes = notesTextBox.Text ?? string.Empty;

                    if (_currentMode == FormMode.Add)
                    {
                        // Create new stock out record
                        var stockOut = new StockOut
                        {
                            ProductId = productId,
                            Quantity = quantity,
                            ExitDate = exitDate,
                            Destination = destination,
                            Notes = notes
                        };

                        // Get product to update inventory
                        var product = await _productRepository.GetProductByIdAsync(productId);
                        if (product != null)
                        {
                            // Check if enough stock is available
                            if (product.Quantity < quantity)
                            {
                                MessageBox.Show($"Not enough stock available. Current stock: {product.Quantity}", "Validation Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Display information about the update
                            var confirmResult = MessageBox.Show(
                                $"Product: {product.Name}\n" +
                                $"Current Quantity: {product.Quantity}\n" +
                                $"Quantity to remove: {quantity}\n" +
                                $"New Quantity will be: {product.Quantity - quantity}\n\n" +
                                "Are you sure you want to proceed?",
                                "Confirm Stock Out",
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question);

                            if (confirmResult != DialogResult.Yes)
                            {
                                return;
                            }

                            // Update product quantity
                            product.Quantity -= quantity;
                            await _productRepository.UpdateProductAsync(product);
                        }
                        else
                        {
                            MessageBox.Show("Selected product not found in the database.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Add to database
                        await _stockOutRepository.AddAsync(stockOut);

                        MessageBox.Show("Stock out added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (_currentMode == FormMode.Edit && _selectedStockOut != null)
                    {
                        // Calculate quantity difference for inventory update
                        int quantityDifference = quantity - _selectedStockOut.Quantity;

                        // Check if product has enough stock for the updated quantity
                        if (quantityDifference > 0)
                        {
                            var product = await _productRepository.GetProductByIdAsync(productId);
                            if (product != null && product.Quantity < quantityDifference)
                            {
                                MessageBox.Show($"Not enough stock available for the increased quantity. Available: {product.Quantity}", 
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        // Update stock out record
                        _selectedStockOut.ProductId = productId;
                        _selectedStockOut.Quantity = quantity;
                        _selectedStockOut.ExitDate = exitDate;
                        _selectedStockOut.Destination = destination;
                        _selectedStockOut.Notes = notes;

                        // Update in database
                        await _stockOutRepository.UpdateAsync(_selectedStockOut);

                        // Update product quantity if changed
                        if (quantityDifference != 0)
                        {
                            var product = await _productRepository.GetProductByIdAsync(productId);
                            if (product != null)
                            {
                                // Display information about the update
                                var confirmResult = MessageBox.Show(
                                    $"Product: {product.Name}\n" +
                                    $"Current Quantity: {product.Quantity}\n" +
                                    $"Quantity adjustment: {quantityDifference}\n" +
                                    $"New Quantity will be: {product.Quantity - quantityDifference}\n\n" +
                                    "Are you sure you want to proceed?",
                                    "Confirm Stock Out Update",
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question);

                                if (confirmResult != DialogResult.Yes)
                                {
                                    return;
                                }

                                product.Quantity -= quantityDifference;
                                await _productRepository.UpdateProductAsync(product);
                            }
                            else
                            {
                                MessageBox.Show("Selected product not found in the database.", "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        MessageBox.Show("Stock out updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Reload data and reset form
                    await LoadData();
                    ClearSelection();
                    SetFormMode(FormMode.View);
                }
                catch (Exception ex)
                {
                    string errorMessage = ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMessage += $"\n\nDetails: {ex.InnerException.Message}";
                    }
                    MessageBox.Show($"Error saving stock out record: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearSelection();
            SetFormMode(FormMode.View);
        }

        private bool ValidateInputs()
        {
            // Validate product selection
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate quantity
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox2.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate destination
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter a destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }

    internal enum FormMode
    {
        View,
        Add,
        Edit
    }

    internal class StockOutDisplayItem
    {
        public int StockOutId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime ExitDate { get; set; }
        public string Destination { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
