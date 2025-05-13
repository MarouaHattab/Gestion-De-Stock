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
    public class StockOutRepository : IStockOutRepository
    {
        private readonly StockDbContext _context;

        public StockOutRepository(StockDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StockOut> GetAll()
        {
            return _context.StockOuts
                .Include(s => s.Product)
                .ToList();
        }

        public async Task<List<StockOut>> GetAllAsync()
        {
            return await _context.StockOuts
                .Include(s => s.Product)
                .ToListAsync();
        }

        public StockOut GetById(int id)
        {
            return _context.StockOuts
                .Include(s => s.Product)
                .FirstOrDefault(s => s.StockOutId == id);
        }

        public async Task<StockOut> GetByIdAsync(int id)
        {
            return await _context.StockOuts
                .Include(s => s.Product)
                .FirstOrDefaultAsync(s => s.StockOutId == id);
        }

        public IEnumerable<StockOut> GetByProductId(int productId)
        {
            return _context.StockOuts
                .Include(s => s.Product)
                .Where(s => s.ProductId == productId)
                .ToList();
        }

        public async Task<List<StockOut>> GetByProductIdAsync(int productId)
        {
            return await _context.StockOuts
                .Include(s => s.Product)
                .Where(s => s.ProductId == productId)
                .ToListAsync();
        }

        public void Add(StockOut stockOut)
        {
            if (stockOut == null)
                throw new ArgumentNullException(nameof(stockOut));

            // Ensure Notes is not null to prevent database errors
            stockOut.Notes = stockOut.Notes ?? string.Empty;

            _context.StockOuts.Add(stockOut);

            // Update product quantity
            var product = _context.Products.Find(stockOut.ProductId);
            if (product == null)
                throw new Exception($"Product with ID {stockOut.ProductId} not found");

            if (product.Quantity < stockOut.Quantity)
                throw new Exception($"Not enough {product.Name} in stock. Available: {product.Quantity}");

            product.Quantity -= stockOut.Quantity;
            _context.SaveChanges();
        }

        public async Task<StockOut> AddAsync(StockOut stockOut)
        {
            if (stockOut == null)
                throw new ArgumentNullException(nameof(stockOut));

            // Ensure Notes is not null to prevent database errors
            stockOut.Notes = stockOut.Notes ?? string.Empty;

            _context.StockOuts.Add(stockOut);

            // Update product quantity
            var product = await _context.Products.FindAsync(stockOut.ProductId);
            if (product == null)
                throw new Exception($"Product with ID {stockOut.ProductId} not found");

            if (product.Quantity < stockOut.Quantity)
                throw new Exception($"Not enough {product.Name} in stock. Available: {product.Quantity}");

            product.Quantity -= stockOut.Quantity;
            await _context.SaveChangesAsync();
            return stockOut;
        }

        public void Update(StockOut stockOut)
        {
            if (stockOut == null)
                throw new ArgumentNullException(nameof(stockOut));

            var existingStockOut = _context.StockOuts.Find(stockOut.StockOutId);
            if (existingStockOut == null)
                throw new Exception($"StockOut with ID {stockOut.StockOutId} not found");

            // Calculate quantity difference for product update
            int quantityDifference = stockOut.Quantity - existingStockOut.Quantity;

            // Ensure Notes is not null to prevent database errors
            stockOut.Notes = stockOut.Notes ?? string.Empty;

            // Update the existing entity
            _context.Entry(existingStockOut).CurrentValues.SetValues(stockOut);

            // Update product quantity if needed
            if (quantityDifference != 0)
            {
                var product = _context.Products.Find(stockOut.ProductId);
                if (product == null)
                    throw new Exception($"Product with ID {stockOut.ProductId} not found");

                if (quantityDifference > 0 && product.Quantity < quantityDifference)
                    throw new Exception($"Not enough {product.Name} in stock. Available: {product.Quantity}");

                product.Quantity -= quantityDifference;
            }

            _context.SaveChanges();
        }

        public async Task<StockOut> UpdateAsync(StockOut stockOut)
        {
            if (stockOut == null)
                throw new ArgumentNullException(nameof(stockOut));

            var existingStockOut = await _context.StockOuts.FindAsync(stockOut.StockOutId);
            if (existingStockOut == null)
                throw new Exception($"StockOut with ID {stockOut.StockOutId} not found");

            // Calculate quantity difference for product update
            int quantityDifference = stockOut.Quantity - existingStockOut.Quantity;

            // Ensure Notes is not null to prevent database errors
            stockOut.Notes = stockOut.Notes ?? string.Empty;

            // Update the existing entity
            _context.Entry(existingStockOut).CurrentValues.SetValues(stockOut);

            // Update product quantity if needed
            if (quantityDifference != 0)
            {
                var product = await _context.Products.FindAsync(stockOut.ProductId);
                if (product == null)
                    throw new Exception($"Product with ID {stockOut.ProductId} not found");

                if (quantityDifference > 0 && product.Quantity < quantityDifference)
                    throw new Exception($"Not enough {product.Name} in stock. Available: {product.Quantity}");

                product.Quantity -= quantityDifference;
            }

            await _context.SaveChangesAsync();
            return stockOut;
        }

        public void Delete(int id)
        {
            var stockOut = _context.StockOuts.Find(id);
            if (stockOut == null)
                return;

            // Update product quantity
            var product = _context.Products.Find(stockOut.ProductId);
            if (product != null)
            {
                product.Quantity += stockOut.Quantity;
            }

            _context.StockOuts.Remove(stockOut);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var stockOut = await _context.StockOuts.FindAsync(id);
            if (stockOut == null)
                return;

            // Update product quantity
            var product = await _context.Products.FindAsync(stockOut.ProductId);
            if (product != null)
            {
                product.Quantity += stockOut.Quantity;
            }

            _context.StockOuts.Remove(stockOut);
            await _context.SaveChangesAsync();
        }
    }
} 