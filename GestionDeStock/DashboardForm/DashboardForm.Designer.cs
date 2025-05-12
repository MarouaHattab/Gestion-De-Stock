namespace GestionDeStock.DashboardForm
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            LogOutButton = new Button();
            AlertButton = new Button();
            OutStockButton = new Button();
            InStockButton = new Button();
            StatisticsButton = new Button();
            ProductsButton = new Button();
            CategoryButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(LogOutButton, 0, 3);
            tableLayoutPanel1.Controls.Add(AlertButton, 2, 2);
            tableLayoutPanel1.Controls.Add(OutStockButton, 1, 2);
            tableLayoutPanel1.Controls.Add(InStockButton, 0, 2);
            tableLayoutPanel1.Controls.Add(StatisticsButton, 2, 1);
            tableLayoutPanel1.Controls.Add(ProductsButton, 1, 1);
            tableLayoutPanel1.Controls.Add(CategoryButton, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // LogOutButton
            // 
            LogOutButton.Dock = DockStyle.Fill;
            LogOutButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Image = (Image)resources.GetObject("LogOutButton.Image");
            LogOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutButton.Location = new Point(22, 437);
            LogOutButton.Margin = new Padding(11, 13, 11, 13);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(275, 137);
            LogOutButton.TabIndex = 16;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // AlertButton
            // 
            AlertButton.Dock = DockStyle.Fill;
            AlertButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlertButton.Image = (Image)resources.GetObject("AlertButton.Image");
            AlertButton.ImageAlign = ContentAlignment.MiddleLeft;
            AlertButton.Location = new Point(616, 277);
            AlertButton.Margin = new Padding(11, 13, 11, 13);
            AlertButton.Name = "AlertButton";
            AlertButton.Size = new Size(276, 134);
            AlertButton.TabIndex = 15;
            AlertButton.Text = "Alert";
            AlertButton.UseVisualStyleBackColor = true;
            AlertButton.Click += AlertButton_Click;
            // 
            // OutStockButton
            // 
            OutStockButton.Dock = DockStyle.Fill;
            OutStockButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutStockButton.Image = (Image)resources.GetObject("OutStockButton.Image");
            OutStockButton.ImageAlign = ContentAlignment.MiddleLeft;
            OutStockButton.Location = new Point(319, 277);
            OutStockButton.Margin = new Padding(11, 13, 11, 13);
            OutStockButton.Name = "OutStockButton";
            OutStockButton.Size = new Size(275, 134);
            OutStockButton.TabIndex = 14;
            OutStockButton.Text = "Stock Out";
            OutStockButton.UseVisualStyleBackColor = true;
            OutStockButton.Click += OutStockButton_Click;
            // 
            // InStockButton
            // 
            InStockButton.Dock = DockStyle.Fill;
            InStockButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockButton.Image = (Image)resources.GetObject("InStockButton.Image");
            InStockButton.ImageAlign = ContentAlignment.MiddleLeft;
            InStockButton.Location = new Point(22, 277);
            InStockButton.Margin = new Padding(11, 13, 11, 13);
            InStockButton.Name = "InStockButton";
            InStockButton.Size = new Size(275, 134);
            InStockButton.TabIndex = 13;
            InStockButton.Text = "Stock In";
            InStockButton.UseVisualStyleBackColor = true;
            InStockButton.Click += InStockButton_Click;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Dock = DockStyle.Fill;
            StatisticsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatisticsButton.Image = (Image)resources.GetObject("StatisticsButton.Image");
            StatisticsButton.ImageAlign = ContentAlignment.MiddleLeft;
            StatisticsButton.Location = new Point(616, 117);
            StatisticsButton.Margin = new Padding(11, 13, 11, 13);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(276, 134);
            StatisticsButton.TabIndex = 12;
            StatisticsButton.Text = "Statistics";
            StatisticsButton.UseVisualStyleBackColor = true;
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Dock = DockStyle.Fill;
            ProductsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsButton.Image = (Image)resources.GetObject("ProductsButton.Image");
            ProductsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProductsButton.Location = new Point(319, 117);
            ProductsButton.Margin = new Padding(11, 13, 11, 13);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(275, 134);
            ProductsButton.TabIndex = 11;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // CategoryButton
            // 
            CategoryButton.Dock = DockStyle.Fill;
            CategoryButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryButton.Image = Properties.Resources.categories;
            CategoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            CategoryButton.Location = new Point(22, 117);
            CategoryButton.Margin = new Padding(11, 13, 11, 13);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(275, 134);
            CategoryButton.TabIndex = 10;
            CategoryButton.Text = "Category";
            CategoryButton.UseVisualStyleBackColor = true;
            CategoryButton.Click += CategoryButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 122, 204);
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 3);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.ForeColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.Location = new Point(22, 26);
            flowLayoutPanel1.Margin = new Padding(11, 13, 11, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(870, 65);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 13);
            label1.Margin = new Padding(11, 13, 11, 0);
            label1.Name = "label1";
            label1.Size = new Size(624, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Stock Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 584);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Stock Management System";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button LogOutButton;
        private Button AlertButton;
        private Button OutStockButton;
        private Button InStockButton;
        private Button StatisticsButton;
        private Button ProductsButton;
        private Button CategoryButton;
        private Label label1;
    }
}