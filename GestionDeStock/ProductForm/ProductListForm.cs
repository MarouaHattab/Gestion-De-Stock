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
        private readonly IServiceProvider _serviceProvider;
        private Dictionary<int, string> _categoryNameMap = new Dictionary<int, string>();
        
        public ProductListForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            
            // Set up DataGridView for category name display
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            
            // Register Load event to initialize data
            this.Load += ProductListForm_Load;
        }
        
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if this is the category column and it has a value
            if (dataGridView1.Columns[e.ColumnIndex].Name == "categoryDataGridViewTextBoxColumn" && 
                e.Value != null)
            {
                // Get the CategoryId value
                if (int.TryParse(e.Value.ToString(), out int categoryId))
                {
                    // Try to get the category name from our map
                    if (_categoryNameMap.ContainsKey(categoryId))
                    {
                        e.Value = _categoryNameMap[categoryId];
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Data.Entites.Product();
                var dialogForm = new ProductDetailsForm(product, _serviceProvider);
                var dialogResult = dialogForm.ShowDialog();
                
                if (dialogResult == DialogResult.OK)
                {
                    var repo = _serviceProvider.GetRequiredService<IProductRepository>();
                    await repo.AddProductAsync(product);
                    MessageBox.Show("Produit ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ReloadData()
        {
            try
            {
                // First load all categories to build our name map
                await LoadCategoryMap();
                
                var repo = _serviceProvider.GetRequiredService<IProductRepository>();
                var productsTask = repo.GetAllProductsAsync();
                var products = await productsTask;
                productBindingSource.DataSource = products;
                
                // Refresh the grid to show the updated data
                dataGridView1.Refresh();
                
                // Show count in status message
                int count = products?.Count ?? 0;
                MessageBox.Show($"{count} produits chargés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private async Task LoadCategoryMap()
        {
            try
            {
                var categoryRepo = _serviceProvider.GetRequiredService<ICategoryRepository>();
                var categories = await categoryRepo.GetAllCategoriesAsync();
                
                _categoryNameMap.Clear();
                foreach (var category in categories)
                {
                    _categoryNameMap[category.CategoryId] = category.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des catégories : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProductListForm_Load(object sender, EventArgs e)
        {
            await ReloadData();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var product = this.productBindingSource.Current as Product;
                if (product == null)
                {
                    MessageBox.Show("Aucun produit sélectionné.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var dialogForm = new ProductDetailsForm(product, _serviceProvider);
                var dialogResult = dialogForm.ShowDialog();
                
                if (dialogResult == DialogResult.OK)
                {
                    var repo = _serviceProvider.GetRequiredService<IProductRepository>();
                    await repo.UpdateProductAsync(product);
                    MessageBox.Show("Produit mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
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
                    var repo = _serviceProvider.GetRequiredService<IProductRepository>();
                    await repo.DeleteProductAsync(product.ProductId);
                    MessageBox.Show("Produit supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await ReloadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ReloadButton_Click_1(object sender, EventArgs e)
        {
            await ReloadData();
        }

        private void BackToDashboardButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the dashboard form from the service provider
                var dashboardForm = _serviceProvider.GetRequiredService<DashboardForm.DashboardForm>();
                
                // Show the dashboard form
                dashboardForm.Show();
                
                // Hide this form instead of closing it
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du retour au tableau de bord : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // If an error occurs, fall back to closing the form
                this.Close();
            }
        }
    }
}
