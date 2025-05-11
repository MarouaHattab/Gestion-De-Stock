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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonOK = new Button();
            buttonCancel = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            categoryBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CategoryDetailsFormbutton = new Button();
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
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(700, 386);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonOK);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 325);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(694, 59);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Image = (Image)resources.GetObject("buttonOK.Image");
            buttonOK.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOK.Location = new Point(582, 2);
            buttonOK.Margin = new Padding(3, 2, 3, 2);
            buttonOK.MinimumSize = new Size(0, 44);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(109, 54);
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
            buttonCancel.Location = new Point(461, 2);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.MinimumSize = new Size(0, 44);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 54);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Annuler";
            buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 77);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(694, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", categoryBindingSource, "Description", true));
            textBox2.Location = new Point(149, 78);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(513, 159);
            textBox2.TabIndex = 3;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entites.Category);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", categoryBindingSource, "Name", true));
            textBox1.Location = new Point(149, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(513, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // CategoryDetailsFormbutton
            // 
            CategoryDetailsFormbutton.Dock = DockStyle.Fill;
            CategoryDetailsFormbutton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDetailsFormbutton.ForeColor = SystemColors.Highlight;
            CategoryDetailsFormbutton.Image = (Image)resources.GetObject("CategoryDetailsFormbutton.Image");
            CategoryDetailsFormbutton.ImageAlign = ContentAlignment.MiddleLeft;
            CategoryDetailsFormbutton.Location = new Point(3, 3);
            CategoryDetailsFormbutton.Name = "CategoryDetailsFormbutton";
            CategoryDetailsFormbutton.Size = new Size(694, 69);
            CategoryDetailsFormbutton.TabIndex = 5;
            CategoryDetailsFormbutton.Text = "Category Details Dashboard";
            CategoryDetailsFormbutton.UseVisualStyleBackColor = true;
            // 
            // CategoryDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 386);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Catégorie";
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