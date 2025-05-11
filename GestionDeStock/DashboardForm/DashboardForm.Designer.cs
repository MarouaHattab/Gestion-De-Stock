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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 283F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F));
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // LogOutButton
            // 
            LogOutButton.Dock = DockStyle.Fill;
            LogOutButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutButton.Image = (Image)resources.GetObject("LogOutButton.Image");
            LogOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutButton.Location = new Point(3, 341);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(256, 106);
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
            AlertButton.Location = new Point(548, 216);
            AlertButton.Name = "AlertButton";
            AlertButton.Size = new Size(249, 119);
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
            OutStockButton.Location = new Point(265, 216);
            OutStockButton.Name = "OutStockButton";
            OutStockButton.Size = new Size(277, 119);
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
            InStockButton.Location = new Point(3, 216);
            InStockButton.Name = "InStockButton";
            InStockButton.Size = new Size(256, 119);
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
            StatisticsButton.Location = new Point(548, 84);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(249, 126);
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
            ProductsButton.Location = new Point(265, 84);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(277, 126);
            ProductsButton.TabIndex = 11;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // CategoryButton
            // 
            CategoryButton.Dock = DockStyle.Fill;
            CategoryButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            CategoryButton.Location = new Point(3, 84);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(256, 126);
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
            flowLayoutPanel1.ForeColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 75);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(683, 50);
            label1.TabIndex = 0;
            label1.Text = "         Weclome to Stock Management";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
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