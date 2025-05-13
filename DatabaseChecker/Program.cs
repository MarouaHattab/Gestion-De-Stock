using GestionDeStock.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestionDeStock.DatabaseChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking database content...");
            
            try
            {
                using (var context = new StockDbContext())
                {
                    // Count categories
                    var categoriesCount = context.Categories.Count();
                    Console.WriteLine($"Number of categories in database: {categoriesCount}");
                    
                    // List categories
                    var categories = context.Categories.ToList();
                    Console.WriteLine("\nCategories:");
                    foreach (var category in categories)
                    {
                        Console.WriteLine($"- ID: {category.CategoryId}, Name: {category.Name}, Description: {category.Description}");
                    }
                    
                    // Count products
                    var productsCount = context.Products.Count();
                    Console.WriteLine($"\nNumber of products in database: {productsCount}");
                    
                    // List some products (first 5)
                    var products = context.Products.Take(5).ToList();
                    Console.WriteLine("\nSample Products (first 5):");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"- ID: {product.ProductId}, Name: {product.Name}, Category ID: {product.CategoryId}, Quantity: {product.Quantity}");
                    }
                    
                    Console.WriteLine("\nDatabase check completed successfully.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking database: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
