using Clinic.AppServices;

namespace Clinic.AppForms
{
    public partial class LoginForm : Clinic.AppForms.ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("Авторизация");
            ContextManager.loginForm = this;
        }

        /// <summary>
        /// PKGH
        /// Авторизация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, System.EventArgs e)
        {
            AuthManager.Login(loginTextBox.Text, passwordTextBox.Text);
        }

        /// <summary>
        /// PKGH
        /// Вход в роли Гостя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guestLoginButton_Click(object sender, System.EventArgs e)
        {
            AuthManager.Login("g", "g");
        }
    }
}