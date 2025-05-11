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

            // Comment out forms that don't exist yet
            // Uncomment these as you create the forms

            // Register login form
            // services.AddTransient<LoginForm.LoginForm>();

            // Register product forms
            services.AddTransient<ProductForm.ProductListForm>();
            services.AddTransient<ProductForm.ProductDetailsForm>();

            // Register category forms
            services.AddTransient<CategoryForm.Category_Form>();
            services.AddTransient<CategoryForm.CategoryDetailsForm>();

            // Register stock movement forms
            services.AddTransient<StockInForm.StockInForm>();
            services.AddTransient<StockInForm.StockInForm>();
            services.AddTransient<StockOutForm.StockOutForm>();
            services.AddTransient<StockOutForm.StockOutForm>();

            // Register alert form
            services.AddTransient<AlertForm.AlertForm>();

            // Register statistics form
            services.AddTransient<StatForm.StatForm>();

            // Register import/export form
            // services.AddTransient<ImportExportForm.ImportExportForm>();
        }
    }
}
