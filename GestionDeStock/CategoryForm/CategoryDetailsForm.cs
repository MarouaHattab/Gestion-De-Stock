using GestionDeStock.Data.Entites;
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
    public partial class CategoryDetailsForm : Form
    {
        private Category _category;
        // Define modern color palette
        private readonly Color primaryColor = Color.FromArgb(0, 122, 204);
        private readonly Color secondaryColor = Color.FromArgb(45, 52, 64);
        private readonly Color accentColor = Color.FromArgb(97, 168, 237);
        private readonly Color textLightColor = Color.FromArgb(240, 240, 240);
        private readonly Color successColor = Color.FromArgb(40, 167, 69);
        private readonly Color cancelColor = Color.FromArgb(220, 53, 69);
        private readonly Color errorColor = Color.FromArgb(255, 200, 200);

        public CategoryDetailsForm(Category category)
        {
            InitializeComponent();
            _category = category;
            
            // Set up event handlers
            this.Load += CategoryDetailsForm_Load;
            this.Resize += CategoryDetailsForm_Resize;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;
            buttonOK.Click += ButtonOK_Click;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            
            // Validate before accepting
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.BackColor = errorColor;
                textBox1.Focus();
                isValid = false;
            }
            
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Category description cannot be empty.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.BackColor = errorColor;
                if (isValid) // Only focus if name was valid
                {
                    textBox2.Focus();
                }
                isValid = false;
            }
            
            if (!isValid)
            {
                // Cancel the dialog close
                DialogResult = DialogResult.None;
                return;
            }
            
            // Update the category with form values
            _category.Name = textBox1.Text.Trim();
            _category.Description = textBox2.Text.Trim();
            
            // DialogResult is already set from the button property
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Clear error highlighting when user types
            if (textBox1.BackColor == errorColor)
            {
                textBox1.BackColor = Color.White;
            }
        }
        
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Clear error highlighting when user types
            if (textBox2.BackColor == errorColor)
            {
                textBox2.BackColor = Color.White;
            }
        }

        private void CategoryDetailsForm_Load(object sender, EventArgs e)
        {
            // Apply modern styling
            ApplyModernStyling();
            
            // Set data binding
            SetupDataBinding();
            
            // Initialize layout
            AdjustLayoutForSize();
            
            // Focus on name field
            textBox1.Focus();
        }
        
        private void SetupDataBinding()
        {
            // Unbind first to prevent issues
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            
            // Set up binding source
            categoryBindingSource.DataSource = _category;
            
            // Manual binding for better control
            textBox1.Text = _category.Name ?? "";
            textBox2.Text = _category.Description ?? "";
        }
        
        private void CategoryDetailsForm_Resize(object sender, EventArgs e)
        {
            AdjustLayoutForSize();
        }
        
        private void AdjustLayoutForSize()
        {
            try
            {
                // Adjust text box sizes based on form size
                textBox1.Width = Math.Max(Math.Min(this.Width - 200, 600), 250);
                textBox2.Width = textBox1.Width;
                
                // Center the group box if there's extra space
                int availableWidth = tableLayoutPanel1.Width;
                int idealWidth = textBox1.Width + 200; // Add space for labels
                
                if (availableWidth > idealWidth)
                {
                    int padding = (availableWidth - idealWidth) / 2;
                    groupBox1.Padding = new Padding(padding, 15, padding, 15);
                }
                else
                {
                    groupBox1.Padding = new Padding(15);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AdjustLayoutForSize: {ex.Message}");
            }
        }
        
        private void ApplyModernStyling()
        {
            // Form styling
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            // Header styling
            CategoryDetailsFormbutton.FlatStyle = FlatStyle.Flat;
            CategoryDetailsFormbutton.FlatAppearance.BorderSize = 0;
            CategoryDetailsFormbutton.BackColor = primaryColor;
            CategoryDetailsFormbutton.ForeColor = textLightColor;
            
            // GroupBox styling
            groupBox1.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            groupBox1.ForeColor = secondaryColor;
            
            // Label styling
            StyleLabel(label1);
            StyleLabel(label2);
            
            // TextBox styling
            StyleTextBox(textBox1);
            StyleTextBox(textBox2);
            
            // Button styling
            StyleButton(buttonOK, successColor);
            StyleButton(buttonCancel, cancelColor);
            
            // Panel styling
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Padding = new Padding(10);
        }
        
        private void StyleLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label.ForeColor = secondaryColor;
        }
        
        private void StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 10);
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.White;
            
            // Add focus events for better visual feedback
            textBox.Enter += (s, e) => {
                if (((TextBox)s).BackColor != errorColor)
                    ((TextBox)s).BackColor = Color.FromArgb(245, 245, 245);
            };
            
            textBox.Leave += (s, e) => {
                if (((TextBox)s).BackColor != errorColor)
                    ((TextBox)s).BackColor = Color.White;
            };
        }
        
        private void StyleButton(Button button, Color buttonColor)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = buttonColor;
            button.ForeColor = textLightColor;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            
            // Add hover effects
            button.MouseEnter += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = ControlPaint.Light(buttonColor, 0.1f);
            };
            
            button.MouseLeave += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = buttonColor;
            };
        }

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }
    }
}
