namespace GestionDeStock.StockOutForm
{
    partial class StockOutForm
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
            ReloadButton = new Button();
            BackToDashboardButton = new Button();
            dataGridView1 = new DataGridView();
            stockOutDetailsPanel = new Panel();
            stockOutDetailsGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            productLabel = new Label();
            comboBox1 = new ComboBox();
            quantityLabel = new Label();
            textBox2 = new TextBox();
            exitDateLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            destinationLabel = new Label();
            textBox3 = new TextBox();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            actionButtonsPanel = new Panel();
            saveButton = new Button();
            cancelButton = new Button();
            stockOutBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            headerPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            stockOutDetailsPanel.SuspendLayout();
            stockOutDetailsGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            actionButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockOutBindingSource).BeginInit();
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
            tableLayoutPanel1.Controls.Add(stockOutDetailsPanel, 0, 2);
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
            headerLabel.Text = "Stock Out Management";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            flowLayoutPanel1.Size = new Size(224, 297);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(40, 167, 69);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(13, 14);
            AddButton.Margin = new Padding(3, 4, 3, 15);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 45);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add New";
            AddButton.TextAlign = ContentAlignment.MiddleCenter;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += button1_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(0, 123, 255);
            UpdateButton.Enabled = false;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(13, 78);
            UpdateButton.Margin = new Padding(3, 4, 3, 15);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(200, 45);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.MiddleCenter;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(220, 53, 69);
            DeleteButton.Enabled = false;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteButton.Location = new Point(13, 142);
            DeleteButton.Margin = new Padding(3, 4, 3, 15);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 45);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.TextAlign = ContentAlignment.MiddleCenter;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.BackColor = Color.FromArgb(108, 117, 125);
            ReloadButton.FlatAppearance.BorderSize = 0;
            ReloadButton.FlatStyle = FlatStyle.Flat;
            ReloadButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReloadButton.ForeColor = Color.White;
            ReloadButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReloadButton.Location = new Point(13, 206);
            ReloadButton.Margin = new Padding(3, 4, 3, 15);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(200, 45);
            ReloadButton.TabIndex = 3;
            ReloadButton.Text = "Reload";
            ReloadButton.TextAlign = ContentAlignment.MiddleCenter;
            ReloadButton.UseVisualStyleBackColor = false;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // BackToDashboardButton
            // 
            BackToDashboardButton.BackColor = Color.FromArgb(52, 58, 64);
            BackToDashboardButton.FlatAppearance.BorderSize = 0;
            BackToDashboardButton.FlatStyle = FlatStyle.Flat;
            BackToDashboardButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackToDashboardButton.ForeColor = Color.White;
            BackToDashboardButton.Location = new Point(13, 270);
            BackToDashboardButton.Margin = new Padding(3, 4, 3, 15);
            BackToDashboardButton.Name = "BackToDashboardButton";
            BackToDashboardButton.Size = new Size(200, 45);
            BackToDashboardButton.TabIndex = 4;
            BackToDashboardButton.Text = "Back to Dashboard";
            BackToDashboardButton.UseVisualStyleBackColor = false;
            BackToDashboardButton.Click += BackToDashboardButton_Click;
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
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // stockOutDetailsPanel
            // 
            stockOutDetailsPanel.Controls.Add(stockOutDetailsGroupBox);
            stockOutDetailsPanel.Dock = DockStyle.Fill;
            stockOutDetailsPanel.Location = new Point(13, 389);
            stockOutDetailsPanel.Margin = new Padding(3, 4, 3, 4);
            stockOutDetailsPanel.Name = "stockOutDetailsPanel";
            stockOutDetailsPanel.Size = new Size(224, 297);
            stockOutDetailsPanel.TabIndex = 3;
            // 
            // stockOutDetailsGroupBox
            // 
            stockOutDetailsGroupBox.Controls.Add(tableLayoutPanel2);
            stockOutDetailsGroupBox.Controls.Add(actionButtonsPanel);
            stockOutDetailsGroupBox.Dock = DockStyle.Fill;
            stockOutDetailsGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockOutDetailsGroupBox.ForeColor = Color.FromArgb(45, 52, 64);
            stockOutDetailsGroupBox.Location = new Point(0, 0);
            stockOutDetailsGroupBox.Margin = new Padding(3, 4, 3, 4);
            stockOutDetailsGroupBox.Name = "stockOutDetailsGroupBox";
            stockOutDetailsGroupBox.Padding = new Padding(3, 4, 3, 4);
            stockOutDetailsGroupBox.Size = new Size(224, 297);
            stockOutDetailsGroupBox.TabIndex = 0;
            stockOutDetailsGroupBox.TabStop = false;
            stockOutDetailsGroupBox.Text = "Stock Out Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(productLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(quantityLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox2, 0, 3);
            tableLayoutPanel2.Controls.Add(exitDateLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 0, 5);
            tableLayoutPanel2.Controls.Add(destinationLabel, 0, 6);
            tableLayoutPanel2.Controls.Add(textBox3, 0, 7);
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
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(3, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 3;
            // 
            // exitDateLabel
            // 
            exitDateLabel.AutoSize = true;
            exitDateLabel.Dock = DockStyle.Fill;
            exitDateLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitDateLabel.Location = new Point(3, 96);
            exitDateLabel.Name = "exitDateLabel";
            exitDateLabel.Size = new Size(212, 18);
            exitDateLabel.TabIndex = 4;
            exitDateLabel.Text = "Exit Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(3, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Dock = DockStyle.Fill;
            destinationLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            destinationLabel.Location = new Point(3, 144);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(212, 18);
            destinationLabel.TabIndex = 6;
            destinationLabel.Text = "Destination:";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(3, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 27);
            textBox3.TabIndex = 7;
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
            notesTextBox.MinimumSize = new Size(0, 40);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(212, 40);
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
            // stockOutBindingSource
            // 
            stockOutBindingSource.DataSource = typeof(Data.Entites.StockOut);
            // 
            // StockOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1000, 700);
            Name = "StockOutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Out Management";
            tableLayoutPanel1.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            stockOutDetailsPanel.ResumeLayout(false);
            stockOutDetailsGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            actionButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stockOutBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource stockOutBindingSource;
        private Panel headerPanel;
        private Label headerLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ReloadButton;
        private Button BackToDashboardButton;
        private DataGridView dataGridView1;
        private Panel stockOutDetailsPanel;
        private GroupBox stockOutDetailsGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label productLabel;
        private ComboBox comboBox1;
        private Label quantityLabel;
        private TextBox textBox2;
        private Label exitDateLabel;
        private DateTimePicker dateTimePicker1;
        private Label destinationLabel;
        private TextBox textBox3;
        private Label notesLabel;
        private TextBox notesTextBox;
        private Panel actionButtonsPanel;
        private Button saveButton;
        private Button cancelButton;
    }
}