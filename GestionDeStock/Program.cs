using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestionDeStock.Data;

namespace GestionDeStock
{
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

            // Récupération de l'instance de la fenêtre de login via l'injection de dépendances
            var loginForm = ServiceProvider.GetRequiredService<LoginForm.LoginForm>();

            // Démarrage de l'application avec la fenêtre de login
            Application.Run(loginForm);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<GestionDeStock.Data.Repositories.IProductRepository, GestionDeStock.Data.Repositories.ProductRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.ICategoryRepository, GestionDeStock.Data.Repositories.CategoryRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.IStockMovementRepository, GestionDeStock.Data.Repositories.StockMovementRepository>();
            services.AddScoped<GestionDeStock.Data.Repositories.IUserRepository, GestionDeStock.Data.Repositories.UserRepository>();
            
        }
    }
}