using GestionDeStock.Data.Entites;
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
    public partial class CategoryDetailsForm : Form
    {
        private Category _category;

        public CategoryDetailsForm(Category category)
        {
            InitializeComponent();
            _category = category;

            // Exemple : si tu as une TextBox pour le nom de la catégorie, tu peux l'initialiser ici :
            // textBoxName.Text = _category.Name;
        }

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }
    }
}
