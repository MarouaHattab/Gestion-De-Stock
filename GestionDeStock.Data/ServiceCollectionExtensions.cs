using GestionDeStock.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGestionDeStockDataService(this IServiceCollection services)
        {
            services.AddDbContext<StockDbContext>(options =>
            {
                options.UseSqlite("Data Source=gestiondestock.db");
            }, ServiceLifetime.Transient);
            
            return services;
        }

        public static void ApplyMigrationsForGestionDeStockDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<StockDbContext>();
                
                try
                {
                    // Check if database exists before trying to create it
                    if (!dbContext.Database.CanConnect())
                    {
                        // Only create the database if it doesn't exist
                        dbContext.Database.EnsureCreated();
                        
                        // Seed the database with initial data
                        dbContext.Seed();
                    }
                    else
                    {
                        // For existing database, only apply pending migrations if any
                        var pendingMigrations = dbContext.Database.GetPendingMigrations();
                        if (pendingMigrations.Any())
                        {
                            dbContext.Database.Migrate();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    System.Diagnostics.Debug.WriteLine($"Database initialization error: {ex.Message}");
                }
            }
        }
    }
}
