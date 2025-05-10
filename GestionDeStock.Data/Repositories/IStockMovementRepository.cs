using GestionDeStock.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Repositories
{
    public interface IStockMovementRepository
    {
        // StockIn operations
        Task<List<StockIn>> GetAllStockInsAsync();
        Task<StockIn> GetStockInByIdAsync(int id);
        Task<List<StockIn>> GetStockInsByProductIdAsync(int productId);
        Task<List<StockIn>> GetStockInsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<StockIn> AddStockInAsync(StockIn stockIn);
        Task<StockIn> UpdateStockInAsync(StockIn stockIn);
        Task DeleteStockInAsync(int id);

        // StockOut operations
        Task<List<StockOut>> GetAllStockOutsAsync();
        Task<StockOut> GetStockOutByIdAsync(int id);
        Task<List<StockOut>> GetStockOutsByProductIdAsync(int productId);
        Task<List<StockOut>> GetStockOutsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<StockOut> AddStockOutAsync(StockOut stockOut);
        Task<StockOut> UpdateStockOutAsync(StockOut stockOut);
        Task DeleteStockOutAsync(int id);
    }
} 