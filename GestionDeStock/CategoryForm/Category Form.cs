using GestionDeStock.Data.Entites;
using GestionDeStock.Data.Repositories;
using GestionDeStock.DashboardForm;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.CategoryForm
{
    public partial class Category_Form : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ICategoryRepository _categoryRepository;
        private List<Category> _categories; // Store the list of categories
        
        // Define modern color palette
        private readonly Color primaryColor = Color.FromArgb(0, 122, 204);
        private readonly Color secondaryColor = Color.FromArgb(45, 52, 64);
        private readonly Color accentColor = Color.FromArgb(97, 168, 237);
        private readonly Color textLightColor = Color.FromArgb(240, 240, 240);
        private readonly Color textDarkColor = Color.FromArgb(30, 30, 30);
        
        public Category_Form(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoryRepository = serviceProvider.GetRequiredService<ICategoryRepository>();
            
            InitializeComponent();
            
            // Clear event handlers to prevent duplication
            AddButton.Click -= AddButton_Click;
            UpdateButton.Click -= UpdateButton_Click;
            DeleteButton.Click -= DeleteButton_Click;
            ReloadButton.Click -= ReloadButton_Click_1;
            BackToDashboardButton.Click -= BackToDashboardButton_Click;
            
            // Initialize the categoryBindingSource with bindingSource1
            categoryBindingSource = bindingSource1;
            
            // Add event handlers for buttons
            AddButton.Click += AddButton_Click;
            UpdateButton.Click += UpdateButton_Click;
            DeleteButton.Click += DeleteButton_Click;
            ReloadButton.Click += ReloadButton_Click_1;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            
            // Add event handlers for responsiveness
            this.Load += CategoryListForm_Load;
            this.Resize += Category_Form_Resize;
            this.SizeChanged += Category_Form_SizeChanged;
            
            // Add selection changed event to enable/disable buttons based on selection
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            
            // Set form properties
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += Category_Form_FormClosing;
        }
        
        private void Category_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the form is closing without navigating back to dashboard,
            // show the dashboard anyway to prevent application exit
            if (!_navigatingBack)
            {
                ShowDashboard();
            }
        }

        private bool _navigatingBack = false;
        
        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            _navigatingBack = true;
            ShowDashboard();
            this.Close();
        }
        
        private void ShowDashboard()
        {
            try
            {
                // Get a reference to the existing dashboard form from the application's main window
                // or create a new one if needed
                Form mainForm = Application.OpenForms["DashboardForm"];
                if (mainForm != null)
                {
                    // Use existing dashboard form
                    mainForm.Show();
                }
                else
                {
                    // Create a new dashboard form if none exists
                    var dashboardForm = _serviceProvider.GetRequiredService<DashboardForm.DashboardForm>();
                    dashboardForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Dashboard: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Enable/disable update and delete buttons based on whether a row is selected
            bool hasSelection = dataGridView1.SelectedRows.Count > 0;
            UpdateButton.Enabled = hasSelection;
            DeleteButton.Enabled = hasSelection;
            
            // Apply proper styling to disabled buttons
            if (!hasSelection)
            {
                UpdateButton.BackColor = Color.FromArgb(200, 200, 200);
                DeleteButton.BackColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                StyleButton(UpdateButton, Color.FromArgb(0, 123, 255));
                StyleButton(DeleteButton, Color.FromArgb(220, 53, 69));
            }
        }
        
        private void ApplyModernStyling()
        {
            // Apply form styling
            this.BackColor = Color.White;
            
            // Style the layout panels
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Padding = new Padding(10);
            
            // Apply modern styling to DataGridView
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            
            // Style the column headers
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = textLightColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            
            // Style the rows
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            
            // Style all buttons
            StyleButton(AddButton, Color.FromArgb(40, 167, 69)); // Green for add
            StyleButton(UpdateButton, Color.FromArgb(0, 123, 255)); // Blue for update
            StyleButton(DeleteButton, Color.FromArgb(220, 53, 69)); // Red for delete
            StyleButton(ReloadButton, Color.FromArgb(108, 117, 125)); // Gray for reload
            StyleButton(BackToDashboardButton, Color.FromArgb(52, 58, 64)); // Dark for back button
            
            // Style the Back to Dashboard button specially
            BackToDashboardButton.TextAlign = ContentAlignment.MiddleCenter;
            
            // Initially disable update and delete buttons until a row is selected
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
            UpdateButton.BackColor = Color.FromArgb(200, 200, 200);
            DeleteButton.BackColor = Color.FromArgb(200, 200, 200);
        }
        
        private void StyleButton(Button button, Color buttonColor)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = buttonColor;
            button.ForeColor = textLightColor;
            button.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleRight;
            button.Padding = new Padding(10, 0, 10, 0);
            button.Cursor = Cursors.Hand;
            
            // Add hover effects
            button.MouseEnter += (s, e) => {
                if (button.Enabled)
                {
                    Button btn = (Button)s;
                    btn.BackColor = ControlPaint.Light(buttonColor, 0.1f);
                }
            };
            
            button.MouseLeave += (s, e) => {
                if (button.Enabled)
                {
                    Button btn = (Button)s;
                    btn.BackColor = buttonColor;
                }
            };
        }

        private void AdjustColumnsWidth()
        {
            // Make columns responsive
            if (dataGridView1.Columns.Count >= 2)
            {
                // Name column takes 30% of the space
                dataGridView1.Columns[0].FillWeight = 30;
                
                // Description column takes 70% of the space
                dataGridView1.Columns[1].FillWeight = 70;
            }
        }
        
        private void Category_Form_Resize(object sender, EventArgs e)
        {
            AdjustLayoutForSize();
        }
        
        private void Category_Form_SizeChanged(object sender, EventArgs e)
        {
            AdjustLayoutForSize();
        }
        
        private void AdjustLayoutForSize()
        {
            try
            {
                // Adjust side panel width based on form width
                int sidebarWidth = Math.Max(Math.Min(this.Width / 4, 250), 180);
                tableLayoutPanel1.ColumnStyles[0].Width = sidebarWidth;
                
                // Adjust button sizes based on form size
                int buttonWidth = Math.Max(sidebarWidth - 20, 160);
                
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Button button)
                    {
                        button.Width = buttonWidth;
                        
                        // Adjust font size based on form size
                        if (this.Width < 800)
                            button.Font = new Font(button.Font.FontFamily, 10, button.Font.Style);
                        else if (this.Width < 1000)
                            button.Font = new Font(button.Font.FontFamily, 11, button.Font.Style);
                        else
                            button.Font = new Font(button.Font.FontFamily, 12, button.Font.Style);
                    }
                }
                
                // Adjust DataGridView to fit the available space
                AdjustColumnsWidth();
            }
            catch (Exception ex)
            {
                // Log exception but don't crash
                System.Diagnostics.Debug.WriteLine($"Error adjusting layout: {ex.Message}");
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new category
                var category = new Category();
                
                // Create and show the details form
                var dialogForm = new CategoryDetailsForm(category);
                var dialogResult = dialogForm.ShowDialog();
                
                if (dialogResult == DialogResult.OK)
                {
                    // Validate category data
                    bool isValid = true;
                    string validationMessage = "";
                    
                    if (string.IsNullOrWhiteSpace(category.Name))
                    {
                        validationMessage = "Category name cannot be empty.";
                        isValid = false;
                    }
                    
                    if (string.IsNullOrWhiteSpace(category.Description))
                    {
                        validationMessage = string.IsNullOrEmpty(validationMessage) 
                            ? "Category description cannot be empty."
                            : "Category name and description cannot be empty.";
                        isValid = false;
                    }
                    
                    if (!isValid)
                    {
                        MessageBox.Show(validationMessage, "Validation Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    // Add the category to the database
                    var result = await _categoryRepository.AddCategoryAsync(category);
                    
                    if (result != null && result.CategoryId > 0)
                    {
                        MessageBox.Show("Category added successfully.", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Reload the data to show the new category
                        await ReloadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add category.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ReloadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                
                // Clear the current binding
                dataGridView1.DataSource = null;
                categoryBindingSource.DataSource = null;
                
                // Get categories from repository
                _categories = await _categoryRepository.GetAllCategoriesAsync();
                
                // Set the binding source
                categoryBindingSource.DataSource = _categories;
                dataGridView1.DataSource = categoryBindingSource;
                
                // Adjust column widths after loading data
                AdjustColumnsWidth();
                
                // Update buttons based on selection
                DataGridView1_SelectionChanged(dataGridView1, EventArgs.Empty);
                
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CategoryListForm_Load(object sender, EventArgs e)
        {
            // Apply styling
            ApplyModernStyling();
            
            // Set minimum form size
            this.MinimumSize = new Size(700, 500);
            
            // Initialize layout
            AdjustLayoutForSize();
            
            // Load data
            await ReloadData();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a category to update.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                // Get the selected category
                var category = dataGridView1.CurrentRow.DataBoundItem as Category;
                if (category == null)
                {
                    MessageBox.Show("Failed to get the selected category.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Create and show the details form
                var dialogForm = new CategoryDetailsForm(category);
                var dialogResult = dialogForm.ShowDialog();
                
                if (dialogResult == DialogResult.OK)
                {
                    // Validate category data again here as a fallback
                    bool isValid = true;
                    string validationMessage = "";
                    
                    if (string.IsNullOrWhiteSpace(category.Name))
                    {
                        validationMessage = "Category name cannot be empty.";
                        isValid = false;
                    }
                    
                    if (string.IsNullOrWhiteSpace(category.Description))
                    {
                        validationMessage = string.IsNullOrEmpty(validationMessage) 
                            ? "Category description cannot be empty."
                            : "Category name and description cannot be empty.";
                        isValid = false;
                    }
                    
                    if (!isValid)
                    {
                        MessageBox.Show(validationMessage, "Validation Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    // Update the category in the database
                    var result = await _categoryRepository.UpdateCategoryAsync(category);
                    
                    if (result != null)
                    {
                        MessageBox.Show("Category updated successfully.", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Reload the data to show the updated category
                        await ReloadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update category.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating category: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a category to delete.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                // Get the selected category
                var category = dataGridView1.CurrentRow.DataBoundItem as Category;
                if (category == null)
                {
                    MessageBox.Show("Failed to get the selected category.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the category '{category.Name}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Check if category has products
                        if (category.Products != null && category.Products.Count > 0)
                        {
                            var productWarning = MessageBox.Show(
                                $"Category '{category.Name}' has {category.Products.Count} products. Deleting this category will affect these products. Continue?",
                                "Warning",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (productWarning == DialogResult.No)
                                return;
                        }
                        
                        // Delete the category from the database
                        await _categoryRepository.DeleteCategoryAsync(category.CategoryId);
                        
                        MessageBox.Show("Category deleted successfully.", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Reload the data
                        await ReloadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during deletion: {ex.Message}", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting category: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ReloadButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Set cursor to wait cursor
                this.Cursor = Cursors.WaitCursor;
                
                // Disable the button while reloading
                ReloadButton.Enabled = false;
                
                // Reload the data
                await ReloadData();
                
                // Re-enable the button
                ReloadButton.Enabled = true;
                
                // Reset cursor
                this.Cursor = Cursors.Default;
                
                // Show feedback
                MessageBox.Show("Categories reloaded successfully.", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Reset cursor and button state
                this.Cursor = Cursors.Default;
                ReloadButton.Enabled = true;
                
                MessageBox.Show($"Error reloading categories: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
