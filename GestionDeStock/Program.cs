using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestionDeStock.Data;
using System.Windows.Forms;

namespace GestionDeStock
{
    // Custom application context to manage form transitions
    public class StockAppContext : ApplicationContext
    {
        private Form _currentForm;
        private readonly IServiceProvider _serviceProvider;

        public StockAppContext(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            
            // Start with the login form
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            // Create the login form
            var loginForm = _serviceProvider.GetRequiredService<LoginForm.LoginForm>();
            
            // Set up the form closed event to handle transitions
            loginForm.FormClosed += LoginForm_FormClosed;
            
            // Set as the current form and show it
            _currentForm = loginForm;
            _currentForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If the login form was closed with OK result, show the dashboard
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                ShowDashboardForm();
            }
            else
            {
                // Otherwise exit the application
                ExitThread();
            }
        }

        private void ShowDashboardForm()
        {
            // Create and show the dashboard form
            var dashboardForm = _serviceProvider.GetRequiredService<DashboardForm.DashboardForm>();
            
            // Don't exit application when dashboard closes - let forms handle their own navigation
            
            // Set and show
            _currentForm = dashboardForm;
            _currentForm.Show();
        }
    }

    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialisation de la configuration de l'application
            ApplicationConfiguration.Initialize();

            // Création d'une collection de services pour l'injection de dépendances
            var services = new ServiceCollection();
            services.AddGestionDeStockDataService();
            services.ApplyMigrationsForGestionDeStockDataService();

            // Enregistrer les Forms
            services.RegisterForms();

            // Enregistrer les repositories
            RegisterRepositories(services);

            // Construction du fournisseur de services qui gère les instances des dépendances
            ServiceProvider = services.BuildServiceProvider();

            // Use our custom application context to manage form transitions
            Application.Run(new StockAppContext(ServiceProvider));
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<GestionDeStock.Data.Repositories.IProductRepository, GestionDeStock.Data.Repositories.ProductRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.ICategoryRepository, GestionDeStock.Data.Repositories.CategoryRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.IStockMovementRepository, GestionDeStock.Data.Repositories.StockMovementRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.IUserRepository, GestionDeStock.Data.Repositories.UserRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.IStockInRepository, GestionDeStock.Data.Repositories.StockInRepository>();
        }
    }
}