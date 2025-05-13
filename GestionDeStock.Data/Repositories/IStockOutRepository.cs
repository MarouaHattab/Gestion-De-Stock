using GestionDeStock.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Repositories
{
    public interface IStockOutRepository
    {
        Task<List<StockOut>> GetAllAsync();
        Task<StockOut> GetByIdAsync(int id);
        Task<List<StockOut>> GetByProductIdAsync(int productId);
        Task<StockOut> AddAsync(StockOut stockOut);
        Task<StockOut> UpdateAsync(StockOut stockOut);
        Task DeleteAsync(int id);
    }
} 