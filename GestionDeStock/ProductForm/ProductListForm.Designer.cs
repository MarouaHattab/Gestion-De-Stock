namespace GestionDeStock.ProductForm
{
    partial class ProductListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ReloadButton = new Button();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purchasePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alertThresholdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockInsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockOutsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 594F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AddButton);
            flowLayoutPanel1.Controls.Add(UpdateButton);
            flowLayoutPanel1.Controls.Add(DeleteButton);
            flowLayoutPanel1.Controls.Add(ReloadButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 444);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(197, 67);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.Image = (Image)resources.GetObject("UpdateButton.Image");
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(3, 76);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(197, 67);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteButton.Location = new Point(3, 149);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(197, 67);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReloadButton.Image = (Image)resources.GetObject("ReloadButton.Image");
            ReloadButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReloadButton.Location = new Point(3, 222);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(197, 67);
            ReloadButton.TabIndex = 4;
            ReloadButton.Text = "Reload";
            ReloadButton.UseVisualStyleBackColor = true;
            ReloadButton.Click += ReloadButton_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, purchasePriceDataGridViewTextBoxColumn, salePriceDataGridViewTextBoxColumn, alertThresholdDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, stockInsDataGridViewTextBoxColumn, stockOutsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(209, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(588, 444);
            dataGridView1.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alertThresholdDataGridViewTextBoxColumn
            // 
            alertThresholdDataGridViewTextBoxColumn.DataPropertyName = "AlertThreshold";
            alertThresholdDataGridViewTextBoxColumn.HeaderText = "AlertThreshold";
            alertThresholdDataGridViewTextBoxColumn.Name = "alertThresholdDataGridViewTextBoxColumn";
            alertThresholdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockInsDataGridViewTextBoxColumn
            // 
            stockInsDataGridViewTextBoxColumn.DataPropertyName = "StockIns";
            stockInsDataGridViewTextBoxColumn.HeaderText = "StockIns";
            stockInsDataGridViewTextBoxColumn.Name = "stockInsDataGridViewTextBoxColumn";
            stockInsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockOutsDataGridViewTextBoxColumn
            // 
            stockOutsDataGridViewTextBoxColumn.DataPropertyName = "StockOuts";
            stockOutsDataGridViewTextBoxColumn.HeaderText = "StockOuts";
            stockOutsDataGridViewTextBoxColumn.Name = "stockOutsDataGridViewTextBoxColumn";
            stockOutsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Data.Entites.Product);
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductListForm";
            Text = "ProductListForm";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReloadButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alertThresholdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockInsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockOutsDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
    }
}