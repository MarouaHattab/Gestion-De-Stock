namespace GestionDeStock.ProductForm
{
    partial class ProductDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            ProductDetailsFormbutton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonOK = new Button();
            Product = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox7 = new TextBox();
            productBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            Product.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ProductDetailsFormbutton, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(Product, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ProductDetailsFormbutton
            // 
            ProductDetailsFormbutton.BackColor = Color.FromArgb(0, 122, 204);
            ProductDetailsFormbutton.Dock = DockStyle.Fill;
            ProductDetailsFormbutton.FlatAppearance.BorderSize = 0;
            ProductDetailsFormbutton.FlatStyle = FlatStyle.Flat;
            ProductDetailsFormbutton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDetailsFormbutton.ForeColor = Color.White;
            ProductDetailsFormbutton.Image = (Image)resources.GetObject("ProductDetailsFormbutton.Image");
            ProductDetailsFormbutton.ImageAlign = ContentAlignment.MiddleLeft;
            ProductDetailsFormbutton.Location = new Point(18, 18);
            ProductDetailsFormbutton.Name = "ProductDetailsFormbutton";
            ProductDetailsFormbutton.Padding = new Padding(10, 0, 0, 0);
            ProductDetailsFormbutton.Size = new Size(878, 64);
            ProductDetailsFormbutton.TabIndex = 4;
            ProductDetailsFormbutton.Text = "Product Details";
            ProductDetailsFormbutton.TextAlign = ContentAlignment.MiddleLeft;
            ProductDetailsFormbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProductDetailsFormbutton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonOK);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(18, 518);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(878, 64);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.BackColor = Color.FromArgb(220, 53, 69);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Image = Properties.Resources.cancel_icon1;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(735, 12);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.MinimumSize = new Size(0, 44);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 54);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.BackColor = Color.FromArgb(40, 167, 69);
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.ForeColor = Color.White;
            buttonOK.Image = Properties.Resources.tick_icon;
            buttonOK.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOK.Location = new Point(617, 12);
            buttonOK.Margin = new Padding(3, 2, 10, 2);
            buttonOK.MinimumSize = new Size(0, 44);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(105, 54);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "Save";
            buttonOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // Product
            // 
            Product.Controls.Add(tableLayoutPanel2);
            Product.Dock = DockStyle.Fill;
            Product.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product.ForeColor = Color.FromArgb(45, 52, 64);
            Product.Location = new Point(18, 90);
            Product.Margin = new Padding(3, 5, 3, 5);
            Product.Name = "Product";
            Product.Padding = new Padding(20);
            Product.Size = new Size(878, 420);
            Product.TabIndex = 2;
            Product.TabStop = false;
            Product.Text = "Product Information";
            Product.Enter += Product_Enter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(textBox7, 1, 6);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel2.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 44);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.32F));
            tableLayoutPanel2.Size = new Size(838, 356);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", productBindingSource, "CategoryId", true));
            textBox7.Dock = DockStyle.Fill;
            textBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(170, 304);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(665, 30);
            textBox7.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.DataBindings.Add(new Binding("Text", productBindingSource, "Name", true));
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(170, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(665, 30);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.DataBindings.Add(new Binding("Text", productBindingSource, "Quantity", true));
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(170, 54);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(665, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.DataBindings.Add(new Binding("Text", productBindingSource, "PurchasePrice", true));
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(170, 104);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(665, 30);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.DataBindings.Add(new Binding("Text", productBindingSource, "SalePrice", true));
            textBox4.Dock = DockStyle.Fill;
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(170, 154);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(665, 30);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.DataBindings.Add(new Binding("Text", productBindingSource, "AlertThreshold", true));
            textBox5.Dock = DockStyle.Fill;
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(170, 204);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(665, 30);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.DataBindings.Add(new Binding("Text", productBindingSource, "Description", true));
            textBox6.Dock = DockStyle.Fill;
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(170, 254);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(665, 30);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 50);
            label1.TabIndex = 6;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(161, 50);
            label3.TabIndex = 8;
            label3.Text = "Purchase Price";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 150);
            label4.Name = "label4";
            label4.Size = new Size(161, 50);
            label4.TabIndex = 9;
            label4.Text = "Sale Price";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 200);
            label5.Name = "label5";
            label5.Size = new Size(161, 50);
            label5.TabIndex = 10;
            label5.Text = "Alert Threshold";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 250);
            label6.Name = "label6";
            label6.Size = new Size(161, 50);
            label6.TabIndex = 11;
            label6.Text = "Description";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(161, 50);
            label2.TabIndex = 7;
            label2.Text = "Quantity";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 300);
            label7.Name = "label7";
            label7.Size = new Size(161, 56);
            label7.TabIndex = 12;
            label7.Text = "Category";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "ProductDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            Load += ProductDetailsForm_Load;
            Resize += ProductDetailsForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            Product.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox Product;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonOK;
        private Button buttonCancel;
        private TextBox textBox7;
        private Label label7;
        private BindingSource productBindingSource;
        private Button ProductDetailsFormbutton;
    }
}