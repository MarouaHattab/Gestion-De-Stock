using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock.Data.Context;
using GestionDeStock.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeStock.StatForm
{
    public partial class StatForm : Form
    {
        private readonly StockDbContext _context;
        public IServiceProvider _serviceProvider;

        // Define modern color palette to match dashboard
        private readonly Color primaryColor = Color.FromArgb(0, 122, 204);
        private readonly Color secondaryColor = Color.FromArgb(45, 52, 64);
        private readonly Color accentColor = Color.FromArgb(97, 168, 237);
        private readonly Color textLightColor = Color.FromArgb(240, 240, 240);
        private readonly Color textDarkColor = Color.FromArgb(30, 30, 30);

        public StatForm(StockDbContext context)
        {
            InitializeComponent();
            _context = context;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1024, 768);
            
            // Set form styling
            ApplyModernStyling();
            
            // Add event handlers for responsiveness
            this.Resize += StatForm_Resize;
            this.SizeChanged += StatForm_SizeChanged;
            
            // Load data
            LoadData();
        }
        
        private void ApplyModernStyling()
        {
            // Apply consistent styling with other forms
            this.BackColor = Color.White;
            panel1.BackColor = primaryColor;
            lblTitle.ForeColor = textLightColor;
            
            // Style the refresh button
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.BackColor = secondaryColor;
            btnRefresh.ForeColor = textLightColor;
            btnRefresh.Padding = new Padding(10, 0, 10, 0);
            btnRefresh.FlatAppearance.MouseOverBackColor = accentColor;
            btnRefresh.Cursor = Cursors.Hand;
            
            // Add hover effect for the refresh button
            btnRefresh.MouseEnter += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = accentColor;
            };
            
            btnRefresh.MouseLeave += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = secondaryColor;
            };
            
            // Add back button to return to dashboard
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.FromArgb(70, 70, 70);
            btnBack.ForeColor = textLightColor;
            btnBack.Cursor = Cursors.Hand;
            
            btnBack.MouseEnter += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = Color.FromArgb(100, 100, 100);
            };
            
            btnBack.MouseLeave += (s, e) => {
                Button btn = (Button)s;
                btn.BackColor = Color.FromArgb(70, 70, 70);
            };
            
            // Style DataGridViews
            StyleDataGridView(dgvTopProducts);
            StyleDataGridView(dgvLowStock);
            StyleDataGridView(dgvCategoryDistribution);
            StyleDataGridView(dgvMonthlySales);
        }
        
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            // Header style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = textLightColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = primaryColor;
            dgv.ColumnHeadersHeight = 40;
            
            // Cell style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = textDarkColor;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 250);
            dgv.DefaultCellStyle.SelectionForeColor = textDarkColor;
            
            // Alternate row style
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }
        
        private void StatForm_Resize(object sender, EventArgs e)
        {
            // Adjust layout when form is resized
            AdjustControlsForResponsiveness();
        }
        
        private void StatForm_SizeChanged(object sender, EventArgs e)
        {
            // Adjust layout when form size changes
            AdjustControlsForResponsiveness();
        }
        
        private void AdjustControlsForResponsiveness()
        {
            try
            {
                // Adjust font sizes based on form width
                if (this.Width >= 1200)
                {
                    lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
                }
                else if (this.Width >= 1000)
                {
                    lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                }
                else
                {
                    lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                }
                
                // Refresh layout
                mainTableLayoutPanel.PerformLayout();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in AdjustControlsForResponsiveness: {ex.Message}");
            }
        }

        private void LoadData()
        {
            LoadTopSellingProducts();
            LoadLowStockProducts();
            LoadMonthlySales();
            LoadCategoryDistribution();
            LoadSummaryData();
        }

        private void LoadTopSellingProducts()
        {
            try
            {
                // Clear existing data
                dgvTopProducts.DataSource = null;
                dgvTopProducts.Columns.Clear();
                
                // Get data first from the database
                var stockOutsData = _context.StockOuts
                    .Include(so => so.Product)
                    .ThenInclude(p => p.Category)
                    .ToList();
                
                // Perform calculations client-side
                var topProducts = stockOutsData
                    .GroupBy(so => so.ProductId)
                    .Select(g => new
                    {
                        ProductName = g.First().Product.Name,
                        CategoryName = g.First().Product.Category.Name,
                        TotalQuantity = g.Sum(so => so.Quantity),
                        Revenue = g.Sum(so => so.Quantity * g.First().Product.SalePrice),
                        AverageUnitPrice = g.Sum(so => so.Quantity * g.First().Product.SalePrice) / g.Sum(so => so.Quantity)
                    })
                    .OrderByDescending(x => x.TotalQuantity)
                    .Take(5)
                    .ToList();
                
                // Create DataTable for display
                DataTable dt = new DataTable();
                dt.Columns.Add("Produit", typeof(string));
                dt.Columns.Add("Catégorie", typeof(string));
                dt.Columns.Add("Quantité Vendue", typeof(int));
                dt.Columns.Add("Revenu", typeof(decimal));
                dt.Columns.Add("Prix Unitaire Moyen", typeof(decimal));
                
                foreach (var product in topProducts)
                {
                    dt.Rows.Add(
                        product.ProductName,
                        product.CategoryName,
                        product.TotalQuantity,
                        product.Revenue,
                        product.AverageUnitPrice
                    );
                }
                
                dgvTopProducts.DataSource = dt;
                
                // Format currency columns
                dgvTopProducts.Columns["Revenu"].DefaultCellStyle.Format = "C2";
                dgvTopProducts.Columns["Prix Unitaire Moyen"].DefaultCellStyle.Format = "C2";
                
                // Set header text
                lblTopProductsHeader.Text = "Produits les plus vendus";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits les plus vendus: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLowStockProducts()
        {
            try
            {
                // Clear existing data
                dgvLowStock.DataSource = null;
                dgvLowStock.Columns.Clear();
                
                // Pull the data first, then filter locally
                var products = _context.Products
                    .Include(p => p.Category)
                    .ToList();
                
                // Filter on the client side
                var lowStockProducts = products
                    .Where(p => p.Quantity > 0 && p.Quantity <= p.AlertThreshold)
                    .Select(p => new
                    {
                        ProductName = p.Name,
                        CategoryName = p.Category.Name,
                        CurrentStock = p.Quantity,
                        AlertThreshold = p.AlertThreshold,
                        StockStatus = p.StockStatus,
                        PurchasePrice = p.PurchasePrice,
                        StockValue = p.Quantity * p.PurchasePrice
                    })
                    .OrderBy(x => x.CurrentStock)
                    .ToList();
                
                // Create DataTable for display
                DataTable dt = new DataTable();
                dt.Columns.Add("Produit", typeof(string));
                dt.Columns.Add("Catégorie", typeof(string));
                dt.Columns.Add("Stock Actuel", typeof(int));
                dt.Columns.Add("Seuil d'Alerte", typeof(int));
                dt.Columns.Add("Statut", typeof(string));
                dt.Columns.Add("Prix d'Achat", typeof(decimal));
                dt.Columns.Add("Valeur du Stock", typeof(decimal));
                
                foreach (var product in lowStockProducts)
                {
                    dt.Rows.Add(
                        product.ProductName,
                        product.CategoryName,
                        product.CurrentStock,
                        product.AlertThreshold,
                        product.StockStatus,
                        product.PurchasePrice,
                        product.StockValue
                    );
                }
                
                dgvLowStock.DataSource = dt;
                
                // Format currency columns
                dgvLowStock.Columns["Prix d'Achat"].DefaultCellStyle.Format = "C2";
                dgvLowStock.Columns["Valeur du Stock"].DefaultCellStyle.Format = "C2";
                
                // Set header text
                lblLowStockHeader.Text = "Produits en stock faible";
                
                // Add cell formatting for stock status
                dgvLowStock.CellFormatting += (sender, e) => {
                    if (e.ColumnIndex == dgvLowStock.Columns["Statut"].Index && e.RowIndex >= 0)
                    {
                        string status = e.Value?.ToString() ?? "";
                        
                        if (status == "Niveau critique")
                        {
                            e.CellStyle.ForeColor = Color.White;
                            e.CellStyle.BackColor = Color.FromArgb(220, 53, 69); // Red
                            e.CellStyle.Font = new Font(dgvLowStock.Font, FontStyle.Bold);
                        }
                        else if (status == "Niveau bas")
                        {
                            e.CellStyle.BackColor = Color.FromArgb(255, 193, 7); // Yellow
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits en stock faible: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMonthlySales()
        {
            try
            {
                // Clear existing data
                dgvMonthlySales.DataSource = null;
                dgvMonthlySales.Columns.Clear();
                
                var currentYear = DateTime.Now.Year;
                
                // First, get the data from the database
                var salesData = _context.StockOuts
                    .Include(so => so.Product)
                    .Where(so => so.ExitDate.Year == currentYear)
                    .ToList();
                
                // Group by month and perform calculations on the client side
                var monthlySales = salesData
                    .GroupBy(so => new { Month = so.ExitDate.Month, Quarter = (so.ExitDate.Month - 1) / 3 + 1 })
                    .Select(g => new
                    {
                        Month = g.Key.Month,
                        Quarter = g.Key.Quarter,
                        TotalQuantity = g.Sum(so => so.Quantity),
                        TotalRevenue = g.Sum(so => so.Quantity * so.Product.SalePrice),
                        ItemCount = g.Count(),
                        AvgRevenuePerTransaction = g.Sum(so => so.Quantity * so.Product.SalePrice) / g.Count()
                    })
                    .OrderBy(x => x.Month)
                    .ToList();
                
                // Create all months even if no sales
                var months = new[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
                
                // Create DataTable for display
                DataTable dt = new DataTable();
                dt.Columns.Add("Mois", typeof(string));
                dt.Columns.Add("Trimestre", typeof(int));
                dt.Columns.Add("Quantité", typeof(int));
                dt.Columns.Add("Revenu", typeof(decimal));
                dt.Columns.Add("Nb Transactions", typeof(int));
                dt.Columns.Add("CA Moyen/Transaction", typeof(decimal));
                
                for (int i = 1; i <= 12; i++)
                {
                    var monthlySale = monthlySales.FirstOrDefault(s => s.Month == i);
                    
                    dt.Rows.Add(
                        months[i - 1],
                        (i - 1) / 3 + 1,
                        monthlySale?.TotalQuantity ?? 0,
                        monthlySale?.TotalRevenue ?? 0,
                        monthlySale?.ItemCount ?? 0,
                        monthlySale?.AvgRevenuePerTransaction ?? 0
                    );
                }
                
                dgvMonthlySales.DataSource = dt;
                
                // Format currency columns
                dgvMonthlySales.Columns["Revenu"].DefaultCellStyle.Format = "C2";
                dgvMonthlySales.Columns["CA Moyen/Transaction"].DefaultCellStyle.Format = "C2";
                
                // Set header text
                lblMonthlySalesHeader.Text = "Ventes mensuelles";
                
                // Add cell formatting for highlighting quarters
                dgvMonthlySales.CellFormatting += (sender, e) => {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dgvMonthlySales.Rows[e.RowIndex];
                        int quarter = Convert.ToInt32(row.Cells["Trimestre"].Value);
                        
                        Color quarterColor;
                        switch (quarter)
                        {
                            case 1:
                                quarterColor = Color.FromArgb(240, 248, 255); // Light blue
                                break;
                            case 2:
                                quarterColor = Color.FromArgb(240, 255, 240); // Light green
                                break;
                            case 3:
                                quarterColor = Color.FromArgb(255, 248, 240); // Light orange
                                break;
                            case 4:
                                quarterColor = Color.FromArgb(255, 240, 245); // Light red
                                break;
                            default:
                                quarterColor = Color.White;
                                break;
                        }
                        
                        e.CellStyle.BackColor = quarterColor;
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des ventes mensuelles: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadCategoryDistribution()
        {
            try
            {
                // Clear existing data
                dgvCategoryDistribution.DataSource = null;
                dgvCategoryDistribution.Columns.Clear();
                
                // First, get the data from the database
                var categories = _context.Categories
                    .Include(c => c.Products)
                    .ToList();
                
                // Perform the calculations on the client side
                var categoryDistribution = categories
                    .Select(c => new
                    {
                        CategoryName = c.Name,
                        ProductCount = c.Products.Count,
                        StockValue = c.Products.Sum(p => p.Quantity * p.PurchasePrice),
                        OutOfStockCount = c.Products.Count(p => p.Quantity == 0),
                        LowStockCount = c.Products.Count(p => p.Quantity > 0 && p.Quantity <= p.AlertThreshold),
                        HealthyStockCount = c.Products.Count(p => p.Quantity > 0 && p.Quantity > p.AlertThreshold),
                        TotalStock = c.Products.Sum(p => p.Quantity)
                    })
                    .OrderByDescending(c => c.ProductCount)
                    .ToList();
                
                // Create DataTable for display
                DataTable dt = new DataTable();
                dt.Columns.Add("Catégorie", typeof(string));
                dt.Columns.Add("Nb Produits", typeof(int));
                dt.Columns.Add("Stock Total", typeof(int));
                dt.Columns.Add("Valeur du Stock", typeof(decimal));
                dt.Columns.Add("Produits en Rupture", typeof(int));
                dt.Columns.Add("Produits en Stock Faible", typeof(int));
                dt.Columns.Add("Produits en Stock Normal", typeof(int));
                
                foreach (var category in categoryDistribution)
                {
                    dt.Rows.Add(
                        category.CategoryName,
                        category.ProductCount,
                        category.TotalStock,
                        category.StockValue,
                        category.OutOfStockCount,
                        category.LowStockCount,
                        category.HealthyStockCount
                    );
                }
                
                // Add a total row
                DataRow totalRow = dt.NewRow();
                totalRow["Catégorie"] = "TOTAL";
                totalRow["Nb Produits"] = categoryDistribution.Sum(c => c.ProductCount);
                totalRow["Stock Total"] = categoryDistribution.Sum(c => c.TotalStock);
                totalRow["Valeur du Stock"] = categoryDistribution.Sum(c => c.StockValue);
                totalRow["Produits en Rupture"] = categoryDistribution.Sum(c => c.OutOfStockCount);
                totalRow["Produits en Stock Faible"] = categoryDistribution.Sum(c => c.LowStockCount);
                totalRow["Produits en Stock Normal"] = categoryDistribution.Sum(c => c.HealthyStockCount);
                dt.Rows.Add(totalRow);
                
                dgvCategoryDistribution.DataSource = dt;
                
                // Format currency column
                dgvCategoryDistribution.Columns["Valeur du Stock"].DefaultCellStyle.Format = "C2";
                
                // Set header text
                lblCategoryDistributionHeader.Text = "Distribution par catégorie";
                
                // Add cell formatting for totals row
                dgvCategoryDistribution.CellFormatting += (sender, e) => {
                    if (e.RowIndex == dgvCategoryDistribution.Rows.Count - 1)
                    {
                        e.CellStyle.Font = new Font(dgvCategoryDistribution.Font, FontStyle.Bold);
                        e.CellStyle.BackColor = Color.FromArgb(220, 230, 240);
                    }
                    
                    if (e.ColumnIndex == dgvCategoryDistribution.Columns["Produits en Rupture"].Index && e.RowIndex >= 0)
                    {
                        int value = Convert.ToInt32(e.Value);
                        if (value > 0)
                        {
                            e.CellStyle.ForeColor = Color.White;
                            e.CellStyle.BackColor = Color.FromArgb(220, 53, 69); // Red
                            e.CellStyle.Font = new Font(dgvCategoryDistribution.Font, FontStyle.Bold);
                        }
                    }
                    
                    if (e.ColumnIndex == dgvCategoryDistribution.Columns["Produits en Stock Faible"].Index && e.RowIndex >= 0)
                    {
                        int value = Convert.ToInt32(e.Value);
                        if (value > 0)
                        {
                            e.CellStyle.BackColor = Color.FromArgb(255, 193, 7); // Yellow
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de la distribution par catégorie: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadSummaryData()
        {
            try
            {
                // Get basic counts which SQLite can handle
                var totalProducts = _context.Products.Count();
                var totalCategories = _context.Categories.Count();
                var totalStock = _context.Products.Sum(p => p.Quantity);
                
                // Load entities and perform calculations client-side
                var products = _context.Products.ToList();
                var totalStockValue = products.Sum(p => p.Quantity * p.PurchasePrice);
                var lowStockCount = products.Count(p => p.Quantity > 0 && p.Quantity <= p.AlertThreshold);
                var outOfStockCount = products.Count(p => p.Quantity == 0);
                
                var currentYear = DateTime.Now.Year;
                
                // Load StockOuts to client and calculate
                var stockOuts = _context.StockOuts
                    .Include(so => so.Product)
                    .Where(so => so.ExitDate.Year == currentYear)
                    .ToList();
                
                var annualSales = stockOuts.Sum(so => so.Quantity);
                var annualRevenue = stockOuts.Sum(so => so.Quantity * so.Product.SalePrice);
                
                // Output summary data to debug
                System.Diagnostics.Debug.WriteLine($"Total Products: {totalProducts}");
                System.Diagnostics.Debug.WriteLine($"Total Categories: {totalCategories}");
                System.Diagnostics.Debug.WriteLine($"Total Stock: {totalStock}");
                System.Diagnostics.Debug.WriteLine($"Stock Value: {totalStockValue:C}");
                System.Diagnostics.Debug.WriteLine($"Low Stock: {lowStockCount}");
                System.Diagnostics.Debug.WriteLine($"Out of Stock: {outOfStockCount}");
                System.Diagnostics.Debug.WriteLine($"Annual Sales: {annualSales}");
                System.Diagnostics.Debug.WriteLine($"Annual Revenue: {annualRevenue:C}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading summary data: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Dashboard form from service provider
                var form = _serviceProvider.GetRequiredService<GestionDeStock.DashboardForm.DashboardForm>();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning to dashboard: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
