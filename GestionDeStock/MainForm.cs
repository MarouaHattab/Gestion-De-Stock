using GestionDeStock.LoginForm;
using GestionDeStock.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeStock
{
    public partial class MainForm : Form
    {
        private readonly StockDbContext _dbContext;
        private readonly IServiceProvider _serviceProvider;

        public MainForm(StockDbContext dbContext, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _serviceProvider = serviceProvider;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Hide the main form initially
                this.Hide();

                try
                {
                    // Create login form with strong ownership
                    using (var loginForm = new LoginForm.LoginForm(_dbContext, _serviceProvider))
                    {
                        // Set owner explicitly
                        loginForm.Owner = this;
                        
                        // Show dialog and wait for result
                        DialogResult result = loginForm.ShowDialog();
                        
                        // Check the result
                        if (result != DialogResult.OK)
                        {
                            // If login was canceled, close the application
                            Application.Exit();
                        }
                        else
                        {
                            // DashboardForm is already opened in LoginForm
                            // We need to close this form properly
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error in login process: {ex.Message}");
                    MessageBox.Show($"Error in login process: {ex.Message}", "Login Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing application: {ex.Message}", "Application Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
