using GestionDeStock.LoginForm;

namespace GestionDeStock
{
    public partial class MainForm : Form
    {
        private readonly LoginForm.LoginForm _loginForm;

        public MainForm(LoginForm.LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Hide the main form
            this.Hide();

            // Show the login form
            DialogResult result = _loginForm.ShowDialog();

            // If login was successful, show the main form
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                // If login was cancelled or unsuccessful, close the application
                this.Close();
            }
        }
    }
}
