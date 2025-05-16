using GestionDeStock.Data.Context;
using GestionDeStock.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StockDbContext _context;

        public ProductRepository(StockDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Where(p => p.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task<List<Product>> GetLowStockProductsAsync(int? threshold = null)
        {
            return await _context.Products
                .Include(p => p.Category)
                .Where(p => p.Quantity <= (threshold ?? p.AlertThreshold))
                .ToListAsync();
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task DeleteProductAsync(int id)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // First get the product with its related entities
                    var product = await _context.Products
                        .Include(p => p.StockIns)
                        .Include(p => p.StockOuts)
                        .FirstOrDefaultAsync(p => p.ProductId == id);
                        
                    if (product != null)
                    {
                        // First remove all related StockIn records
                        var stockIns = await _context.StockIns
                            .Where(si => si.ProductId == id)
                            .ToListAsync();
                            
                        if (stockIns.Any())
                        {
                            _context.StockIns.RemoveRange(stockIns);
                            await _context.SaveChangesAsync();
                        }
                        
                        // Then remove all related StockOut records
                        var stockOuts = await _context.StockOuts
                            .Where(so => so.ProductId == id)
                            .ToListAsync();
                            
                        if (stockOuts.Any())
                        {
                            _context.StockOuts.RemoveRange(stockOuts);
                            await _context.SaveChangesAsync();
                        }
                        
                        // Finally remove the product
                        _context.Products.Remove(product);
                        await _context.SaveChangesAsync();
                        
                        // Commit the transaction if everything succeeded
                        await transaction.CommitAsync();
                    }
                }
                catch (Exception ex)
                {
                    // Something went wrong, rollback the transaction
                    await transaction.RollbackAsync();
                    
                    // Re-throw the exception with more details
                    throw new Exception($"Error deleting product: {ex.Message}", ex);
                }
            }
        }
    }
} 