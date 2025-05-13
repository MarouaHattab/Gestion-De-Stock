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
    public class StockInRepository : IStockInRepository
    {
        private readonly StockDbContext _context;

        public StockInRepository(StockDbContext context)
        {
            _context = context;
        }

        public async Task<List<StockIn>> GetAllAsync()
        {
            try
            {
                // Simplify query to avoid projection issues
                var stockIns = await _context.StockIns
                    .Include(s => s.Product)
                    .ToListAsync();
                
                return stockIns;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching stock in records: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        public async Task<StockIn> GetByIdAsync(int id)
        {
            try
            {
                // Simplify query to avoid projection issues
                return await _context.StockIns
                    .Include(s => s.Product)
                    .FirstOrDefaultAsync(s => s.StockInId == id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching stock in record by ID: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        public async Task<List<StockIn>> GetByProductIdAsync(int productId)
        {
            try
            {
                // Simplify query to avoid projection issues
                return await _context.StockIns
                    .Include(s => s.Product)
                    .Where(s => s.ProductId == productId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching stock in records by product ID: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        public async Task<List<StockIn>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Simplify query to avoid projection issues
                return await _context.StockIns
                    .Include(s => s.Product)
                    .Where(s => s.EntryDate >= startDate && s.EntryDate <= endDate)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching stock in records by date range: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        public async Task<StockIn> AddAsync(StockIn stockIn)
        {
            try
            {
                // Ensure Notes is not null to prevent database errors
                stockIn.Notes = stockIn.Notes ?? string.Empty;
                
                _context.StockIns.Add(stockIn);
                await _context.SaveChangesAsync();
                return stockIn;
            }
            catch (Exception ex)
            {
                // Log or handle the specific exception
                Console.WriteLine($"Database error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw new Exception($"Failed to add stock-in record: {ex.Message}", ex);
            }
        }

        public async Task<StockIn> UpdateAsync(StockIn stockIn)
        {
            try
            {
                // Ensure Notes is not null to prevent database errors
                stockIn.Notes = stockIn.Notes ?? string.Empty;
                
                _context.Entry(stockIn).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return stockIn;
            }
            catch (Exception ex)
            {
                // Log or handle the specific exception
                Console.WriteLine($"Database error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw new Exception($"Failed to update stock-in record: {ex.Message}", ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var stockIn = await _context.StockIns.FindAsync(id);
            if (stockIn != null)
            {
                _context.StockIns.Remove(stockIn);
                await _context.SaveChangesAsync();
            }
        }
    }
} 