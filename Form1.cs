namespace Password_Manager_Design
{
    public partial class Form1 : Form
    {
        private readonly AuthService _authService;
        private readonly PasswordVisibilityManager _passwordVisibilityManager;
        public Form1()
        {
            InitializeComponent();
            _passwordVisibilityManager = new PasswordVisibilityManager(txBxPassword);
            _authService = new AuthService();
            
        }

        private void txBxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string password = txBxPassword.Text;
                if (_authService.Authenticate(password))
                {
                    //MessageBox.Show("Acces Garanted");
                    HideLogin();
                    ShowMainContent();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    txBxPassword.Clear();
                    txBxPassword.Focus();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void btnReveal_Click(object sender, EventArgs e)
        {
            _passwordVisibilityManager.TogglePasswordVisibility();
            //change button text
            btnReveal.Text = _passwordVisibilityManager.IsPasswordVisible ? "Hide" : "Reveal";
        }
        //hide buttons and textboxeslogin
        private void HideLogin()
        {
            grpBxLogin.Visible = false;
        }
        private void ShowMainContent()
        { 
            grBxMainContent.Visible = true;
        }
    }
}
