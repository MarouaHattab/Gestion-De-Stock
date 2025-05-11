namespace GestionDeStock.LoginForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            mainTableLayoutPanel = new TableLayoutPanel();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            lblAppName = new Label();
            lblSlogan = new Label();
            panelLogin = new Panel();
            panelLoginContent = new Panel();
            lblTitle = new Label();
            panelUsername = new Panel();
            pictureBoxUser = new PictureBox();
            txtUsername = new TextBox();
            panelUsernameUnderline = new Panel();
            panelPassword = new Panel();
            pictureBoxPassword = new PictureBox();
            txtPassword = new TextBox();
            panelPasswordUnderline = new Panel();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            lnkCreateAccount = new LinkLabel();
            mainTableLayoutPanel.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLogin.SuspendLayout();
            panelLoginContent.SuspendLayout();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.BackColor = Color.White;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            mainTableLayoutPanel.Controls.Add(panelLogo, 0, 0);
            mainTableLayoutPanel.Controls.Add(panelLogin, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(884, 561);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 122, 204);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(lblAppName);
            panelLogo.Controls.Add(lblSlogan);
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(397, 561);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(82, 64);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.None;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(7, 286);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(290, 41);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Stock Management";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            lblAppName.Click += lblAppName_Click;
            // 
            // lblSlogan
            // 
            lblSlogan.Anchor = AnchorStyles.None;
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 11F);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(52, 351);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(208, 20);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Manage your inventory simply";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            lblSlogan.Click += lblSlogan_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(panelLoginContent);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(397, 0);
            panelLogin.Margin = new Padding(0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(487, 561);
            panelLogin.TabIndex = 1;
            // 
            // panelLoginContent
            // 
            panelLoginContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLoginContent.Controls.Add(lblTitle);
            panelLoginContent.Controls.Add(panelUsername);
            panelLoginContent.Controls.Add(panelPassword);
            panelLoginContent.Controls.Add(chkShowPassword);
            panelLoginContent.Controls.Add(btnLogin);
            panelLoginContent.Controls.Add(lnkCreateAccount);
            panelLoginContent.Location = new Point(24, 78);
            panelLoginContent.Name = "panelLoginContent";
            panelLoginContent.Size = new Size(451, 431);
            panelLoginContent.TabIndex = 0;
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
            lblTitle.Size = new Size(104, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // panelUsername
            // 
            panelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUsername.Controls.Add(pictureBoxUser);
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(panelUsernameUnderline);
            panelUsername.Location = new Point(20, 100);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(342, 60);
            panelUsername.TabIndex = 1;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
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
            txtUsername.Size = new Size(292, 22);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // panelUsernameUnderline
            // 
            panelUsernameUnderline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUsernameUnderline.BackColor = Color.FromArgb(0, 122, 204);
            panelUsernameUnderline.Location = new Point(5, 45);
            panelUsernameUnderline.Name = "panelUsernameUnderline";
            panelUsernameUnderline.Size = new Size(332, 2);
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
            panelPassword.Size = new Size(342, 60);
            panelPassword.TabIndex = 2;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
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
            txtPassword.Size = new Size(292, 22);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPasswordUnderline.BackColor = Color.FromArgb(0, 122, 204);
            panelPasswordUnderline.Location = new Point(5, 45);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(332, 2);
            panelPasswordUnderline.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.FromArgb(64, 64, 64);
            chkShowPassword.Location = new Point(25, 250);
            chkShowPassword.Margin = new Padding(4, 5, 4, 5);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 290);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(342, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.ActiveLinkColor = Color.FromArgb(0, 102, 204);
            lnkCreateAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.Font = new Font("Segoe UI", 10F);
            lnkCreateAccount.LinkColor = Color.FromArgb(0, 122, 204);
            lnkCreateAccount.Location = new Point(165, 357);
            lnkCreateAccount.Margin = new Padding(4, 0, 4, 0);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(141, 19);
            lnkCreateAccount.TabIndex = 5;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Create a new account";
            lnkCreateAccount.LinkClicked += lnkCreateAccount_LinkClicked_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(mainTableLayoutPanel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(900, 600);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Management - Login";
            mainTableLayoutPanel.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelLogin.ResumeLayout(false);
            panelLoginContent.ResumeLayout(false);
            panelLoginContent.PerformLayout();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label lblAppName;
        private Label lblSlogan;
        private Panel panelLogin;
        private Panel panelLoginContent;
        private Label lblTitle;
        private Panel panelUsername;
        private TextBox txtUsername;
        private Panel panelUsernameUnderline;
        private Panel panelPassword;
        private TextBox txtPassword;
        private Panel panelPasswordUnderline;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private LinkLabel lnkCreateAccount;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxPassword;
    }
}