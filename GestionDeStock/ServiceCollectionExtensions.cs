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
            // Register login form
            services.AddTransient<LoginForm.LoginForm>();
            // Registration form temporarily removed
            
            // Register dashboard form
            services.AddTransient<DashboardForm.DashboardForm>();
            
            // Register product forms
            services.AddTransient<ProductForm.ProductListForm>();
            
            // Register category forms
            services.AddTransient<CategoryForm.Category_Form>();
            
            // Register stock movement forms
            services.AddTransient<StockInForm.StockInForm>(provider => 
                new StockInForm.StockInForm(provider));
            services.AddTransient<StockOutForm.StockOutForm>(provider => 
                new StockOutForm.StockOutForm(provider));
            
            // Register alert form
            services.AddTransient<AlertForm.AlertForm>(provider => 
                new AlertForm.AlertForm(provider));
            
            // Register statistics form
            services.AddTransient<StatForm.StatForm>();
            
            // Register main form (now unused since we start with LoginForm)
            services.AddTransient<MainForm>();
            
            // Register import/export form
            // services.AddTransient<ImportExportForm.ImportExportForm>();
        }
    }
}
