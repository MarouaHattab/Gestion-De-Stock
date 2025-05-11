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
    public partial class RegisterForm : Form
    {
        private readonly StockDbContext _dbContext;

        public RegisterForm()
        {
            InitializeComponent();

            // Get the DbContext from the service provider
            var serviceProvider = Program.ServiceProvider;
            _dbContext = serviceProvider.GetRequiredService<StockDbContext>();

            // Set up event handlers
            chkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            btnRegister.Click += BtnRegister_Click;
            lnkLogin.LinkClicked += LnkLogin_LinkClicked;
            this.Resize += RegisterForm_Resize;

            // Set default images if resources are missing
            SetDefaultImages();

            // Apply visual effects
            ApplyVisualEffects();
        }

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            // Adjust panel sizes when form is resized
            AdjustControlsOnResize();
        }

        private void AdjustControlsOnResize()
        {
            // Adjust register content panel to maintain proper proportions
            int padding = Math.Max(20, Width / 30);
            panelRegisterContent.Padding = new Padding(padding);
            
            // Adjust text input widths to fit the panel
            int textBoxWidth = panelUsername.Width - pictureBoxUser.Width - 50;
            txtUsername.Width = textBoxWidth;
            txtPassword.Width = textBoxWidth;
            txtConfirmPassword.Width = textBoxWidth;
            
            // Adjust underlines
            panelUsernameUnderline.Width = panelUsername.Width - 10;
            panelPasswordUnderline.Width = panelPassword.Width - 10;
            panelConfirmPasswordUnderline.Width = panelConfirmPassword.Width - 10;
            
            // Center the link
            lnkLogin.Left = (panelRegisterContent.Width - lnkLogin.Width) / 2;
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

                if (pictureBoxConfirmPassword.Image == null)
                {
                    pictureBoxConfirmPassword.Image = SystemIcons.Shield.ToBitmap();
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
            // Add shadow effect to the register panel
            panelRegisterContent.BackColor = Color.White;

            // Add hover effect to the register button
            btnRegister.MouseEnter += (s, e) =>
            {
                btnRegister.BackColor = Color.FromArgb(0, 102, 204); // Darker blue on hover
            };

            btnRegister.MouseLeave += (s, e) =>
            {
                btnRegister.BackColor = Color.FromArgb(0, 122, 204); // Original blue
            };

            // Add focus effects for text boxes
            txtUsername.Enter += (s, e) => panelUsernameUnderline.Height = 3;
            txtUsername.Leave += (s, e) => panelUsernameUnderline.Height = 2;

            txtPassword.Enter += (s, e) => panelPasswordUnderline.Height = 3;
            txtPassword.Leave += (s, e) => panelPasswordUnderline.Height = 2;

            txtConfirmPassword.Enter += (s, e) => panelConfirmPasswordUnderline.Height = 3;
            txtConfirmPassword.Leave += (s, e) => panelConfirmPasswordUnderline.Height = 2;
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility for both password fields
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Disable the register button to prevent multiple clicks
            btnRegister.Enabled = false;
            
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string confirmPassword = txtConfirmPassword.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate username length
                if (username.Length < 3)
                {
                    MessageBox.Show("Username must be at least 3 characters long.", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate password strength
                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if passwords match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if username already exists
                RegisterUser(username, password);
            }
            finally
            {
                // Re-enable the register button
                btnRegister.Enabled = true;
            }
        }
        
        private void RegisterUser(string username, string password)
        {
            try
            {
                // Log username being checked
                System.Diagnostics.Debug.WriteLine($"Checking if username exists: '{username}'");
                
                // Force a fresh reload of users from database to avoid stale data
                _dbContext.ChangeTracker.Clear();
                
                // Get all users for debugging
                var allUsers = _dbContext.Users.AsNoTracking().ToList();
                System.Diagnostics.Debug.WriteLine($"Total users in database: {allUsers.Count}");
                foreach (var user in allUsers)
                {
                    System.Diagnostics.Debug.WriteLine($"User in DB: '{user.Username}', ID: {user.UserId}");
                }
                
                // Check if the username already exists (case-insensitive)
                bool usernameExists = allUsers.Any(u => 
                    string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
                
                if (usernameExists)
                {
                    System.Diagnostics.Debug.WriteLine($"Username '{username}' already exists in database");
                    MessageBox.Show("Username already exists. Please choose another one.", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                System.Diagnostics.Debug.WriteLine($"Username '{username}' is available, proceeding with registration");

                // Start a transaction to ensure data consistency
                using (var transaction = _dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        // Create the new user
                        System.Diagnostics.Debug.WriteLine($"Creating new user: '{username}'");
                        var newUser = new GestionDeStock.Data.Entites.User
                        {
                            Username = username,
                            Password = password,
                            IsAdmin = false // Regular user by default
                        };

                        _dbContext.Users.Add(newUser);
                        _dbContext.SaveChanges();
                        
                        // Commit the transaction
                        transaction.Commit();
                        
                        System.Diagnostics.Debug.WriteLine($"User saved to database successfully with ID: {newUser.UserId}");

                        // Store the username in the Tag property for use by the login form
                        this.Tag = username;
                        
                        MessageBox.Show("Account created successfully!", "Registration Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Close this form and return to login
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Roll back the transaction on error
                        transaction.Rollback();
                        throw; // Re-throw to be caught by the outer try-catch
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in registration: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                MessageBox.Show($"Error creating account: {ex.Message}", "Registration Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Return to login form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
