namespace GestionDeStock.StockInForm
{
    partial class StockInForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            headerPanel = new Panel();
            headerLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            BackToDashboardButton = new Button();
            ReloadButton = new Button();
            dataGridView1 = new DataGridView();
            stockInDetailsPanel = new Panel();
            stockInDetailsGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            productLabel = new Label();
            productComboBox = new ComboBox();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            entryDateLabel = new Label();
            entryDatePicker = new DateTimePicker();
            supplierLabel = new Label();
            supplierTextBox = new TextBox();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            actionButtonsPanel = new Panel();
            saveButton = new Button();
            cancelButton = new Button();
            stockInBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            headerPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            stockInDetailsPanel.SuspendLayout();
            stockInDetailsGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockInBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(headerPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(stockInDetailsPanel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(0, 122, 204);
            tableLayoutPanel1.SetColumnSpan(headerPanel, 2);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(13, 13);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(974, 64);
            headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(11, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(950, 46);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Stock In Management";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(AddButton);
            flowLayoutPanel1.Controls.Add(UpdateButton);
            flowLayoutPanel1.Controls.Add(DeleteButton);
            flowLayoutPanel1.Controls.Add(BackToDashboardButton);
            flowLayoutPanel1.Controls.Add(ReloadButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(13, 84);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(224, 297);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(40, 167, 69);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Image = Properties.Resources.add_icon;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(13, 14);
            AddButton.Margin = new Padding(3, 4, 3, 15);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 45);
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
            UpdateButton.Image = Properties.Resources.pencil_small_icon;
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(13, 78);
            UpdateButton.Margin = new Padding(3, 4, 3, 15);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(200, 45);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.MiddleRight;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(220, 53, 69);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Image = Properties.Resources.cancel_icon11;
            DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteButton.Location = new Point(13, 142);
            DeleteButton.Margin = new Padding(3, 4, 3, 15);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 45);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.TextAlign = ContentAlignment.MiddleRight;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackToDashboardButton.BackColor = Color.FromArgb(52, 58, 64);
            BackToDashboardButton.FlatAppearance.BorderSize = 0;
            BackToDashboardButton.FlatStyle = FlatStyle.Flat;
            BackToDashboardButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(13, 206);
            BackToDashboardButton.Margin = new Padding(3, 4, 3, 15);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(200, 45);
            BackToDashboardButton.TabIndex = 4;
            BackToDashboardButton.Text = "Back to Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.BackColor = Color.FromArgb(108, 117, 125);
            ReloadButton.FlatAppearance.BorderSize = 0;
            ReloadButton.FlatStyle = FlatStyle.Flat;
            ReloadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReloadButton.ForeColor = Color.White;
            ReloadButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReloadButton.Location = new Point(219, 14);
            ReloadButton.Margin = new Padding(3, 4, 3, 15);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(200, 45);
            ReloadButton.TabIndex = 3;
            ReloadButton.Text = "Reload";
            ReloadButton.TextAlign = ContentAlignment.MiddleRight;
            ReloadButton.UseVisualStyleBackColor = false;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.Location = new Point(250, 84);
            dataGridView1.Margin = new Padding(10, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 2);
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(737, 602);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            // 
            // stockInDetailsPanel
            // 
            stockInDetailsPanel.Controls.Add(stockInDetailsGroupBox);
            stockInDetailsPanel.Dock = DockStyle.Fill;
            stockInDetailsPanel.Location = new Point(13, 389);
            stockInDetailsPanel.Margin = new Padding(3, 4, 3, 4);
            stockInDetailsPanel.Name = "stockInDetailsPanel";
            stockInDetailsPanel.Size = new Size(224, 297);
            stockInDetailsPanel.TabIndex = 3;
            // 
            // stockInDetailsGroupBox
            // 
            stockInDetailsGroupBox.Controls.Add(tableLayoutPanel2);
            stockInDetailsGroupBox.Controls.Add(actionButtonsPanel);
            stockInDetailsGroupBox.Dock = DockStyle.Fill;
            stockInDetailsGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockInDetailsGroupBox.ForeColor = Color.FromArgb(45, 52, 64);
            stockInDetailsGroupBox.Location = new Point(0, 0);
            stockInDetailsGroupBox.Margin = new Padding(3, 4, 3, 4);
            stockInDetailsGroupBox.Name = "stockInDetailsGroupBox";
            stockInDetailsGroupBox.Padding = new Padding(3, 4, 3, 4);
            stockInDetailsGroupBox.Size = new Size(224, 297);
            stockInDetailsGroupBox.TabIndex = 0;
            stockInDetailsGroupBox.TabStop = false;
            stockInDetailsGroupBox.Text = "Stock In Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(productLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(productComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(quantityLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(quantityTextBox, 0, 3);
            tableLayoutPanel2.Controls.Add(entryDateLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(entryDatePicker, 0, 5);
            tableLayoutPanel2.Controls.Add(supplierLabel, 0, 6);
            tableLayoutPanel2.Controls.Add(supplierTextBox, 0, 7);
            tableLayoutPanel2.Controls.Add(notesLabel, 0, 8);
            tableLayoutPanel2.Controls.Add(notesTextBox, 0, 9);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(218, 226);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Dock = DockStyle.Fill;
            productLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLabel.Location = new Point(3, 0);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(212, 18);
            productLabel.TabIndex = 0;
            productLabel.Text = "Product:";
            // 
            // productComboBox
            // 
            productComboBox.Dock = DockStyle.Fill;
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(3, 21);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(212, 28);
            productComboBox.TabIndex = 1;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Dock = DockStyle.Fill;
            quantityLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(3, 48);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(212, 18);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Dock = DockStyle.Fill;
            quantityTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityTextBox.Location = new Point(3, 69);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(212, 27);
            quantityTextBox.TabIndex = 3;
            // 
            // entryDateLabel
            // 
            entryDateLabel.AutoSize = true;
            entryDateLabel.Dock = DockStyle.Fill;
            entryDateLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryDateLabel.Location = new Point(3, 96);
            entryDateLabel.Name = "entryDateLabel";
            entryDateLabel.Size = new Size(212, 18);
            entryDateLabel.TabIndex = 4;
            entryDateLabel.Text = "Entry Date:";
            // 
            // entryDatePicker
            // 
            entryDatePicker.Dock = DockStyle.Fill;
            entryDatePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryDatePicker.Format = DateTimePickerFormat.Short;
            entryDatePicker.Location = new Point(3, 117);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(212, 27);
            entryDatePicker.TabIndex = 5;
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Dock = DockStyle.Fill;
            supplierLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierLabel.Location = new Point(3, 144);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new Size(212, 18);
            supplierLabel.TabIndex = 6;
            supplierLabel.Text = "Supplier:";
            // 
            // supplierTextBox
            // 
            supplierTextBox.Dock = DockStyle.Fill;
            supplierTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplierTextBox.Location = new Point(3, 165);
            supplierTextBox.Name = "supplierTextBox";
            supplierTextBox.Size = new Size(212, 27);
            supplierTextBox.TabIndex = 7;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Dock = DockStyle.Fill;
            notesLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notesLabel.Location = new Point(3, 192);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(212, 18);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            notesTextBox.Dock = DockStyle.Fill;
            notesTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notesTextBox.Location = new Point(3, 213);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(212, 10);
            notesTextBox.TabIndex = 9;
            // 
            // actionButtonsPanel
            // 
            actionButtonsPanel.Controls.Add(saveButton);
            actionButtonsPanel.Controls.Add(cancelButton);
            actionButtonsPanel.Dock = DockStyle.Bottom;
            actionButtonsPanel.Location = new Point(3, 253);
            actionButtonsPanel.Name = "actionButtonsPanel";
            actionButtonsPanel.Size = new Size(218, 40);
            actionButtonsPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(40, 167, 69);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(6, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 30);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(220, 53, 69);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(115, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 30);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // StockInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1000, 700);
            Name = "StockInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock In Management";
            Load += StockInForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            stockInDetailsPanel.ResumeLayout(false);
            stockInDetailsGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            actionButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stockInBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel headerPanel;
        private Label headerLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReloadButton;
        private Button BackToDashboardButton;
        private DataGridView dataGridView1;
        private Panel stockInDetailsPanel;
        private GroupBox stockInDetailsGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label productLabel;
        private ComboBox productComboBox;
        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Label entryDateLabel;
        private DateTimePicker entryDatePicker;
        private Label supplierLabel;
        private TextBox supplierTextBox;
        private Label notesLabel;
        private TextBox notesTextBox;
        private Panel actionButtonsPanel;
        private Button saveButton;
        private Button cancelButton;
        private BindingSource stockInBindingSource;
        private BindingSource productBindingSource;
    }
}