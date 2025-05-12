using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock.ProductForm;
using GestionDeStock.Data.Entites;
using GestionDeStock.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeStock.ProductForm
{
    public partial class ProductListForm : Form
    {
        private ProductDetailsForm _productDetailsForm;
        private readonly IServiceProvider _serviceProvider;
        public ProductListForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var product = new Data.Entites.Product();
            var dialogForm = new ProductDetailsForm(product);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var repo = _serviceProvider.GetRequiredService<ProductRepository>();
                repo.AddProductAsync(product);
            }
            ReloadData();

        }


        private void ReloadData()
        {
            var repo = _serviceProvider.GetRequiredService<ProductRepository>();
            productBindingSource.DataSource = repo.GetAllProductsAsync();

        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var product = this.productBindingSource.Current as Product;
            if (product == null) return;
            var dialogForm = new ProductDetailsForm(product);
            //Afficher la formulaire
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var repo = _serviceProvider.GetRequiredService<ProductRepository>();
                repo.UpdateProductAsync(product);
            }
            ReloadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var product = this.productBindingSource.Current as Product;
            if (product == null)
            {
                MessageBox.Show("Aucun produit sélectionné.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le produit « {product.Name} » ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var repo = _serviceProvider.GetRequiredService<ProductRepository>();
                    repo.DeleteProductAsync(product.ProductId);
                    MessageBox.Show("Produit supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ReloadButton_Click_1(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
