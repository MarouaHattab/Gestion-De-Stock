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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            stockOutBindingSource = new BindingSource(components);
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            notesLabel = new Label();
            notesTextBox = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exitDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockOutBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.625F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.11111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.8888855F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(notesTextBox);
            groupBox1.Controls.Add(notesLabel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 106);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(390, 490);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "StockOut";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Tag", stockOutBindingSource, "Destination", true));
            textBox3.Location = new Point(150, 296);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 7;
            // 
            // stockOutBindingSource
            // 
            stockOutBindingSource.DataSource = typeof(Data.Entites.StockOut);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 300);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "Destination";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new Point(33, 360);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(48, 20);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            notesTextBox.DataBindings.Add(new Binding("Tag", stockOutBindingSource, "Notes", true));
            notesTextBox.Location = new Point(150, 360);
            notesTextBox.Margin = new Padding(3, 4, 3, 4);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(215, 80);
            notesTextBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Tag", stockOutBindingSource, "ExitDate", true));
            dateTimePicker1.Location = new Point(150, 207);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 215);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Exit Date";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Tag", stockOutBindingSource, "Quantity", true));
            textBox2.Location = new Point(150, 120);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 128);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("Tag", stockOutBindingSource, "Product", true));
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 49);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Highlight;
            textBox1.Location = new Point(399, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(512, 94);
            textBox1.TabIndex = 2;
            textBox1.Text = "    StockOut Dashboard";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(390, 94);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 
                quantityDataGridViewTextBoxColumn, 
                exitDateDataGridViewTextBoxColumn, 
                destinationDataGridViewTextBoxColumn, 
                notesDataGridViewTextBoxColumn,
                productDataGridViewTextBoxColumn 
            });
            dataGridView1.DataSource = stockOutBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(399, 106);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(512, 490);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // exitDateDataGridViewTextBoxColumn
            // 
            exitDateDataGridViewTextBoxColumn.DataPropertyName = "ExitDate";
            exitDateDataGridViewTextBoxColumn.HeaderText = "ExitDate";
            exitDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            exitDateDataGridViewTextBoxColumn.Name = "exitDateDataGridViewTextBoxColumn";
            exitDateDataGridViewTextBoxColumn.ReadOnly = true;
            exitDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            destinationDataGridViewTextBoxColumn.ReadOnly = true;
            destinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.ReadOnly = true;
            productDataGridViewTextBoxColumn.Width = 125;
            // 
            // StockOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StockOutForm";
            Text = "StockOutForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockOutBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exitDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private BindingSource stockOutBindingSource;
        private Label notesLabel;
        private TextBox notesTextBox;
    }
}