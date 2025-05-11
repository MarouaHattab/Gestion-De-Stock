using Microsoft.Extensions.DependencyInjection;

namespace GestionDeStock
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private GestionDeStock.DashboardForm.DashboardForm _dashboardForm;
        private GestionDeStock.CategoryForm.Category_Form _categoryForm;
        private GestionDeStock.ProductForm.ProductListForm _productForm;
        private GestionDeStock.StockInForm.StockInForm _stockInForm;
        private GestionDeStock.StockOutForm.StockOutForm _stockOutForm;
        private GestionDeStock.AlertForm.AlertForm _alertForm;
        private GestionDeStock.LoginForm.LoginForm _loginForm;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Vérifier si l'utilisateur est connecté
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            if (_loginForm == null || _loginForm.IsDisposed)
            {
                _loginForm = _serviceProvider.GetRequiredService<GestionDeStock.LoginForm.LoginForm>();
            }

            // Afficher le formulaire de connexion en mode modal
            if (_loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si la connexion est réussie, afficher le tableau de bord
                ShowDashboardForm();
            }
            else
            {
                // Si l'utilisateur annule la connexion, fermer l'application
                this.Close();
            }
        }

        private void ShowDashboardForm()
        {
            if (_dashboardForm == null || _dashboardForm.IsDisposed)
            {
                _dashboardForm = _serviceProvider.GetRequiredService<GestionDeStock.DashboardForm.DashboardForm>();
                _dashboardForm.MdiParent = this;
                _dashboardForm.WindowState = FormWindowState.Maximized;


            }

            _dashboardForm.Show();
            _dashboardForm.Activate();
        }

        private void ShowCategoryForm()
        {
            if (_categoryForm == null || _categoryForm.IsDisposed)
            {
                _categoryForm = _serviceProvider.GetRequiredService<GestionDeStock.CategoryForm.Category_Form>();
                _categoryForm.MdiParent = this;
                _categoryForm.WindowState = FormWindowState.Maximized;
            }

            _categoryForm.Show();
            _categoryForm.Activate();
        }

        private void ShowProductForm()
        {
            if (_productForm == null || _productForm.IsDisposed)
            {
                _productForm = _serviceProvider.GetRequiredService<GestionDeStock.ProductForm.ProductListForm>();
                _productForm.MdiParent = this;
                _productForm.WindowState = FormWindowState.Maximized;
            }

            _productForm.Show();
            _productForm.Activate();
        }

        private void ShowStockInForm()
        {
            if (_stockInForm == null || _stockInForm.IsDisposed)
            {
                _stockInForm = _serviceProvider.GetRequiredService<GestionDeStock.StockInForm.StockInForm>();
                _stockInForm.MdiParent = this;
                _stockInForm.WindowState = FormWindowState.Maximized;
            }

            _stockInForm.Show();
            _stockInForm.Activate();
        }

        private void ShowStockOutForm()
        {
            if (_stockOutForm == null || _stockOutForm.IsDisposed)
            {
                _stockOutForm = _serviceProvider.GetRequiredService<GestionDeStock.StockOutForm.StockOutForm>();
                _stockOutForm.MdiParent = this;
                _stockOutForm.WindowState = FormWindowState.Maximized;
            }

            _stockOutForm.Show();
            _stockOutForm.Activate();
        }

        private void ShowAlertForm()
        {
            if (_alertForm == null || _alertForm.IsDisposed)
            {
                _alertForm = _serviceProvider.GetRequiredService<GestionDeStock.AlertForm.AlertForm>();
                _alertForm.MdiParent = this;
                _alertForm.WindowState = FormWindowState.Maximized;
            }

            _alertForm.Show();
            _alertForm.Activate();
        }

        private void HandleLogout()
        {
            // Fermer toutes les fenêtres filles
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Afficher à nouveau le formulaire de connexion
            ShowLoginForm();
        }
    }
}