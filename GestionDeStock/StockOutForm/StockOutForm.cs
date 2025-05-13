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
using GestionDeStock.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeStock.StockOutForm
{
    public partial class StockOutForm : Form
    {
        private bool _isAddEditMode = false;
        private StockOut _selectedStockOut;
        private readonly IProductRepository _productRepository;
        private readonly IStockOutRepository _stockOutRepository;
        private readonly IServiceProvider _serviceProvider;

        public StockOutForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _productRepository = _serviceProvider.GetRequiredService<IProductRepository>();
            _stockOutRepository = _serviceProvider.GetRequiredService<IStockOutRepository>();
            
            // Set form to maximize on startup
            this.WindowState = FormWindowState.Maximized;
            
            LoadProductsAsync();
            LoadStockOutsAsync();
            SetReadOnlyMode();
            
            // Add form closing event to dispose resources
            this.FormClosing += StockOutForm_FormClosing;
        }
        
        private void StockOutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // No need to manually dispose DbContext when using DI
        }

        private async void LoadProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ProductId";
        }

        private async void LoadStockOutsAsync()
        {
            var stockOuts = await _stockOutRepository.GetAllAsync();
            stockOutBindingSource.DataSource = stockOuts;
        }

        private void SetAddEditMode()
        {
            _isAddEditMode = true;
            // Enable controls for editing
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox3.Enabled = true;
            notesTextBox.Enabled = true;
            comboBox1.Enabled = true;
            // Change button text to save
            button1.Text = "Save";
        }

        private void SetReadOnlyMode()
        {
            _isAddEditMode = false;
            // Disable controls for editing
            textBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox3.Enabled = false;
            notesTextBox.Enabled = false;
            comboBox1.Enabled = false;
            // Change button text to add
            button1.Text = "Add New";
        }

        private void ClearForm()
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Text = string.Empty;
            notesTextBox.Text = string.Empty;
            _selectedStockOut = null;
        }

        private bool ValidateInput()
        {
            // Basic validation
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox2.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private async void SaveStockOutAsync()
        {
            if (!ValidateInput())
                return;

            int productId = (int)comboBox1.SelectedValue;
            int quantity = int.Parse(textBox2.Text);
            DateTime exitDate = dateTimePicker1.Value;
            string destination = textBox3.Text ?? string.Empty;
            // Ensure Notes is not null to prevent database errors
            string notes = notesTextBox.Text ?? string.Empty;

            try
            {
                if (_selectedStockOut == null)
                {
                    // Create new stock out
                    var stockOut = new StockOut
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        ExitDate = exitDate,
                        Destination = destination,
                        Notes = notes
                    };

                    await _stockOutRepository.AddAsync(stockOut);
                }
                else
                {
                    // Update existing stock out
                    _selectedStockOut.ProductId = productId;
                    _selectedStockOut.Quantity = quantity;
                    _selectedStockOut.ExitDate = exitDate;
                    _selectedStockOut.Destination = destination;
                    _selectedStockOut.Notes = notes;

                    await _stockOutRepository.UpdateAsync(_selectedStockOut);
                }

                LoadStockOutsAsync();
                ClearForm();
                SetReadOnlyMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving stock out: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isAddEditMode)
            {
                SaveStockOutAsync();
            }
            else
            {
                SetAddEditMode();
                ClearForm();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedStockOut = (StockOut)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                comboBox1.SelectedValue = _selectedStockOut.ProductId;
                textBox2.Text = _selectedStockOut.Quantity.ToString();
                dateTimePicker1.Value = _selectedStockOut.ExitDate;
                textBox3.Text = _selectedStockOut.Destination ?? string.Empty;
                notesTextBox.Text = _selectedStockOut.Notes ?? string.Empty;
            }
        }
    }
}
