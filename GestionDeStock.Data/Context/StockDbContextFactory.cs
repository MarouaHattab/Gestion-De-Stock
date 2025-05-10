using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Context
{
    public class StockDbContextFactory : IDesignTimeDbContextFactory<StockDbContext>
    {
        public StockDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StockDbContext>();
            optionsBuilder.UseSqlite("Data Source=gestiondestock.db");

            return new StockDbContext(optionsBuilder.Options);
        }
    }
} 