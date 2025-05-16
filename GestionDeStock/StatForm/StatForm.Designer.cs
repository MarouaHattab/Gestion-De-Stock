namespace GestionDeStock.StatForm
{
    partial class StatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainTableLayoutPanel = new TableLayoutPanel();
            panelTopProducts = new Panel();
            dgvTopProducts = new DataGridView();
            lblTopProductsHeader = new Label();
            panelLowStock = new Panel();
            dgvLowStock = new DataGridView();
            lblLowStockHeader = new Label();
            panelMonthlySales = new Panel();
            dgvMonthlySales = new DataGridView();
            lblMonthlySalesHeader = new Label();
            panelCategoryDistribution = new Panel();
            dgvCategoryDistribution = new DataGridView();
            lblCategoryDistributionHeader = new Label();
            panel1 = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            btnBack = new Button();
            tooltipMain = new ToolTip(components);
            productBindingSource = new BindingSource(components);
            mainTableLayoutPanel.SuspendLayout();
            panelTopProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).BeginInit();
            panelLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            panelMonthlySales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlySales).BeginInit();
            panelCategoryDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryDistribution).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.Controls.Add(panelTopProducts, 0, 1);
            mainTableLayoutPanel.Controls.Add(panelLowStock, 1, 1);
            mainTableLayoutPanel.Controls.Add(panelMonthlySales, 0, 2);
            mainTableLayoutPanel.Controls.Add(panelCategoryDistribution, 1, 2);
            mainTableLayoutPanel.Controls.Add(panel1, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(5);
            mainTableLayoutPanel.RowCount = 3;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.Size = new Size(1170, 1024);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // panelTopProducts
            // 
            panelTopProducts.BackColor = Color.White;
            panelTopProducts.BorderStyle = BorderStyle.FixedSingle;
            panelTopProducts.Controls.Add(dgvTopProducts);
            panelTopProducts.Controls.Add(lblTopProductsHeader);
            panelTopProducts.Dock = DockStyle.Fill;
            panelTopProducts.Location = new Point(16, 98);
            panelTopProducts.Margin = new Padding(11, 13, 11, 13);
            panelTopProducts.Name = "panelTopProducts";
            panelTopProducts.Padding = new Padding(11, 13, 11, 13);
            panelTopProducts.Size = new Size(558, 441);
            panelTopProducts.TabIndex = 0;
            // 
            // dgvTopProducts
            // 
            dgvTopProducts.AllowUserToAddRows = false;
            dgvTopProducts.AllowUserToDeleteRows = false;
            dgvTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopProducts.BorderStyle = BorderStyle.None;
            dgvTopProducts.ColumnHeadersHeight = 40;
            dgvTopProducts.Dock = DockStyle.Fill;
            dgvTopProducts.Location = new Point(11, 53);
            dgvTopProducts.Margin = new Padding(3, 4, 3, 4);
            dgvTopProducts.Name = "dgvTopProducts";
            dgvTopProducts.ReadOnly = true;
            dgvTopProducts.RowHeadersVisible = false;
            dgvTopProducts.RowHeadersWidth = 51;
            dgvTopProducts.RowTemplate.Height = 30;
            dgvTopProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopProducts.Size = new Size(534, 373);
            dgvTopProducts.TabIndex = 1;
            // 
            // lblTopProductsHeader
            // 
            lblTopProductsHeader.Dock = DockStyle.Top;
            lblTopProductsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopProductsHeader.Location = new Point(11, 13);
            lblTopProductsHeader.Name = "lblTopProductsHeader";
            lblTopProductsHeader.Size = new Size(534, 40);
            lblTopProductsHeader.TabIndex = 0;
            lblTopProductsHeader.Text = "Produits les plus vendus";
            // 
            // panelLowStock
            // 
            panelLowStock.BackColor = Color.White;
            panelLowStock.BorderStyle = BorderStyle.FixedSingle;
            panelLowStock.Controls.Add(dgvLowStock);
            panelLowStock.Controls.Add(lblLowStockHeader);
            panelLowStock.Dock = DockStyle.Fill;
            panelLowStock.Location = new Point(596, 98);
            panelLowStock.Margin = new Padding(11, 13, 11, 13);
            panelLowStock.Name = "panelLowStock";
            panelLowStock.Padding = new Padding(11, 13, 11, 13);
            panelLowStock.Size = new Size(558, 441);
            panelLowStock.TabIndex = 1;
            // 
            // dgvLowStock
            // 
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStock.BorderStyle = BorderStyle.None;
            dgvLowStock.ColumnHeadersHeight = 40;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.Location = new Point(11, 53);
            dgvLowStock.Margin = new Padding(3, 4, 3, 4);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.ReadOnly = true;
            dgvLowStock.RowHeadersVisible = false;
            dgvLowStock.RowHeadersWidth = 51;
            dgvLowStock.RowTemplate.Height = 30;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.Size = new Size(534, 373);
            dgvLowStock.TabIndex = 1;
            // 
            // lblLowStockHeader
            // 
            lblLowStockHeader.Dock = DockStyle.Top;
            lblLowStockHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLowStockHeader.Location = new Point(11, 13);
            lblLowStockHeader.Name = "lblLowStockHeader";
            lblLowStockHeader.Size = new Size(534, 40);
            lblLowStockHeader.TabIndex = 0;
            lblLowStockHeader.Text = "Produits avec stocks faibles";
            // 
            // panelMonthlySales
            // 
            panelMonthlySales.BackColor = Color.White;
            panelMonthlySales.BorderStyle = BorderStyle.FixedSingle;
            panelMonthlySales.Controls.Add(dgvMonthlySales);
            panelMonthlySales.Controls.Add(lblMonthlySalesHeader);
            panelMonthlySales.Dock = DockStyle.Fill;
            panelMonthlySales.Location = new Point(16, 565);
            panelMonthlySales.Margin = new Padding(11, 13, 11, 13);
            panelMonthlySales.Name = "panelMonthlySales";
            panelMonthlySales.Padding = new Padding(11, 13, 11, 13);
            panelMonthlySales.Size = new Size(558, 441);
            panelMonthlySales.TabIndex = 2;
            // 
            // dgvMonthlySales
            // 
            dgvMonthlySales.AllowUserToAddRows = false;
            dgvMonthlySales.AllowUserToDeleteRows = false;
            dgvMonthlySales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlySales.BorderStyle = BorderStyle.None;
            dgvMonthlySales.ColumnHeadersHeight = 40;
            dgvMonthlySales.Dock = DockStyle.Fill;
            dgvMonthlySales.Location = new Point(11, 53);
            dgvMonthlySales.Margin = new Padding(3, 4, 3, 4);
            dgvMonthlySales.Name = "dgvMonthlySales";
            dgvMonthlySales.ReadOnly = true;
            dgvMonthlySales.RowHeadersVisible = false;
            dgvMonthlySales.RowHeadersWidth = 51;
            dgvMonthlySales.RowTemplate.Height = 30;
            dgvMonthlySales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlySales.Size = new Size(534, 373);
            dgvMonthlySales.TabIndex = 1;
            // 
            // lblMonthlySalesHeader
            // 
            lblMonthlySalesHeader.Dock = DockStyle.Top;
            lblMonthlySalesHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonthlySalesHeader.Location = new Point(11, 13);
            lblMonthlySalesHeader.Name = "lblMonthlySalesHeader";
            lblMonthlySalesHeader.Size = new Size(534, 40);
            lblMonthlySalesHeader.TabIndex = 0;
            lblMonthlySalesHeader.Text = "Ventes mensuelles";
            // 
            // panelCategoryDistribution
            // 
            panelCategoryDistribution.BackColor = Color.White;
            panelCategoryDistribution.BorderStyle = BorderStyle.FixedSingle;
            panelCategoryDistribution.Controls.Add(dgvCategoryDistribution);
            panelCategoryDistribution.Controls.Add(lblCategoryDistributionHeader);
            panelCategoryDistribution.Dock = DockStyle.Fill;
            panelCategoryDistribution.Location = new Point(596, 565);
            panelCategoryDistribution.Margin = new Padding(11, 13, 11, 13);
            panelCategoryDistribution.Name = "panelCategoryDistribution";
            panelCategoryDistribution.Padding = new Padding(11, 13, 11, 13);
            panelCategoryDistribution.Size = new Size(558, 441);
            panelCategoryDistribution.TabIndex = 3;
            // 
            // dgvCategoryDistribution
            // 
            dgvCategoryDistribution.AllowUserToAddRows = false;
            dgvCategoryDistribution.AllowUserToDeleteRows = false;
            dgvCategoryDistribution.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoryDistribution.BorderStyle = BorderStyle.None;
            dgvCategoryDistribution.ColumnHeadersHeight = 40;
            dgvCategoryDistribution.Dock = DockStyle.Fill;
            dgvCategoryDistribution.Location = new Point(11, 53);
            dgvCategoryDistribution.Margin = new Padding(3, 4, 3, 4);
            dgvCategoryDistribution.Name = "dgvCategoryDistribution";
            dgvCategoryDistribution.ReadOnly = true;
            dgvCategoryDistribution.RowHeadersVisible = false;
            dgvCategoryDistribution.RowHeadersWidth = 51;
            dgvCategoryDistribution.RowTemplate.Height = 30;
            dgvCategoryDistribution.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoryDistribution.Size = new Size(534, 373);
            dgvCategoryDistribution.TabIndex = 1;
            // 
            // lblCategoryDistributionHeader
            // 
            lblCategoryDistributionHeader.Dock = DockStyle.Top;
            lblCategoryDistributionHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategoryDistributionHeader.Location = new Point(11, 13);
            lblCategoryDistributionHeader.Name = "lblCategoryDistributionHeader";
            lblCategoryDistributionHeader.Size = new Size(534, 40);
            lblCategoryDistributionHeader.TabIndex = 0;
            lblCategoryDistributionHeader.Text = "Distribution par catégorie";
            // 
            // panel1
            // 
            mainTableLayoutPanel.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 72);
            panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(11, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tableau de bord statistique";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.RoyalBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1022, 13);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 45);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Actualiser";
            tooltipMain.SetToolTip(btnRefresh, "Actualiser les données du tableau de bord");
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(70, 70, 70);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(885, 13);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 45);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Retour";
            tooltipMain.SetToolTip(btnBack, "Retour au tableau de bord");
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Data.Entites.Product);
            // 
            // StatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 1024);
            Controls.Add(mainTableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StatForm";
            Text = "Tableau de bord statistique";
            mainTableLayoutPanel.ResumeLayout(false);
            panelTopProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).EndInit();
            panelLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            panelMonthlySales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonthlySales).EndInit();
            panelCategoryDistribution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategoryDistribution).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel panelTopProducts;
        private System.Windows.Forms.Panel panelLowStock;
        private System.Windows.Forms.Panel panelMonthlySales;
        private System.Windows.Forms.Panel panelCategoryDistribution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip tooltipMain;
        private System.Windows.Forms.DataGridView dgvTopProducts;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.DataGridView dgvMonthlySales;
        private System.Windows.Forms.DataGridView dgvCategoryDistribution;
        private System.Windows.Forms.Label lblTopProductsHeader;
        private System.Windows.Forms.Label lblLowStockHeader;
        private System.Windows.Forms.Label lblMonthlySalesHeader;
        private System.Windows.Forms.Label lblCategoryDistributionHeader;
        private BindingSource productBindingSource;
    }
}