namespace GestionDeStock.CategoryForm
{
    partial class Category_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Form));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ReloadButton = new Button();
            BackToDashboardButton = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            headerPanel = new Panel();
            headerLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(headerPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(AddButton);
            flowLayoutPanel1.Controls.Add(UpdateButton);
            flowLayoutPanel1.Controls.Add(DeleteButton);
            flowLayoutPanel1.Controls.Add(ReloadButton);
            flowLayoutPanel1.Controls.Add(BackToDashboardButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(13, 84);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(224, 502);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(40, 167, 69);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(13, 14);
            AddButton.Margin = new Padding(3, 4, 3, 15);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 60);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.TextAlign = ContentAlignment.MiddleRight;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(0, 123, 255);
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Image = (Image)resources.GetObject("UpdateButton.Image");
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(13, 93);
            UpdateButton.Margin = new Padding(3, 4, 3, 15);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(200, 60);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.MiddleRight;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(220, 53, 69);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteButton.Location = new Point(13, 172);
            DeleteButton.Margin = new Padding(3, 4, 3, 15);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 60);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.TextAlign = ContentAlignment.MiddleRight;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReloadButton
            // 
            ReloadButton.BackColor = Color.FromArgb(108, 117, 125);
            ReloadButton.FlatAppearance.BorderSize = 0;
            ReloadButton.FlatStyle = FlatStyle.Flat;
            ReloadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReloadButton.ForeColor = Color.White;
            ReloadButton.Image = (Image)resources.GetObject("ReloadButton.Image");
            ReloadButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReloadButton.Location = new Point(13, 251);
            ReloadButton.Margin = new Padding(3, 4, 3, 15);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(200, 60);
            ReloadButton.TabIndex = 4;
            ReloadButton.Text = "Reload";
            ReloadButton.TextAlign = ContentAlignment.MiddleRight;
            ReloadButton.UseVisualStyleBackColor = false;
            ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click_1);
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            BackToDashboardButton.BackColor = Color.FromArgb(52, 58, 64);
            BackToDashboardButton.FlatAppearance.BorderSize = 0;
            BackToDashboardButton.FlatStyle = FlatStyle.Flat;
            BackToDashboardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(13, 330);
            BackToDashboardButton.Margin = new Padding(3, 4, 3, 15);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(200, 60);
            BackToDashboardButton.TabIndex = 5;
            BackToDashboardButton.Text = "Back to Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += new System.EventHandler(this.BackToDashboardButton_Click);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.Location = new Point(247, 84);
            dataGridView1.Margin = new Padding(10, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(654, 502);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.FillWeight = 30F;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 100;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.FillWeight = 70F;
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.MinimumWidth = 150;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Data.Entites.Category);
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 122, 204);
            tableLayoutPanel1.SetColumnSpan(headerPanel, 2);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(13, 13);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(888, 64);
            headerPanel.TabIndex = 2;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(11, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(864, 46);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Categories Management";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Category_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(900, 600);
            Name = "Category_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories Management";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReloadButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button BackToDashboardButton;
        private Panel headerPanel;
        private Label headerLabel;
    }
}