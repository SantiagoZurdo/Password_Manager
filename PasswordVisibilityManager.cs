namespace Password_Manager_Design
{
    internal class PasswordVisibilityManager
    {
        private bool _isVisible;
        private readonly TextBox _passwordTextBox;

        public PasswordVisibilityManager(TextBox passwordTextBox)
        {
            _passwordTextBox = passwordTextBox;
            _isVisible = false;
            // hide default
            _passwordTextBox.PasswordChar = '*';
        }
        public void TogglePasswordVisibility()
        {
            if (_isVisible)
            {
                // hide passwrd
                _passwordTextBox.PasswordChar = '*';
            }
            else
            {
                // reveal passwrd
                _passwordTextBox.PasswordChar = '\0'; 
            }
            _isVisible = !_isVisible;
        }
        public bool IsPasswordVisible => _isVisible;
    }
}