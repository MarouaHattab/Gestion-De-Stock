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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonOK = new Button();
            buttonCancel = new Button();
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
            ProductDetailsFormbutton = new Button();
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
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(Product, 0, 1);
            tableLayoutPanel1.Controls.Add(ProductDetailsFormbutton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7931023F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.0306549F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.1762409F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonOK);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 517);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(908, 80);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Image = (Image)resources.GetObject("buttonOK.Image");
            buttonOK.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOK.Location = new Point(766, 3);
            buttonOK.MinimumSize = new Size(0, 59);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(139, 72);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "Valider";
            buttonOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(613, 3);
            buttonCancel.MinimumSize = new Size(0, 59);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(147, 72);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Annuler";
            buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            Product.Controls.Add(tableLayoutPanel2);
            Product.Dock = DockStyle.Fill;
            Product.Location = new Point(3, 85);
            Product.Name = "Product";
            Product.Size = new Size(908, 426);
            Product.TabIndex = 2;
            Product.TabStop = false;
            Product.Text = "Product";
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
            tableLayoutPanel2.Location = new Point(101, 28);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.Size = new Size(711, 383);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Tag", productBindingSource, "Category", true));
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(145, 340);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(563, 27);
            textBox7.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Tag", productBindingSource, "Name", true));
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(145, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(563, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Tag", productBindingSource, "Quantity", true));
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(145, 60);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(563, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Tag", productBindingSource, "PurchasePrice", true));
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(145, 116);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(563, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Tag", productBindingSource, "SalePrice", true));
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(145, 172);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(563, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Tag", productBindingSource, "AlertThreshold", true));
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(145, 228);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(563, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Tag", productBindingSource, "Description", true));
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(145, 284);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(563, 27);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 56);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 112);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 8;
            label3.Text = "PurchasePrice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 168);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "SalePrice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 224);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 10;
            label5.Text = "AlertThreshold";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 280);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 11;
            label6.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 336);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 12;
            label7.Text = "Category";
            // 
            // ProductDetailsFormbutton
            // 
            ProductDetailsFormbutton.Dock = DockStyle.Fill;
            ProductDetailsFormbutton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDetailsFormbutton.ForeColor = SystemColors.Highlight;
            ProductDetailsFormbutton.Image = (Image)resources.GetObject("ProductDetailsFormbutton.Image");
            ProductDetailsFormbutton.ImageAlign = ContentAlignment.MiddleLeft;
            ProductDetailsFormbutton.Location = new Point(3, 4);
            ProductDetailsFormbutton.Margin = new Padding(3, 4, 3, 4);
            ProductDetailsFormbutton.Name = "ProductDetailsFormbutton";
            ProductDetailsFormbutton.Size = new Size(908, 74);
            ProductDetailsFormbutton.TabIndex = 4;
            ProductDetailsFormbutton.Text = "Product Details Dashboard";
            ProductDetailsFormbutton.UseVisualStyleBackColor = true;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
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