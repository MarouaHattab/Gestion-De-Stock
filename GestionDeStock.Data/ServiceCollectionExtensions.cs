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
                    // Check if database exists
                    bool dbExists = dbContext.Database.CanConnect();
                    System.Diagnostics.Debug.WriteLine($"Database exists: {dbExists}");
                    
                    if (!dbExists)
                    {
                        System.Diagnostics.Debug.WriteLine("Creating new database...");
                        // Create database if it doesn't exist
                        dbContext.Database.EnsureCreated();
                        
                        // Seed the database with initial data
                        System.Diagnostics.Debug.WriteLine("Seeding database with initial data...");
                        dbContext.Seed();
                        System.Diagnostics.Debug.WriteLine("Database seeded successfully");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Database already exists, checking schema...");
                        try
                        {
                            // Try to get users to check if the schema is valid
                            var userCount = dbContext.Users.Count();
                            System.Diagnostics.Debug.WriteLine($"Existing database has {userCount} users");
                            
                            // Ensure admin user exists
                            dbContext.Seed();
                        }
                        catch (Exception ex)
                        {
                            // If there's an error accessing the tables, the schema might be outdated
                            System.Diagnostics.Debug.WriteLine($"Error accessing database: {ex.Message}");
                            System.Diagnostics.Debug.WriteLine("Attempting to update database schema...");
                            
                            try
                            {
                                // Apply migrations instead of recreating
                                dbContext.Database.Migrate();
                                System.Diagnostics.Debug.WriteLine("Database schema updated successfully");
                                
                                // Ensure admin user exists after migration
                                dbContext.Seed();
                            }
                            catch (Exception migrationEx)
                            {
                                System.Diagnostics.Debug.WriteLine($"Migration failed: {migrationEx.Message}");
                                System.Diagnostics.Debug.WriteLine("Attempting to recreate database...");
                                
                                // As a last resort, recreate the database
                                dbContext.Database.EnsureDeleted();
                                dbContext.Database.EnsureCreated();
                                dbContext.Seed();
                                System.Diagnostics.Debug.WriteLine("Database recreated successfully");
                            }
                        }
                    }
                    
                    // Log database path
                    var connection = dbContext.Database.GetDbConnection();
                    System.Diagnostics.Debug.WriteLine($"Database connection string: {connection.ConnectionString}");
                    
                    // Log user count after initialization
                    var userCount = dbContext.Users.Count();
                    System.Diagnostics.Debug.WriteLine($"User count after initialization: {userCount}");
                    foreach (var user in dbContext.Users)
                    {
                        System.Diagnostics.Debug.WriteLine($"User in DB: {user.Username}, IsAdmin: {user.IsAdmin}");
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    System.Diagnostics.Debug.WriteLine($"Database initialization error: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                }
            }
        }
    }
}
