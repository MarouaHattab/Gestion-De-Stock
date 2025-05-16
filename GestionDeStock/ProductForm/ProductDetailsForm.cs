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

namespace GestionDeStock.ProductForm
{
    public partial class ProductDetailsForm : Form
    {
        private Product? _product;
        private IServiceProvider? _serviceProvider;
        private List<Category>? _categories;
        private ComboBox? categoryComboBox;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        public ProductDetailsForm(Product product, IServiceProvider? serviceProvider = null) : this()
        {
            _product = product;
            _serviceProvider = serviceProvider ?? Program.ServiceProvider;
            _categories = new List<Category>(); // Initialize with empty list
            
            // Initialize CategoryId if it's a new product
            if (_product.ProductId == 0 && _product.CategoryId == 0)
            {
                _product.CategoryId = 1; // Default to first category or appropriate default
                _product.AlertThreshold = 5; // Set a default value for AlertThreshold
            }
            
            // Update this to avoid binding issues
            textBox7.Visible = false;
            
            productBindingSource.DataSource = _product;
            
            // If service provider is available, load categories
            if (_serviceProvider != null)
            {
                LoadCategories();
            }
            
            LoadProductData();
        }
        
        private void ProductDetailsForm_Load(object? sender, EventArgs e)
        {
            // Center the form on screen and ensure it's properly sized
            CenterToScreen();
            
            // Apply initial layout adjustments
            AdjustControlsLayout();
        }
        
        private void ProductDetailsForm_Resize(object? sender, EventArgs e)
        {
            // Adjust layout when form is resized
            AdjustControlsLayout();
        }
        
        private void AdjustControlsLayout()
        {
            // Adjust the width of columns in the table layout panel based on form size
            if (tableLayoutPanel2.ColumnStyles.Count >= 2)
            {
                // First column should take about 25% of the width on larger screens, more on smaller screens
                float labelColumnPercent = Math.Min(30, Math.Max(20, 900 / Math.Max(Width, 1)));
                tableLayoutPanel2.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, labelColumnPercent);
                tableLayoutPanel2.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100 - labelColumnPercent);
            }
            
            // Ensure buttons are properly sized
            int buttonWidth = Math.Min(130, Math.Max(100, Width / 8));
            if (buttonOK != null) buttonOK.Width = buttonWidth;
            if (buttonCancel != null) buttonCancel.Width = buttonWidth;
        }
        
        private async void LoadCategories()
        {
            try
            {
                if (_serviceProvider == null) return;
                
                var categoryRepo = _serviceProvider.GetRequiredService<ICategoryRepository>();
                _categories = await categoryRepo.GetAllCategoriesAsync();
                
                // Set up ComboBox for categories
                categoryComboBox = new ComboBox();
                categoryComboBox.Dock = DockStyle.Fill;
                categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                categoryComboBox.FormattingEnabled = true;
                
                // Replace textBox7 with categoryComboBox in the tableLayoutPanel2
                tableLayoutPanel2.Controls.Remove(textBox7);
                tableLayoutPanel2.Controls.Add(categoryComboBox, 1, 6);
                
                // Populate ComboBox with categories
                categoryComboBox.DisplayMember = "Name";
                categoryComboBox.ValueMember = "CategoryId";
                categoryComboBox.DataSource = _categories;
                
                // Set the selected item based on the product's CategoryId
                if (_product != null && _product.CategoryId > 0)
                {
                    foreach (Category category in categoryComboBox.Items)
                    {
                        if (category.CategoryId == _product.CategoryId)
                        {
                            categoryComboBox.SelectedItem = category;
                            break;
                        }
                    }
                }
                
                // Handle selection changed to update the product's CategoryId
                categoryComboBox.SelectedIndexChanged += (sender, e) =>
                {
                    if (categoryComboBox.SelectedItem != null && _product != null)
                    {
                        var selectedCategory = (Category)categoryComboBox.SelectedItem;
                        _product.CategoryId = selectedCategory.CategoryId;
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductData()
        {
            if (_product == null) return;
            
            // Set up data bindings for the text boxes
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", productBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", productBindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", productBindingSource, "PurchasePrice", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", productBindingSource, "SalePrice", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", productBindingSource, "AlertThreshold", true, DataSourceUpdateMode.OnPropertyChanged);
            // Make sure the AlertThreshold field is visible and properly labeled
            label5.Text = "Alert Threshold:";
            label5.Visible = true;
            textBox5.Visible = true;

            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", productBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged);

            // We no longer need binding for textBox7 as it's replaced with the ComboBox
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Validate inputs before accepting
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Product name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            int quantity;
            if (!int.TryParse(textBox2.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            decimal purchasePrice;
            if (!decimal.TryParse(textBox3.Text, out purchasePrice) || purchasePrice < 0)
            {
                MessageBox.Show("Purchase price must be a positive decimal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }

            decimal salePrice;
            if (!decimal.TryParse(textBox4.Text, out salePrice) || salePrice < 0)
            {
                MessageBox.Show("Sale price must be a positive decimal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }

            // Validate AlertThreshold
            int alertThreshold;
            if (!int.TryParse(textBox5.Text, out alertThreshold) || alertThreshold < 0)
            {
                MessageBox.Show("Alert threshold must be a positive integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
                return;
            }

            // Validate category is selected if using combo box
            if (categoryComboBox != null && categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoryComboBox.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
