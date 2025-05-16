using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeStock.LoginForm
{
    public partial class LoginForm : Form
    {
        private readonly StockDbContext _dbContext;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(StockDbContext dbContext, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _serviceProvider = serviceProvider;

            // Set up event handlers
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            btnLogin.Click += BtnLogin_Click;
            lnkCreateAccount.LinkClicked += LnkCreateAccount_LinkClicked;
            this.Resize += LoginForm_Resize;

            // Set default images if resources are missing
            SetDefaultImages();

            // Apply visual effects
            ApplyVisualEffects();
        }
        
        // Default constructor for DI
        public LoginForm()
        {
            InitializeComponent();

            // Get the DbContext from the service provider
            var serviceProvider = Program.ServiceProvider;
            _dbContext = serviceProvider.GetRequiredService<StockDbContext>();
            _serviceProvider = serviceProvider;

            // Set up event handlers
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            btnLogin.Click += BtnLogin_Click;
            lnkCreateAccount.LinkClicked += LnkCreateAccount_LinkClicked;
            this.Resize += LoginForm_Resize;

            // Set default images if resources are missing
            SetDefaultImages();

            // Apply visual effects
            ApplyVisualEffects();
        }

        private void SetDefaultImages()
        {
            try
            {
                // Use default icons if image resources are not available
                if (pictureBoxLogo.Image == null)
                {
                    pictureBoxLogo.Image = SystemIcons.Application.ToBitmap();
                }

                if (pictureBoxUser.Image == null)
                {
                    pictureBoxUser.Image = SystemIcons.Information.ToBitmap();
                }

                if (pictureBoxPassword.Image == null)
                {
                    pictureBoxPassword.Image = SystemIcons.Shield.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                // Log the error but don't crash the application
                Console.WriteLine($"Error loading images: {ex.Message}");
            }
        }

        private void ApplyVisualEffects()
        {
            // Add shadow effect to the login panel
            panelLoginContent.BackColor = Color.White;

            // Add hover effect to the login button
            btnLogin.MouseEnter += (s, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(0, 102, 204); // Darker blue on hover
            };

            btnLogin.MouseLeave += (s, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(0, 122, 204); // Original blue
            };

            // Add focus effects for text boxes
            txtUsername.Enter += (s, e) => panelUsernameUnderline.Height = 3;
            txtUsername.Leave += (s, e) => panelUsernameUnderline.Height = 2;

            txtPassword.Enter += (s, e) => panelPasswordUnderline.Height = 3;
            txtPassword.Leave += (s, e) => panelPasswordUnderline.Height = 2;
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Disable the login button to prevent multiple clicks
            btnLogin.Enabled = false;
            
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a username and password.", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Attempt to log in
                AttemptLogin(username, password);
            }
            finally
            {
                // Re-enable the login button
                btnLogin.Enabled = true;
            }
        }
        
        private void AttemptLogin(string username, string password)
        {
            try
            {
                // Log login attempt
                System.Diagnostics.Debug.WriteLine($"Login attempt for username: '{username}'");
                
                // Force a fresh reload of users from database to avoid stale data
                _dbContext.ChangeTracker.Clear();
                
                // Get all users for debugging
                var allUsers = _dbContext.Users.AsNoTracking().ToList();
                System.Diagnostics.Debug.WriteLine($"Total users in database: {allUsers.Count}");
                foreach (var userItem in allUsers)
                {
                    System.Diagnostics.Debug.WriteLine($"User in DB: '{userItem.Username}', ID: {userItem.UserId}, IsAdmin: {userItem.IsAdmin}");
                }
                
                // Check if user exists with matching credentials using the same approach as registration
                var foundUser = allUsers.FirstOrDefault(u => 
                    string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase) && 
                    u.Password == password);

                if (foundUser != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Login successful for: '{username}' (ID: {foundUser.UserId}, IsAdmin: {foundUser.IsAdmin})");
                    MessageBox.Show($"Welcome {username}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        System.Diagnostics.Debug.WriteLine("Setting DialogResult.OK and closing login form...");
                        
                        // Set the DialogResult to OK to signal that login was successful
                        // This will be used by the StockAppContext to transition to the dashboard
                        this.DialogResult = DialogResult.OK;
                        
                        // Close the login form
                        this.Close();
                        
                        System.Diagnostics.Debug.WriteLine("Login form closed with DialogResult.OK");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error during login form transition: {ex.Message}");
                        System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                        MessageBox.Show($"Error transitioning to dashboard: {ex.Message}", "Navigation Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Login failed for: '{username}'");
                    MessageBox.Show("Incorrect username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in login: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                MessageBox.Show($"Login error: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Registration feature is currently disabled. Please contact an administrator to create an account.", 
                "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUser_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblSlogan_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            // Adjust panel sizes when form is resized
            AdjustControlsOnResize();
        }

        private void AdjustControlsOnResize()
        {
            // Adjust login content panel to maintain proper proportions
            int padding = Math.Max(20, Width / 30);
            panelLoginContent.Padding = new Padding(padding);

            // Adjust text input widths to fit the panel
            int textBoxWidth = panelUsername.Width - pictureBoxUser.Width - 50;
            txtUsername.Width = textBoxWidth;
            txtPassword.Width = textBoxWidth;

            // Adjust underlines
            panelUsernameUnderline.Width = panelUsername.Width - 10;
            panelPasswordUnderline.Width = panelPassword.Width - 10;

            // Center the link
            lnkCreateAccount.Left = (panelLoginContent.Width - lnkCreateAccount.Width) / 2;
        }

        private void lnkCreateAccount_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Registration not available for now
            MessageBox.Show("Registration feature is currently disabled.", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}