using GestionDeStock.Data.Context;
using System;

namespace GestionDeStock
{
    public class DatabaseRecreator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting database recreation process...");
            
            try
            {
                // Recreate the database with the updated seed data
                StockDbContext.RecreateDatabase();
                
                Console.WriteLine("Database has been successfully recreated with default products and categories.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error recreating database: {ex.Message}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
} 