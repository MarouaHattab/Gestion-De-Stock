namespace GestionDeStock.AlertForm
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            headerPanel = new Panel();
            headerLabel = new Label();
            tabControl = new TabControl();
            zeroStockTabPage = new TabPage();
            zeroStockPanel = new Panel();
            zeroStockDataGridView = new DataGridView();
            zeroStockCountLabel = new Label();
            zeroStockHeaderPanel = new Panel();
            zeroStockHeaderLabel = new Label();
            lowStockTabPage = new TabPage();
            lowStockPanel = new Panel();
            lowStockDataGridView = new DataGridView();
            lowStockCountLabel = new Label();
            lowStockHeaderPanel = new Panel();
            lowStockHeaderLabel = new Label();
            footerPanel = new Panel();
            BackToDashboardButton = new Button();
            refreshButton = new Button();
            zeroStockBindingSource = new BindingSource(components);
            lowStockBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            headerPanel.SuspendLayout();
            tabControl.SuspendLayout();
            zeroStockTabPage.SuspendLayout();
            zeroStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zeroStockDataGridView).BeginInit();
            zeroStockHeaderPanel.SuspendLayout();
            lowStockTabPage.SuspendLayout();
            lowStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lowStockDataGridView).BeginInit();
            lowStockHeaderPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zeroStockBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowStockBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(headerPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl, 0, 1);
            tableLayoutPanel1.Controls.Add(footerPanel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 122, 204);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(18, 18);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(878, 64);
            headerPanel.TabIndex = 4;
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Padding = new Padding(10, 0, 0, 0);
            headerLabel.Size = new Size(878, 64);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Stock Notification Center";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(zeroStockTabPage);
            tabControl.Controls.Add(lowStockTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(18, 88);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(878, 434);
            tabControl.TabIndex = 5;
            // 
            // zeroStockTabPage
            // 
            zeroStockTabPage.Controls.Add(zeroStockPanel);
            zeroStockTabPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zeroStockTabPage.ForeColor = Color.FromArgb(220, 53, 69);
            zeroStockTabPage.Location = new Point(4, 34);
            zeroStockTabPage.Name = "zeroStockTabPage";
            zeroStockTabPage.Padding = new Padding(3);
            zeroStockTabPage.Size = new Size(870, 396);
            zeroStockTabPage.TabIndex = 0;
            zeroStockTabPage.Text = "🚫 Out of Stock Products";
            zeroStockTabPage.UseVisualStyleBackColor = true;
            // 
            // zeroStockPanel
            // 
            zeroStockPanel.Controls.Add(zeroStockDataGridView);
            zeroStockPanel.Controls.Add(zeroStockCountLabel);
            zeroStockPanel.Controls.Add(zeroStockHeaderPanel);
            zeroStockPanel.Dock = DockStyle.Fill;
            zeroStockPanel.Location = new Point(3, 3);
            zeroStockPanel.Name = "zeroStockPanel";
            zeroStockPanel.Size = new Size(864, 390);
            zeroStockPanel.TabIndex = 0;
            // 
            // zeroStockDataGridView
            // 
            zeroStockDataGridView.AllowUserToAddRows = false;
            zeroStockDataGridView.AllowUserToDeleteRows = false;
            zeroStockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            zeroStockDataGridView.BackgroundColor = Color.White;
            zeroStockDataGridView.BorderStyle = BorderStyle.None;
            zeroStockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zeroStockDataGridView.Dock = DockStyle.Fill;
            zeroStockDataGridView.Location = new Point(0, 84);
            zeroStockDataGridView.Name = "zeroStockDataGridView";
            zeroStockDataGridView.ReadOnly = true;
            zeroStockDataGridView.RowHeadersVisible = false;
            zeroStockDataGridView.RowHeadersWidth = 51;
            zeroStockDataGridView.RowTemplate.Height = 35;
            zeroStockDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            zeroStockDataGridView.Size = new Size(864, 306);
            zeroStockDataGridView.TabIndex = 2;
            // 
            // zeroStockCountLabel
            // 
            zeroStockCountLabel.BackColor = Color.FromArgb(248, 215, 218);
            zeroStockCountLabel.Dock = DockStyle.Top;
            zeroStockCountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zeroStockCountLabel.ForeColor = Color.FromArgb(176, 42, 55);
            zeroStockCountLabel.Location = new Point(0, 50);
            zeroStockCountLabel.Name = "zeroStockCountLabel";
            zeroStockCountLabel.Padding = new Padding(10, 0, 0, 0);
            zeroStockCountLabel.Size = new Size(864, 34);
            zeroStockCountLabel.TabIndex = 1;
            zeroStockCountLabel.Text = "No products out of stock";
            zeroStockCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // zeroStockHeaderPanel
            // 
            zeroStockHeaderPanel.BackColor = Color.FromArgb(220, 53, 69);
            zeroStockHeaderPanel.Controls.Add(zeroStockHeaderLabel);
            zeroStockHeaderPanel.Dock = DockStyle.Top;
            zeroStockHeaderPanel.Location = new Point(0, 0);
            zeroStockHeaderPanel.Name = "zeroStockHeaderPanel";
            zeroStockHeaderPanel.Size = new Size(864, 50);
            zeroStockHeaderPanel.TabIndex = 0;
            // 
            // zeroStockHeaderLabel
            // 
            zeroStockHeaderLabel.Dock = DockStyle.Fill;
            zeroStockHeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zeroStockHeaderLabel.ForeColor = Color.White;
            zeroStockHeaderLabel.Location = new Point(0, 0);
            zeroStockHeaderLabel.Name = "zeroStockHeaderLabel";
            zeroStockHeaderLabel.Size = new Size(864, 50);
            zeroStockHeaderLabel.TabIndex = 0;
            zeroStockHeaderLabel.Text = "WARNING: PRODUCTS OUT OF STOCK";
            zeroStockHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lowStockTabPage
            // 
            lowStockTabPage.Controls.Add(lowStockPanel);
            lowStockTabPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lowStockTabPage.ForeColor = Color.FromArgb(255, 193, 7);
            lowStockTabPage.Location = new Point(4, 34);
            lowStockTabPage.Name = "lowStockTabPage";
            lowStockTabPage.Padding = new Padding(3);
            lowStockTabPage.Size = new Size(870, 396);
            lowStockTabPage.TabIndex = 1;
            lowStockTabPage.Text = "⚠️ Low Stock Products";
            lowStockTabPage.UseVisualStyleBackColor = true;
            // 
            // lowStockPanel
            // 
            lowStockPanel.Controls.Add(lowStockDataGridView);
            lowStockPanel.Controls.Add(lowStockCountLabel);
            lowStockPanel.Controls.Add(lowStockHeaderPanel);
            lowStockPanel.Dock = DockStyle.Fill;
            lowStockPanel.Location = new Point(3, 3);
            lowStockPanel.Name = "lowStockPanel";
            lowStockPanel.Size = new Size(864, 390);
            lowStockPanel.TabIndex = 1;
            // 
            // lowStockDataGridView
            // 
            lowStockDataGridView.AllowUserToAddRows = false;
            lowStockDataGridView.AllowUserToDeleteRows = false;
            lowStockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lowStockDataGridView.BackgroundColor = Color.White;
            lowStockDataGridView.BorderStyle = BorderStyle.None;
            lowStockDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowStockDataGridView.Dock = DockStyle.Fill;
            lowStockDataGridView.Location = new Point(0, 84);
            lowStockDataGridView.Name = "lowStockDataGridView";
            lowStockDataGridView.ReadOnly = true;
            lowStockDataGridView.RowHeadersVisible = false;
            lowStockDataGridView.RowHeadersWidth = 51;
            lowStockDataGridView.RowTemplate.Height = 35;
            lowStockDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lowStockDataGridView.Size = new Size(864, 306);
            lowStockDataGridView.TabIndex = 2;
            // 
            // lowStockCountLabel
            // 
            lowStockCountLabel.BackColor = Color.FromArgb(255, 243, 205);
            lowStockCountLabel.Dock = DockStyle.Top;
            lowStockCountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lowStockCountLabel.ForeColor = Color.FromArgb(133, 100, 4);
            lowStockCountLabel.Location = new Point(0, 50);
            lowStockCountLabel.Name = "lowStockCountLabel";
            lowStockCountLabel.Padding = new Padding(10, 0, 0, 0);
            lowStockCountLabel.Size = new Size(864, 34);
            lowStockCountLabel.TabIndex = 1;
            lowStockCountLabel.Text = "No products with low stock";
            lowStockCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lowStockHeaderPanel
            // 
            lowStockHeaderPanel.BackColor = Color.FromArgb(255, 193, 7);
            lowStockHeaderPanel.Controls.Add(lowStockHeaderLabel);
            lowStockHeaderPanel.Dock = DockStyle.Top;
            lowStockHeaderPanel.Location = new Point(0, 0);
            lowStockHeaderPanel.Name = "lowStockHeaderPanel";
            lowStockHeaderPanel.Size = new Size(864, 50);
            lowStockHeaderPanel.TabIndex = 0;
            // 
            // lowStockHeaderLabel
            // 
            lowStockHeaderLabel.Dock = DockStyle.Fill;
            lowStockHeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lowStockHeaderLabel.ForeColor = Color.White;
            lowStockHeaderLabel.Location = new Point(0, 0);
            lowStockHeaderLabel.Name = "lowStockHeaderLabel";
            lowStockHeaderLabel.Size = new Size(864, 50);
            lowStockHeaderLabel.TabIndex = 0;
            lowStockHeaderLabel.Text = "WARNING: LOW STOCK PRODUCTS";
            lowStockHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(BackToDashboardButton);
            footerPanel.Controls.Add(refreshButton);
            footerPanel.Dock = DockStyle.Fill;
            footerPanel.Location = new Point(18, 528);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(878, 54);
            footerPanel.TabIndex = 6;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            BackToDashboardButton.AutoSize = true;
            BackToDashboardButton.BackColor = Color.FromArgb(13, 110, 253);
            BackToDashboardButton.FlatAppearance.BorderSize = 0;
            BackToDashboardButton.FlatStyle = FlatStyle.Flat;
            BackToDashboardButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            BackToDashboardButton.Location = new Point(638, 2);
            BackToDashboardButton.Margin = new Padding(3, 2, 3, 2);
            BackToDashboardButton.MinimumSize = new Size(0, 44);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(237, 50);
            BackToDashboardButton.TabIndex = 1;
            BackToDashboardButton.Text = "Back to Dashboard";
            BackToDashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.AutoSize = true;
            refreshButton.BackColor = Color.FromArgb(40, 167, 69);
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(3, 2);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.MinimumSize = new Size(0, 44);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(175, 50);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "🔄 Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // AlertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(800, 600);
            Name = "AlertForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notification Center";
            Load += AlertForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            zeroStockTabPage.ResumeLayout(false);
            zeroStockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)zeroStockDataGridView).EndInit();
            zeroStockHeaderPanel.ResumeLayout(false);
            lowStockTabPage.ResumeLayout(false);
            lowStockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lowStockDataGridView).EndInit();
            lowStockHeaderPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zeroStockBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowStockBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel headerPanel;
        private Label headerLabel;
        private TabControl tabControl;
        private TabPage zeroStockTabPage;
        private TabPage lowStockTabPage;
        private Panel zeroStockPanel;
        private DataGridView zeroStockDataGridView;
        private Label zeroStockCountLabel;
        private Panel zeroStockHeaderPanel;
        private Label zeroStockHeaderLabel;
        private Panel lowStockPanel;
        private DataGridView lowStockDataGridView;
        private Label lowStockCountLabel;
        private Panel lowStockHeaderPanel;
        private Label lowStockHeaderLabel;
        private Panel footerPanel;
        private Button BackToDashboardButton;
        private Button refreshButton;
        private BindingSource zeroStockBindingSource;
        private BindingSource lowStockBindingSource;
    }
}