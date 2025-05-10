using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Entites
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int AlertThreshold { get; set; }
        public string? Description { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation properties
        public virtual Category Category { get; set; }
        public virtual ICollection<StockIn> StockIns { get; set; } = new List<StockIn>();
        public virtual ICollection<StockOut> StockOuts { get; set; } = new List<StockOut>();
    }

}
