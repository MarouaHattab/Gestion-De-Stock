using GestionDeStock.Data.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionDeStock.DashboardForm
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            var form = new GestionDeStock.CategoryForm.Category_Form();
            form.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            var form = new GestionDeStock.ProductForm.ProductListForm();
            form.Show();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            var form = new GestionDeStock.StatForm.StatForm();
            form.Show();
        }

        private void InStockButton_Click(object sender, EventArgs e)
        {
            var form = new GestionDeStock.StockInForm.StockInForm();
            form.Show();
        }

        private void OutStockButton_Click(object sender, EventArgs e)
        {
            var form = new GestionDeStock.StockOutForm.StockOutForm();
            form.Show();
        }

        private void AlertButton_Click(object sender, EventArgs e)
        {
            var form = new GestionDeStock.AlertForm.AlertForm();
            form.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new GestionDeStock.LoginForm.LoginForm();
            loginForm.Show();
            this.Hide(); // ou this.Close(); selon ta logique
        }


    }
}
