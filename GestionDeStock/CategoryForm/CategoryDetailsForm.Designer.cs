namespace GestionDeStock.CategoryForm
{
    partial class CategoryDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryDetailsForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            CategoryDetailsFormbutton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonOK = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            categoryBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(CategoryDetailsFormbutton, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(700, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CategoryDetailsFormbutton
            // 
            CategoryDetailsFormbutton.BackColor = Color.FromArgb(0, 122, 204);
            CategoryDetailsFormbutton.Dock = DockStyle.Fill;
            CategoryDetailsFormbutton.FlatAppearance.BorderSize = 0;
            CategoryDetailsFormbutton.FlatStyle = FlatStyle.Flat;
            CategoryDetailsFormbutton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDetailsFormbutton.ForeColor = Color.White;
            CategoryDetailsFormbutton.Image = (Image)resources.GetObject("CategoryDetailsFormbutton.Image");
            CategoryDetailsFormbutton.ImageAlign = ContentAlignment.MiddleLeft;
            CategoryDetailsFormbutton.Location = new Point(18, 18);
            CategoryDetailsFormbutton.Name = "CategoryDetailsFormbutton";
            CategoryDetailsFormbutton.Padding = new Padding(10, 0, 0, 0);
            CategoryDetailsFormbutton.Size = new Size(664, 64);
            CategoryDetailsFormbutton.TabIndex = 5;
            CategoryDetailsFormbutton.Text = "Category Details";
            CategoryDetailsFormbutton.TextAlign = ContentAlignment.MiddleLeft;
            CategoryDetailsFormbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CategoryDetailsFormbutton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonOK);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(18, 368);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(664, 65);
            flowLayoutPanel1.TabIndex = 0;
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
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(541, 12);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.MinimumSize = new Size(0, 44);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 44);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.BackColor = Color.FromArgb(40, 167, 69);
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.ForeColor = Color.White;
            buttonOK.Image = (Image)resources.GetObject("buttonOK.Image");
            buttonOK.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOK.Location = new Point(428, 12);
            buttonOK.Margin = new Padding(3, 2, 10, 2);
            buttonOK.MinimumSize = new Size(0, 44);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(100, 44);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "Save";
            buttonOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOK.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(45, 52, 64);
            groupBox1.Location = new Point(18, 87);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20);
            groupBox1.Size = new Size(664, 274);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category Information";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.DataBindings.Add(new Binding("Text", categoryBindingSource, "Description", true));
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(149, 90);
            textBox2.Margin = new Padding(3, 10, 3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(480, 159);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.DataBindings.Add(new Binding("Text", categoryBindingSource, "Name", true));
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(149, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entites.Category);
            // 
            // CategoryDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Category Details";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonOK;
        private Button buttonCancel;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox2;
        private BindingSource categoryBindingSource;
        private TextBox textBox1;
        private Label label2;
        private Button CategoryDetailsFormbutton;
    }
}