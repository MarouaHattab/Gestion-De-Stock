using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Entites
{
    public class StockIn
    {
        public int StockInId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public string? Supplier { get; set; }

        // Navigation
        public virtual Product Product { get; set; }
    }

}
