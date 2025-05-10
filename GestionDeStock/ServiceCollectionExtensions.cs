using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterForms(this IServiceCollection services)
        {
            // Register main form
            services.AddTransient<MainForm>();
            
            // Register login form
            services.AddTransient<LoginForm.LoginForm>();
            
            // Register product forms
            services.AddTransient<ProductForm.ProductsListForm>();
            services.AddTransient<ProductForm.ProductDetailsForm>();
            
            // Register category forms
            services.AddTransient<CategoryForm.CategoriesListForm>();
            services.AddTransient<CategoryForm.CategoryDetailsForm>();
            
            // Register stock movement forms
            services.AddTransient<StockInForm.StockInListForm>();
            services.AddTransient<StockInForm.StockInDetailsForm>();
            services.AddTransient<StockOutForm.StockOutListForm>();
            services.AddTransient<StockOutForm.StockOutDetailsForm>();
            
            // Register alert form
            services.AddTransient<AlertForm.AlertsForm>();
            
            // Register statistics form
            services.AddTransient<StatForm.StatisticsForm>();
            
            // Register import/export form
            services.AddTransient<ImportExportForm.ImportExportForm>();
        }
    }
}
