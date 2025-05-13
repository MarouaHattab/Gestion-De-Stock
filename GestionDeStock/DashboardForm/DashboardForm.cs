using GestionDeStock.Data.Entites;
using GestionDeStock.Data.Repositories;
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

namespace GestionDeStock.DashboardForm
{
    public partial class DashboardForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        // Define modern color palette
        private readonly Color primaryColor = Color.FromArgb(0, 122, 204);
        private readonly Color secondaryColor = Color.FromArgb(45, 52, 64);
        private readonly Color accentColor = Color.FromArgb(97, 168, 237);
        private readonly Color textLightColor = Color.FromArgb(240, 240, 240);
        private readonly Color textDarkColor = Color.FromArgb(30, 30, 30);
        
        // Stock alert indicators
        private Label alertBadge;
        private int _zeroStockCount = 0;
        private int _lowStockCount = 0;

        public DashboardForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            
            // Set the form name for finding it later
            this.Name = "DashboardForm";
            
            // Add event handlers for responsiveness
            this.Load += DashboardForm_Load;
            this.Resize += DashboardForm_Resize;
            this.SizeChanged += DashboardForm_SizeChanged;
            
            // Create notification badge for alerts
            CreateAlertBadge();
        }
        
        private void CreateAlertBadge()
        {
            // Create a notification badge for the alert button
            alertBadge = new Label
            {
                Text = "0",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(220, 53, 69), // Red
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(24, 24),
                AutoSize = false,
                Visible = false
            };
            
            // Make it round
            alertBadge.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, alertBadge.Width - 1, alertBadge.Height - 1);
                    alertBadge.Region = new Region(path);
                }
            };
            
            // Add it to the form
            this.Controls.Add(alertBadge);
            alertBadge.BringToFront();
        }
        
        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            // Set initial form properties
            this.MinimumSize = new Size(800, 450);
            
            // Apply modern styling
            ApplyModernStyling();
            
            // Set initial layout
            AdjustControlsForResponsiveness();
            
            // Check for stock alerts
            await CheckStockAlerts();
        }
        
        private async Task CheckStockAlerts()
        {
            try
            {
                // Get the product repository from DI
                var productRepo = _serviceProvider.GetRequiredService<IProductRepository>();
                
                // Get all products to check for zero stock
                var allProducts = await productRepo.GetAllProductsAsync();
                
                // Count products with zero stock
                _zeroStockCount = allProducts.Count(p => p.Quantity == 0);
                
                // Get products with stock below their AlertThreshold but not zero
                var lowStockProducts = await productRepo.GetLowStockProductsAsync();
                _lowStockCount = lowStockProducts.Count(p => p.Quantity > 0);
                
                // Update the alert badge
                UpdateAlertBadge();
            }
            catch (Exception ex)
            {
                // Just log the error - don't show a message box as this is happening on load
                System.Diagnostics.Debug.WriteLine($"Error checking stock alerts: {ex.Message}");
            }
        }
        
        private void UpdateAlertBadge()
        {
            // Calculate total alerts
            int totalAlerts = _zeroStockCount + _lowStockCount;
            
            if (totalAlerts > 0)
            {
                // Update badge text
                alertBadge.Text = totalAlerts > 99 ? "99+" : totalAlerts.ToString();
                
                // Show the badge
                alertBadge.Visible = true;
                
                // Change badge color based on severity
                if (_zeroStockCount > 0)
                {
                    alertBadge.BackColor = Color.FromArgb(220, 53, 69); // Red for out of stock
                }
                else
                {
                    alertBadge.BackColor = Color.FromArgb(255, 193, 7); // Yellow for low stock
                }
                
                // Update alert button text
                if (_zeroStockCount > 0)
                {
                    AlertButton.Text = "⚠️ Alert";
                    AlertButton.ForeColor = Color.FromArgb(220, 53, 69);
                }
                else
                {
                    AlertButton.Text = "Alert";
                    AlertButton.ForeColor = textLightColor;
                }
            }
            else
            {
                // No alerts - hide the badge
                alertBadge.Visible = false;
                AlertButton.Text = "Alert";
                AlertButton.ForeColor = textLightColor;
            }
            
            // Position the badge
            PositionAlertBadge();
        }
        
        private void PositionAlertBadge()
        {
            if (AlertButton != null && alertBadge != null)
            {
                // Calculate position on top right of the AlertButton
                alertBadge.Left = AlertButton.Right - 30;
                alertBadge.Top = AlertButton.Top + 10;
                alertBadge.BringToFront();
            }
        }
        
        private void ApplyModernStyling()
        {
            // Apply form styling
            this.BackColor = Color.White;
            
            // Style the header panel
            flowLayoutPanel1.BackColor = primaryColor;
            flowLayoutPanel1.Padding = new Padding(10, 5, 10, 5);
            label1.ForeColor = textLightColor;
            
            // Style all buttons with a modern look
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {
                    StyleButton(button);
                }
            }
        }
        
        private void StyleButton(Button button)
        {
            // Apply modern styling to buttons
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = secondaryColor;
            button.ForeColor = textLightColor;
            button.Padding = new Padding(10, 0, 10, 0);
            button.FlatAppearance.MouseOverBackColor = accentColor;
            button.Cursor = Cursors.Hand;
            
            // Add hover effect using mouse events
            button.MouseEnter += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = accentColor;
            };
            
            button.MouseLeave += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = secondaryColor;
            };
        }
        
        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            // Adjust layout when form is resized
            AdjustControlsForResponsiveness();
        }
        
        private void DashboardForm_SizeChanged(object sender, EventArgs e)
        {
            // Adjust layout when form size changes
            AdjustControlsForResponsiveness();
        }
        
        private void AdjustControlsForResponsiveness()
        {
            try
            {
                // Adjust the flow layout panel to span the entire width
                flowLayoutPanel1.Width = tableLayoutPanel1.Width - 6; // Account for margins
                
                // Calculate label positioning for proper centering
                int availableWidth = flowLayoutPanel1.Width;
                int labelWidth = TextRenderer.MeasureText(label1.Text, label1.Font).Width;
                
                // Center the label in the flow panel
                if (availableWidth > labelWidth)
                {
                    int centerX = (availableWidth - labelWidth) / 2;
                    label1.Margin = new Padding(centerX, 5, 3, 0);
                }
                else
                {
                    label1.Margin = new Padding(10, 5, 3, 0);
                }
                
                // Adjust font sizes based on form width
                AdjustFontSizesForFormWidth();
                
                // Adjust buttons for better appearance at different sizes
                AdjustButtonsAppearance();
                
                // Add subtle shadow effect to buttons based on size
                if (this.Width >= 1000)
                {
                    AddButtonShadowEffects(4);
                }
                else if (this.Width >= 800)
                {
                    AddButtonShadowEffects(3);
                }
                else
                {
                    AddButtonShadowEffects(2);
                }
                
                // Update alert badge position
                PositionAlertBadge();
                
                // Refresh layout
                tableLayoutPanel1.PerformLayout();
                flowLayoutPanel1.PerformLayout();
            }
            catch (Exception ex)
            {
                // Log exception but don't crash
                System.Diagnostics.Debug.WriteLine($"Error in AdjustControlsForResponsiveness: {ex.Message}");
            }
        }

        private void AddButtonShadowEffects(int shadowSize)
        {
            try
            {
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Button button)
                    {
                        button.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
                        button.FlatAppearance.BorderSize = 1;
                        button.Padding = new Padding(shadowSize);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AddButtonShadowEffects: {ex.Message}");
            }
        }

        private void AdjustFontSizesForFormWidth()
        {
            try
            {
                // Adjust title font size based on form width
                if (this.Width >= 1200)
                {
                    label1.Font = new Font("Segoe UI", 32, FontStyle.Bold);
                }
                else if (this.Width >= 1000)
                {
                    label1.Font = new Font("Segoe UI", 28, FontStyle.Bold);
                }
                else if (this.Width >= 800)
                {
                    label1.Font = new Font("Segoe UI", 24, FontStyle.Bold);
                }
                else
                {
                    label1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                }
                
                // Adjust button font sizes based on form width
                float buttonFontSize = 15.75f; // Default
                
                if (this.Width >= 1200)
                {
                    buttonFontSize = 16f;
                }
                else if (this.Width < 900)
                {
                    buttonFontSize = 14f;
                }
                
                // Apply font size to all buttons
                CategoryButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
                ProductsButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
                StatisticsButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
                InStockButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
                OutStockButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
                AlertButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
                LogOutButton.Font = new Font("Segoe UI", buttonFontSize, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AdjustFontSizesForFormWidth: {ex.Message}");
            }
        }

        private void AdjustButtonsAppearance()
        {
            try
            {
                // Adjust button text alignment based on width
                if (this.Width < 900)
                {
                    // For smaller widths, center text for better appearance
                    CategoryButton.TextAlign = ContentAlignment.MiddleCenter;
                    ProductsButton.TextAlign = ContentAlignment.MiddleCenter;
                    StatisticsButton.TextAlign = ContentAlignment.MiddleCenter;
                    InStockButton.TextAlign = ContentAlignment.MiddleCenter;
                    OutStockButton.TextAlign = ContentAlignment.MiddleCenter;
                    AlertButton.TextAlign = ContentAlignment.MiddleCenter;
                    LogOutButton.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    // For larger widths, keep text right-aligned from the icon
                    CategoryButton.TextAlign = ContentAlignment.MiddleRight;
                    ProductsButton.TextAlign = ContentAlignment.MiddleRight;
                    StatisticsButton.TextAlign = ContentAlignment.MiddleRight;
                    InStockButton.TextAlign = ContentAlignment.MiddleRight;
                    OutStockButton.TextAlign = ContentAlignment.MiddleRight;
                    AlertButton.TextAlign = ContentAlignment.MiddleRight;
                    LogOutButton.TextAlign = ContentAlignment.MiddleRight;
                }
                
                // Apply custom styling for logout button to make it stand out
                LogOutButton.BackColor = Color.FromArgb(204, 51, 51);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AdjustButtonsAppearance: {ex.Message}");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Category form
                var categoryForm = _serviceProvider.GetRequiredService<GestionDeStock.CategoryForm.Category_Form>();
                
                // Show the Category form
                categoryForm.Show();
                
                // Hide dashboard instead of closing it
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening category form: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<GestionDeStock.ProductForm.ProductListForm>();
            form.Show();
            this.Hide();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<GestionDeStock.StatForm.StatForm>();
            form.Show();
            this.Hide();
        }

        private void InStockButton_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<GestionDeStock.StockInForm.StockInForm>();
            form.Show();
            this.Hide();
        }

        private void OutStockButton_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<GestionDeStock.StockOutForm.StockOutForm>();
            form.Show();
            this.Hide();
        }

        private void AlertButton_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<GestionDeStock.AlertForm.AlertForm>();
            form.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new LoginForm directly instead of using DI
                var loginForm = new LoginForm.LoginForm();
                loginForm.Show();
                
                // Close this dashboard form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during logout: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
