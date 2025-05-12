using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock.Data.Entites;

namespace GestionDeStock.ProductForm
{
    public partial class ProductDetailsForm : Form
    {
        private Product _product;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        public ProductDetailsForm(Product product) : this()
        {
            _product = product;
            // Load product data into form controls
            LoadProductData();
        }

        private void LoadProductData()
        {
            // TODO: Load product data into form controls
            // Example: nameTextBox.Text = _product.Name;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Enter(object sender, EventArgs e)
        {

        }
    }
}
