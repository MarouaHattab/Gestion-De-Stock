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
    public class StockMovementRepository : IStockMovementRepository
    {
        private readonly StockDbContext _context;

        public StockMovementRepository(StockDbContext context)
        {
            _context = context;
        }

        #region StockIn Operations
        public async Task<List<StockIn>> GetAllStockInsAsync()
        {
            return await _context.StockIns
                .Include(si => si.Product)
                .ThenInclude(p => p.Category)
                .ToListAsync();
        }

        public async Task<StockIn> GetStockInByIdAsync(int id)
        {
            return await _context.StockIns
                .Include(si => si.Product)
                .ThenInclude(p => p.Category)
                .FirstOrDefaultAsync(si => si.StockInId == id);
        }

        public async Task<List<StockIn>> GetStockInsByProductIdAsync(int productId)
        {
            return await _context.StockIns
                .Include(si => si.Product)
                .ThenInclude(p => p.Category)
                .Where(si => si.ProductId == productId)
                .ToListAsync();
        }

        public async Task<List<StockIn>> GetStockInsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.StockIns
                .Include(si => si.Product)
                .ThenInclude(p => p.Category)
                .Where(si => si.EntryDate >= startDate && si.EntryDate <= endDate)
                .ToListAsync();
        }

        public async Task<StockIn> AddStockInAsync(StockIn stockIn)
        {
            // First update the product quantity
            var product = await _context.Products.FindAsync(stockIn.ProductId);
            if (product != null)
            {
                product.Quantity += stockIn.Quantity;
                _context.Entry(product).State = EntityState.Modified;
            }

            // Then add the stock in record
            _context.StockIns.Add(stockIn);
            await _context.SaveChangesAsync();
            return stockIn;
        }

        public async Task<StockIn> UpdateStockInAsync(StockIn stockIn)
        {
            // Get the original stock in record
            var originalStockIn = await _context.StockIns.AsNoTracking().FirstOrDefaultAsync(si => si.StockInId == stockIn.StockInId);
            if (originalStockIn != null)
            {
                // Update the product quantity
                var product = await _context.Products.FindAsync(stockIn.ProductId);
                if (product != null)
                {
                    // Remove the original quantity and add the new quantity
                    product.Quantity = product.Quantity - originalStockIn.Quantity + stockIn.Quantity;
                    _context.Entry(product).State = EntityState.Modified;
                }
            }

            // Update the stock in record
            _context.Entry(stockIn).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return stockIn;
        }

        public async Task DeleteStockInAsync(int id)
        {
            var stockIn = await _context.StockIns.FindAsync(id);
            if (stockIn != null)
            {
                // Update the product quantity
                var product = await _context.Products.FindAsync(stockIn.ProductId);
                if (product != null)
                {
                    product.Quantity -= stockIn.Quantity;
                    _context.Entry(product).State = EntityState.Modified;
                }

                // Remove the stock in record
                _context.StockIns.Remove(stockIn);
                await _context.SaveChangesAsync();
            }
        }
        #endregion

        #region StockOut Operations
        public async Task<List<StockOut>> GetAllStockOutsAsync()
        {
            return await _context.StockOuts
                .Include(so => so.Product)
                .ThenInclude(p => p.Category)
                .ToListAsync();
        }

        public async Task<StockOut> GetStockOutByIdAsync(int id)
        {
            return await _context.StockOuts
                .Include(so => so.Product)
                .ThenInclude(p => p.Category)
                .FirstOrDefaultAsync(so => so.StockOutId == id);
        }

        public async Task<List<StockOut>> GetStockOutsByProductIdAsync(int productId)
        {
            return await _context.StockOuts
                .Include(so => so.Product)
                .ThenInclude(p => p.Category)
                .Where(so => so.ProductId == productId)
                .ToListAsync();
        }

        public async Task<List<StockOut>> GetStockOutsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.StockOuts
                .Include(so => so.Product)
                .ThenInclude(p => p.Category)
                .Where(so => so.ExitDate >= startDate && so.ExitDate <= endDate)
                .ToListAsync();
        }

        public async Task<StockOut> AddStockOutAsync(StockOut stockOut)
        {
            // First check and update the product quantity
            var product = await _context.Products.FindAsync(stockOut.ProductId);
            if (product != null)
            {
                if (product.Quantity < stockOut.Quantity)
                {
                    throw new InvalidOperationException($"Not enough stock for product {product.Name}. Available: {product.Quantity}, Requested: {stockOut.Quantity}");
                }

                product.Quantity -= stockOut.Quantity;
                _context.Entry(product).State = EntityState.Modified;
            }

            // Then add the stock out record
            _context.StockOuts.Add(stockOut);
            await _context.SaveChangesAsync();
            return stockOut;
        }

        public async Task<StockOut> UpdateStockOutAsync(StockOut stockOut)
        {
            // Get the original stock out record
            var originalStockOut = await _context.StockOuts.AsNoTracking().FirstOrDefaultAsync(so => so.StockOutId == stockOut.StockOutId);
            if (originalStockOut != null)
            {
                // Update the product quantity
                var product = await _context.Products.FindAsync(stockOut.ProductId);
                if (product != null)
                {
                    // Add back the original quantity and subtract the new quantity
                    int newQuantity = product.Quantity + originalStockOut.Quantity - stockOut.Quantity;
                    if (newQuantity < 0)
                    {
                        throw new InvalidOperationException($"Not enough stock for product {product.Name}. Available: {product.Quantity + originalStockOut.Quantity}, Requested: {stockOut.Quantity}");
                    }

                    product.Quantity = newQuantity;
                    _context.Entry(product).State = EntityState.Modified;
                }
            }

            // Update the stock out record
            _context.Entry(stockOut).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return stockOut;
        }

        public async Task DeleteStockOutAsync(int id)
        {
            var stockOut = await _context.StockOuts.FindAsync(id);
            if (stockOut != null)
            {
                // Update the product quantity
                var product = await _context.Products.FindAsync(stockOut.ProductId);
                if (product != null)
                {
                    product.Quantity += stockOut.Quantity;
                    _context.Entry(product).State = EntityState.Modified;
                }

                // Remove the stock out record
                _context.StockOuts.Remove(stockOut);
                await _context.SaveChangesAsync();
            }
        }
        #endregion
    }
} 