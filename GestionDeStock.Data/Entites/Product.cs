using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        // Helper properties for stock status
        [Browsable(false)]
        public bool IsOutOfStock => Quantity == 0;
        
        [Browsable(false)]
        public bool IsLowStock => Quantity > 0 && Quantity <= AlertThreshold;
        
        [Browsable(false)]
        public bool IsCriticalLowStock => Quantity > 0 && Quantity <= AlertThreshold * 0.25;
        
        [Browsable(false)]
        public bool IsWarningLowStock => Quantity > 0 && Quantity <= AlertThreshold * 0.5 && !IsCriticalLowStock;
        
        [Browsable(false)]
        public string StockStatus
        {
            get
            {
                if (IsOutOfStock) return "Rupture de stock";
                if (IsCriticalLowStock) return "Niveau critique";
                if (IsWarningLowStock) return "Niveau bas";
                if (IsLowStock) return "Stock limité";
                return "En stock";
            }
        }
    }
}
