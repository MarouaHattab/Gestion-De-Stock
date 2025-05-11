using GestionDeStock.Data.Entites;
using GestionDeStock.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.CategoryForm
{
    public partial class Category_Form : Form
    {
        private CategoryDetailsForm _categoryDetailsForm;
        private readonly IServiceProvider _serviceProvider;
        public Category_Form(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }
        private void Reloadbutton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var category = new Data.Entites.Category();
            var dialogForm = new CategoryDetailsForm(category);
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var repo = _serviceProvider.GetRequiredService<CategoryRepository>();
                repo.AddCategoryAsync(category);
            }
            ReloadData();

        }


        private void ReloadData()
        {
            var repo = _serviceProvider.GetRequiredService<CategoryRepository>();
            categoryBindingSource.DataSource = repo.GetAllCategoriesAsync();

        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var category = this.categoryBindingSource.Current as Category;
            if (category == null) return;
            var dialogForm = new CategoryDetailsForm(category);
            //Afficher la formulaire
            var dialogResult = dialogForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var repo = _serviceProvider.GetRequiredService<CategoryRepository>();
                repo.UpdateCategoryAsync(category);
            }
            ReloadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var category = this.categoryBindingSource.Current as Category;
            if (category == null)
            {
                MessageBox.Show("Aucune catégorie sélectionnée.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Voulez-vous vraiment supprimer la catégorie « {category.Name} » ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var repo = _serviceProvider.GetRequiredService<CategoryRepository>();
                    repo.DeleteCategoryAsync(category.CategoryId);
                    MessageBox.Show("Catégorie supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
