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
                
                // Ensure database is created
                dbContext.Database.EnsureCreated();
                
                // Apply pending migrations if any
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
                
                // Seed the database
                dbContext.Seed();
            }
        }
    }
}
