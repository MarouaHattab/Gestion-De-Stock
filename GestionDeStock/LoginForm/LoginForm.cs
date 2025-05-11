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

        public LoginForm()
        {
            InitializeComponent();

            // Get the DbContext from the service provider
            var serviceProvider = Program.ServiceProvider;
            _dbContext = serviceProvider.GetRequiredService<StockDbContext>();

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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if user exists with matching credentials
            var user = _dbContext.Users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {username}!", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Open the main form and close this one
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Implement account creation functionality
            MessageBox.Show("The account creation functionality will be implemented here.",
                "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }
    }
}