using GestionDeStock.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestionDeStock.Data.Context
{
    public class StockDbContext : DbContext
    {
        public StockDbContext()
        {
        }

        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StockIn> StockIns { get; set; }
        public DbSet<StockOut> StockOuts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=gestiondestock.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockIn>()
                .HasOne(si => si.Product)
                .WithMany(p => p.StockIns)
                .HasForeignKey(si => si.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockOut>()
                .HasOne(so => so.Product)
                .WithMany(p => p.StockOuts)
                .HasForeignKey(so => so.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure required fields and max lengths
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.IsAdmin)
                .HasDefaultValue(false);
        }

        public void Seed()
        {
            // Add categories if they don't exist
            if (!Categories.Any())
            {
                Categories.AddRange(
                    new Category
                    {
                        Name = "Électronique",
                        Description = "Produits électroniques et accessoires"
                    },
                    new Category
                    {
                        Name = "Informatique",
                        Description = "Matériel informatique et périphériques"
                    },
                    new Category
                    {
                        Name = "Bureautique",
                        Description = "Fournitures et équipements de bureau"
                    },
                    new Category
                    {
                        Name = "Mobilier",
                        Description = "Meubles et aménagements"
                    },
                    new Category
                    {
                        Name = "Consommables",
                        Description = "Produits consommables divers"
                    },
                    // Additional categories
                    new Category
                    {
                        Name = "Alimentation",
                        Description = "Produits alimentaires et boissons"
                    },
                    new Category
                    {
                        Name = "Vêtements",
                        Description = "Vêtements et accessoires de mode"
                    },
                    new Category
                    {
                        Name = "Santé",
                        Description = "Produits de santé et pharmaceutiques"
                    },
                    new Category
                    {
                        Name = "Livres",
                        Description = "Livres, magazines et publications"
                    },
                    new Category
                    {
                        Name = "Jouets",
                        Description = "Jouets et jeux pour enfants"
                    },
                    new Category
                    {
                        Name = "Sport",
                        Description = "Équipements et accessoires de sport"
                    }
                );
                SaveChanges();
            }

            // Add default products if none exist
            if (!Products.Any())
            {
                // Get category IDs for reference
                var electroniqueId = Categories.FirstOrDefault(c => c.Name == "Électronique")?.CategoryId ?? 1;
                var informatiqueId = Categories.FirstOrDefault(c => c.Name == "Informatique")?.CategoryId ?? 2;
                var bureautiqueId = Categories.FirstOrDefault(c => c.Name == "Bureautique")?.CategoryId ?? 3;
                var mobilieId = Categories.FirstOrDefault(c => c.Name == "Mobilier")?.CategoryId ?? 4;
                var consommablesId = Categories.FirstOrDefault(c => c.Name == "Consommables")?.CategoryId ?? 5;
                var alimentationId = Categories.FirstOrDefault(c => c.Name == "Alimentation")?.CategoryId ?? 6;
                var vetementsId = Categories.FirstOrDefault(c => c.Name == "Vêtements")?.CategoryId ?? 7;
                var santeId = Categories.FirstOrDefault(c => c.Name == "Santé")?.CategoryId ?? 8;
                var livresId = Categories.FirstOrDefault(c => c.Name == "Livres")?.CategoryId ?? 9;
                var jouetsId = Categories.FirstOrDefault(c => c.Name == "Jouets")?.CategoryId ?? 10;
                var sportId = Categories.FirstOrDefault(c => c.Name == "Sport")?.CategoryId ?? 11;

                Products.AddRange(
                    // Électronique products
                    new Product
                    {
                        Name = "Téléviseur 4K 55 pouces",
                        Quantity = 15,
                        PurchasePrice = 450.00m,
                        SalePrice = 699.99m,
                        AlertThreshold = 5,
                        Description = "Téléviseur LED 4K Ultra HD 55 pouces avec Smart TV",
                        CategoryId = electroniqueId
                    },
                    new Product
                    {
                        Name = "Smartphone Android",
                        Quantity = 30,
                        PurchasePrice = 250.00m,
                        SalePrice = 399.99m,
                        AlertThreshold = 10,
                        Description = "Smartphone Android avec écran 6.5 pouces, 128Go stockage",
                        CategoryId = electroniqueId
                    },
                    new Product
                    {
                        Name = "Écouteurs sans fil",
                        Quantity = 50,
                        PurchasePrice = 35.00m,
                        SalePrice = 79.99m,
                        AlertThreshold = 15,
                        Description = "Écouteurs Bluetooth avec étui de charge",
                        CategoryId = electroniqueId
                    },
                    
                    // Informatique products
                    new Product
                    {
                        Name = "Ordinateur portable",
                        Quantity = 20,
                        PurchasePrice = 650.00m,
                        SalePrice = 999.99m,
                        AlertThreshold = 8,
                        Description = "Ordinateur portable 15.6 pouces, i5, 8Go RAM, 512Go SSD",
                        CategoryId = informatiqueId
                    },
                    new Product
                    {
                        Name = "Souris sans fil",
                        Quantity = 45,
                        PurchasePrice = 12.00m,
                        SalePrice = 24.99m,
                        AlertThreshold = 15,
                        Description = "Souris ergonomique sans fil avec récepteur USB",
                        CategoryId = informatiqueId
                    },
                    new Product
                    {
                        Name = "Clavier mécanique",
                        Quantity = 25,
                        PurchasePrice = 45.00m,
                        SalePrice = 89.99m,
                        AlertThreshold = 10,
                        Description = "Clavier mécanique rétroéclairé pour gaming",
                        CategoryId = informatiqueId
                    },
                    
                    // Bureautique products
                    new Product
                    {
                        Name = "Stylos à bille (lot de 10)",
                        Quantity = 100,
                        PurchasePrice = 4.50m,
                        SalePrice = 9.99m,
                        AlertThreshold = 30,
                        Description = "Lot de 10 stylos à bille de couleurs variées",
                        CategoryId = bureautiqueId
                    },
                    new Product
                    {
                        Name = "Cahier A4 ligné",
                        Quantity = 80,
                        PurchasePrice = 1.20m,
                        SalePrice = 2.99m,
                        AlertThreshold = 25,
                        Description = "Cahier format A4, 200 pages lignées",
                        CategoryId = bureautiqueId
                    },
                    
                    // Mobilier products
                    new Product
                    {
                        Name = "Chaise de bureau",
                        Quantity = 15,
                        PurchasePrice = 85.00m,
                        SalePrice = 149.99m,
                        AlertThreshold = 5,
                        Description = "Chaise de bureau ergonomique avec accoudoirs réglables",
                        CategoryId = mobilieId
                    },
                    new Product
                    {
                        Name = "Bureau d'angle",
                        Quantity = 8,
                        PurchasePrice = 120.00m,
                        SalePrice = 199.99m,
                        AlertThreshold = 3,
                        Description = "Bureau d'angle avec rangements intégrés",
                        CategoryId = mobilieId
                    },
                    
                    // Consommables products
                    new Product
                    {
                        Name = "Cartouche d'encre noire",
                        Quantity = 40,
                        PurchasePrice = 18.00m,
                        SalePrice = 34.99m,
                        AlertThreshold = 15,
                        Description = "Cartouche d'encre compatible avec imprimantes HP",
                        CategoryId = consommablesId
                    },
                    
                    // Alimentation products
                    new Product
                    {
                        Name = "Café en grains 1kg",
                        Quantity = 35,
                        PurchasePrice = 8.50m,
                        SalePrice = 15.99m,
                        AlertThreshold = 10,
                        Description = "Café en grains de qualité supérieure, torréfaction moyenne",
                        CategoryId = alimentationId
                    },
                    
                    // Vêtements products
                    new Product
                    {
                        Name = "T-shirt coton unisexe",
                        Quantity = 60,
                        PurchasePrice = 7.00m,
                        SalePrice = 19.99m,
                        AlertThreshold = 20,
                        Description = "T-shirt 100% coton bio, tailles variées",
                        CategoryId = vetementsId
                    },
                    
                    // Santé products
                    new Product
                    {
                        Name = "Gel hydroalcoolique 500ml",
                        Quantity = 70,
                        PurchasePrice = 3.20m,
                        SalePrice = 6.99m,
                        AlertThreshold = 25,
                        Description = "Gel hydroalcoolique désinfectant pour les mains",
                        CategoryId = santeId
                    },
                    
                    // Livres products
                    new Product
                    {
                        Name = "Livre de développement personnel",
                        Quantity = 25,
                        PurchasePrice = 9.50m,
                        SalePrice = 18.99m,
                        AlertThreshold = 10,
                        Description = "Guide pratique pour améliorer sa productivité",
                        CategoryId = livresId
                    },
                    
                    // Jouets products
                    new Product
                    {
                        Name = "Jeu de construction 300 pièces",
                        Quantity = 20,
                        PurchasePrice = 25.00m,
                        SalePrice = 49.99m,
                        AlertThreshold = 7,
                        Description = "Jeu de construction créatif pour enfants dès 6 ans",
                        CategoryId = jouetsId
                    },
                    
                    // Sport products
                    new Product
                    {
                        Name = "Ballon de football",
                        Quantity = 30,
                        PurchasePrice = 12.00m,
                        SalePrice = 24.99m,
                        AlertThreshold = 10,
                        Description = "Ballon de football taille 5 résistant et durable",
                        CategoryId = sportId
                    }
                );
                SaveChanges();
            }

            // Check for admin user and recreate if needed
            var adminUser = Users.FirstOrDefault(u => u.Username == "admin");
            if (adminUser == null)
            {
                Users.Add(new User
                {
                    Username = "admin",
                    Password = "admin",
                    IsAdmin = true
                });
                SaveChanges();
            }
            else if (!adminUser.IsAdmin)
            {
                // Ensure admin user has admin privileges
                adminUser.IsAdmin = true;
                SaveChanges();
            }
        }

        // Method to recreate the database if needed
        public static void RecreateDatabase()
        {
            try
            {
                // Get the path to the database file
                string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gestiondestock.db");
                
                // Create a temporary context to ensure we can connect
                using (var tempContext = new StockDbContext())
                {
                    // Try to delete the database
                    tempContext.Database.EnsureDeleted();
                    
                    // Create a new database
                    tempContext.Database.EnsureCreated();
                    
                    // Seed the database with initial data
                    tempContext.Seed();

                    Console.WriteLine("Database has been recreated successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error recreating database: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }
    }
} 