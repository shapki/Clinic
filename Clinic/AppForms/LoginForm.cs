using Clinic.AppServices;

namespace Clinic.AppForms
{
    public partial class LoginForm : Clinic.AppForms.MainForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("Авторизация");
            ContextManager.loginForm = this;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shapkin_clinicDataSet);

        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            AuthManager.Login(loginTextBox.Text, passwordTextBox.Text);
        }

        private void guestLoginButton_Click(object sender, System.EventArgs e)
        {
            AuthManager.Login("g", "g");
        }
    }
}
