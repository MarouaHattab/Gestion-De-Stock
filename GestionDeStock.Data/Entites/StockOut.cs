using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Entites
{
    public class StockOut
    {
        public int StockOutId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExitDate { get; set; }
        public string? Destination { get; set; }

        // Navigation
        public virtual Product Product { get; set; }
    }

}
