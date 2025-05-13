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

namespace GestionDeStock.StockInForm
{
    public partial class StockInForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IStockInRepository _stockInRepository;
        private readonly IProductRepository _productRepository;
        private List<StockIn>? _stockIns;
        private List<Product>? _products;
        private StockIn? _selectedStockIn;
        private FormMode _currentMode = FormMode.View;

        public StockInForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _stockInRepository = _serviceProvider.GetRequiredService<IStockInRepository>();
            _productRepository = _serviceProvider.GetRequiredService<IProductRepository>();

            // Set up DataGridView
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockInId",
                HeaderText = "ID",
                Name = "StockInIdColumn",
                Visible = false
            };

            DataGridViewTextBoxColumn productColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product",
                Name = "ProductColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30,
                ReadOnly = true,
                MinimumWidth = 120
            };

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity",
                Name = "QuantityColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20,
                ReadOnly = true,
                MinimumWidth = 80
            };

            DataGridViewTextBoxColumn entryDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EntryDate",
                HeaderText = "Entry Date",
                Name = "EntryDateColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25,
                ReadOnly = true,
                MinimumWidth = 100
            };

            DataGridViewTextBoxColumn supplierColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Supplier",
                HeaderText = "Supplier",
                Name = "SupplierColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25,
                ReadOnly = true,
                MinimumWidth = 100
            };

            // Add columns to DataGridView
            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                idColumn,
                productColumn,
                quantityColumn,
                entryDateColumn,
                supplierColumn
            });
        }

        private async void StockInForm_Load(object sender, EventArgs e)
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
                productComboBox.DataSource = null;
                productComboBox.DisplayMember = "Name";
                productComboBox.ValueMember = "ProductId";
                productComboBox.DataSource = _products;

                // Load StockIn records
                _stockIns = (await _stockInRepository.GetAllAsync())?.ToList() ?? new List<StockIn>();

                // Create a binding list with product names
                var bindingList = new BindingList<StockInDisplayItem>(
                    _stockIns.Select(s => new StockInDisplayItem
                    {
                        StockInId = s.StockInId,
                        ProductId = s.ProductId,
                        ProductName = s.Product?.Name ?? "Unknown",
                        Quantity = s.Quantity,
                        EntryDate = s.EntryDate,
                        Supplier = s.Supplier ?? string.Empty,
                        Notes = s.Notes ?? string.Empty
                    }).ToList());

                // Refresh the data grid
                var bindingSource = new BindingSource
                {
                    DataSource = bindingList
                };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UpdateButton.Enabled = isViewMode && _selectedStockIn != null;
            DeleteButton.Enabled = isViewMode && _selectedStockIn != null;
            ReloadButton.Enabled = isViewMode;

            // Detail panel controls
            productComboBox.Enabled = isAddEditMode;
            quantityTextBox.Enabled = isAddEditMode;
            entryDatePicker.Enabled = isAddEditMode;
            supplierTextBox.Enabled = isAddEditMode;
            notesTextBox.Enabled = isAddEditMode;
            saveButton.Visible = isAddEditMode;
            cancelButton.Visible = isAddEditMode;

            // Select appropriate product in combo box if in edit mode
            if (mode == FormMode.Edit && _selectedStockIn != null)
            {
                productComboBox.SelectedValue = _selectedStockIn.ProductId;
                quantityTextBox.Text = _selectedStockIn.Quantity.ToString();
                entryDatePicker.Value = _selectedStockIn.EntryDate;
                supplierTextBox.Text = _selectedStockIn.Supplier ?? string.Empty;
                notesTextBox.Text = _selectedStockIn.Notes ?? string.Empty;
            }
            else if (mode == FormMode.Add)
            {
                // Clear fields for add
                productComboBox.SelectedIndex = -1;
                quantityTextBox.Text = string.Empty;
                entryDatePicker.Value = DateTime.Now;
                supplierTextBox.Text = string.Empty;
                notesTextBox.Text = string.Empty;
            }
        }

        private void ClearSelection()
        {
            _selectedStockIn = null;
            productComboBox.SelectedIndex = -1;
            quantityTextBox.Text = string.Empty;
            entryDatePicker.Value = DateTime.Now;
            supplierTextBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index >= 0)
            {
                // Get selected stock in ID
                var selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["StockInIdColumn"].Value != null)
                {
                    int stockInId = Convert.ToInt32(selectedRow.Cells["StockInIdColumn"].Value);
                    _selectedStockIn = _stockIns?.FirstOrDefault(s => s.StockInId == stockInId);

                    if (_selectedStockIn != null)
                    {
                        // Update the input fields with selected stock in
                        productComboBox.SelectedValue = _selectedStockIn.ProductId;
                        quantityTextBox.Text = _selectedStockIn.Quantity.ToString();
                        entryDatePicker.Value = _selectedStockIn.EntryDate;
                        supplierTextBox.Text = _selectedStockIn.Supplier ?? string.Empty;
                        notesTextBox.Text = _selectedStockIn.Notes ?? string.Empty;

                        // Update button states
                        UpdateButton.Enabled = true;
                        DeleteButton.Enabled = true;
                    }
                }
            }
            else
            {
                _selectedStockIn = null;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            ClearSelection();
            SetFormMode(FormMode.Add);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (_selectedStockIn != null)
            {
                SetFormMode(FormMode.Edit);
            }
            else
            {
                MessageBox.Show("Please select a stock in record to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedStockIn != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete this stock in record?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the stock in record
                        await _stockInRepository.DeleteAsync(_selectedStockIn.StockInId);

                        // Reload data
                        await LoadData();
                        ClearSelection();
                        MessageBox.Show("Stock in record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting stock in record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a stock in record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int productId = Convert.ToInt32(productComboBox.SelectedValue);
                    int quantity = Convert.ToInt32(quantityTextBox.Text);
                    DateTime entryDate = entryDatePicker.Value;
                    string supplier = supplierTextBox.Text;
                    // Set Notes to empty string by default (prevents null)
                    string notes = notesTextBox.Text ?? string.Empty;

                    if (_currentMode == FormMode.Add)
                    {
                        // Create new stock in record
                        var stockIn = new StockIn
                        {
                            ProductId = productId,
                            Quantity = quantity,
                            EntryDate = entryDate,
                            Supplier = supplier,
                            Notes = notes
                        };

                        // Add to database
                        await _stockInRepository.AddAsync(stockIn);

                        // Update product quantity
                        var product = await _productRepository.GetProductByIdAsync(productId);
                        if (product != null)
                        {
                            product.Quantity += quantity;
                            await _productRepository.UpdateProductAsync(product);
                        }

                        MessageBox.Show("Stock in added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (_currentMode == FormMode.Edit && _selectedStockIn != null)
                    {
                        // Calculate quantity difference for inventory update
                        int quantityDifference = quantity - _selectedStockIn.Quantity;

                        // Update stock in record
                        _selectedStockIn.ProductId = productId;
                        _selectedStockIn.Quantity = quantity;
                        _selectedStockIn.EntryDate = entryDate;
                        _selectedStockIn.Supplier = supplier;
                        _selectedStockIn.Notes = notes;

                        // Update in database
                        await _stockInRepository.UpdateAsync(_selectedStockIn);

                        // Update product quantity if changed
                        if (quantityDifference != 0)
                        {
                            var product = await _productRepository.GetProductByIdAsync(productId);
                            if (product != null)
                            {
                                product.Quantity += quantityDifference;
                                await _productRepository.UpdateProductAsync(product);
                            }
                        }

                        MessageBox.Show("Stock in updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Error saving stock in record: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (productComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate quantity
            if (string.IsNullOrWhiteSpace(quantityTextBox.Text) || !int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate supplier
            if (string.IsNullOrWhiteSpace(supplierTextBox.Text))
            {
                MessageBox.Show("Please enter a supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    internal enum FormMode
    {
        View,
        Add,
        Edit
    }

    internal class StockInDisplayItem
    {
        public int StockInId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public string Supplier { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
