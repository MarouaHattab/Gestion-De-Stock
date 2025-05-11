using GestionDeStock.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Context
{
    public class StockDbContext : DbContext
    {
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
    }
} 