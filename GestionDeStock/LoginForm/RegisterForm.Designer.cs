namespace GestionDeStock.LoginForm
{
    partial class RegisterForm
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
            mainTableLayoutPanel = new TableLayoutPanel();
            panelRegister = new Panel();
            panelRegisterContent = new Panel();
            lblTitle = new Label();
            panelUsername = new Panel();
            pictureBoxUser = new PictureBox();
            txtUsername = new TextBox();
            panelUsernameUnderline = new Panel();
            panelPassword = new Panel();
            pictureBoxPassword = new PictureBox();
            txtPassword = new TextBox();
            panelPasswordUnderline = new Panel();
            panelConfirmPassword = new Panel();
            pictureBoxConfirmPassword = new PictureBox();
            txtConfirmPassword = new TextBox();
            panelConfirmPasswordUnderline = new Panel();
            chkShowPassword = new CheckBox();
            btnRegister = new Button();
            lnkLogin = new LinkLabel();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            lblAppName = new Label();
            lblSlogan = new Label();
            mainTableLayoutPanel.SuspendLayout();
            panelRegister.SuspendLayout();
            panelRegisterContent.SuspendLayout();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            panelConfirmPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmPassword).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.BackColor = Color.White;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            mainTableLayoutPanel.Controls.Add(panelRegister, 0, 0);
            mainTableLayoutPanel.Controls.Add(panelLogo, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(1100, 700);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.White;
            panelRegister.Controls.Add(panelRegisterContent);
            panelRegister.Dock = DockStyle.Fill;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Margin = new Padding(0);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(605, 700);
            panelRegister.TabIndex = 1;
            // 
            // panelRegisterContent
            // 
            panelRegisterContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRegisterContent.Controls.Add(lblTitle);
            panelRegisterContent.Controls.Add(panelUsername);
            panelRegisterContent.Controls.Add(panelPassword);
            panelRegisterContent.Controls.Add(panelConfirmPassword);
            panelRegisterContent.Controls.Add(chkShowPassword);
            panelRegisterContent.Controls.Add(btnRegister);
            panelRegisterContent.Controls.Add(lnkLogin);
            panelRegisterContent.Location = new Point(24, 78);
            panelRegisterContent.Name = "panelRegisterContent";
            panelRegisterContent.Size = new Size(569, 570);
            panelRegisterContent.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(152, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign Up";
            // 
            // panelUsername
            // 
            panelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUsername.Controls.Add(pictureBoxUser);
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(panelUsernameUnderline);
            panelUsername.Location = new Point(20, 100);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(460, 60);
            panelUsername.TabIndex = 1;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.arobase;
            pictureBoxUser.Location = new Point(5, 10);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(30, 30);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 2;
            pictureBoxUser.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsername.Location = new Point(45, 15);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(410, 27);
            txtUsername.TabIndex = 1;
            // 
            // panelUsernameUnderline
            // 
            panelUsernameUnderline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUsernameUnderline.BackColor = Color.FromArgb(0, 122, 204);
            panelUsernameUnderline.Location = new Point(5, 45);
            panelUsernameUnderline.Name = "panelUsernameUnderline";
            panelUsernameUnderline.Size = new Size(450, 2);
            panelUsernameUnderline.TabIndex = 0;
            // 
            // panelPassword
            // 
            panelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPassword.Controls.Add(pictureBoxPassword);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(panelPasswordUnderline);
            panelPassword.Location = new Point(20, 180);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(460, 60);
            panelPassword.TabIndex = 2;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = Properties.Resources.cadenas;
            pictureBoxPassword.Location = new Point(5, 10);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(30, 30);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPassword.TabIndex = 2;
            pictureBoxPassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(45, 15);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(410, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPasswordUnderline.BackColor = Color.FromArgb(0, 122, 204);
            panelPasswordUnderline.Location = new Point(5, 45);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(450, 2);
            panelPasswordUnderline.TabIndex = 0;
            // 
            // panelConfirmPassword
            // 
            panelConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelConfirmPassword.Controls.Add(pictureBoxConfirmPassword);
            panelConfirmPassword.Controls.Add(txtConfirmPassword);
            panelConfirmPassword.Controls.Add(panelConfirmPasswordUnderline);
            panelConfirmPassword.Location = new Point(20, 260);
            panelConfirmPassword.Name = "panelConfirmPassword";
            panelConfirmPassword.Size = new Size(460, 60);
            panelConfirmPassword.TabIndex = 3;
            // 
            // pictureBoxConfirmPassword
            // 
            pictureBoxConfirmPassword.Image = Properties.Resources.cadenas;
            pictureBoxConfirmPassword.Location = new Point(5, 10);
            pictureBoxConfirmPassword.Name = "pictureBoxConfirmPassword";
            pictureBoxConfirmPassword.Size = new Size(30, 30);
            pictureBoxConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxConfirmPassword.TabIndex = 2;
            pictureBoxConfirmPassword.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtConfirmPassword.Location = new Point(45, 15);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(410, 27);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // panelConfirmPasswordUnderline
            // 
            panelConfirmPasswordUnderline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelConfirmPasswordUnderline.BackColor = Color.FromArgb(0, 122, 204);
            panelConfirmPasswordUnderline.Location = new Point(5, 45);
            panelConfirmPasswordUnderline.Name = "panelConfirmPasswordUnderline";
            panelConfirmPasswordUnderline.Size = new Size(450, 2);
            panelConfirmPasswordUnderline.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(64, 64, 64);
            chkShowPassword.Location = new Point(25, 330);
            chkShowPassword.Margin = new Padding(4, 5, 4, 5);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(134, 24);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(0, 122, 204);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(20, 370);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(460, 45);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.FromArgb(0, 102, 204);
            lnkLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnkLogin.AutoSize = true;
            lnkLogin.Font = new Font("Segoe UI", 10F);
            lnkLogin.LinkColor = Color.FromArgb(0, 122, 204);
            lnkLogin.Location = new Point(165, 430);
            lnkLogin.Margin = new Padding(4, 0, 4, 0);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(218, 23);
            lnkLogin.TabIndex = 6;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Already have an account? Login";
            lnkLogin.LinkClicked += LnkLogin_LinkClicked;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 122, 204);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(lblAppName);
            panelLogo.Controls.Add(lblSlogan);
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(605, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(495, 700);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Image = Properties.Resources.purple_minimalist_simple_store_logo;
            pictureBoxLogo.Location = new Point(131, 134);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.None;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(56, 356);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(358, 50);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Stock Management";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            lblSlogan.Anchor = AnchorStyles.None;
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 11F);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(101, 421);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(267, 25);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Manage your inventory simply";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 700);
            Controls.Add(mainTableLayoutPanel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(900, 600);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Management - Register";
            mainTableLayoutPanel.ResumeLayout(false);
            panelRegister.ResumeLayout(false);
            panelRegisterContent.ResumeLayout(false);
            panelRegisterContent.PerformLayout();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            panelConfirmPassword.ResumeLayout(false);
            panelConfirmPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfirmPassword).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label lblAppName;
        private Label lblSlogan;
        private Panel panelRegister;
        private Panel panelRegisterContent;
        private Label lblTitle;
        private Panel panelUsername;
        private TextBox txtUsername;
        private Panel panelUsernameUnderline;
        private Panel panelPassword;
        private TextBox txtPassword;
        private Panel panelPasswordUnderline;
        private Panel panelConfirmPassword;
        private TextBox txtConfirmPassword;
        private Panel panelConfirmPasswordUnderline;
        private CheckBox chkShowPassword;
        private Button btnRegister;
        private LinkLabel lnkLogin;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxPassword;
        private PictureBox pictureBoxConfirmPassword;
    }
}