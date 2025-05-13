using GestionDeStock.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Repositories
{
    public interface IStockInRepository
    {
        Task<List<StockIn>> GetAllAsync();
        Task<StockIn> GetByIdAsync(int id);
        Task<List<StockIn>> GetByProductIdAsync(int productId);
        Task<List<StockIn>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<StockIn> AddAsync(StockIn stockIn);
        Task<StockIn> UpdateAsync(StockIn stockIn);
        Task DeleteAsync(int id);
    }
} 