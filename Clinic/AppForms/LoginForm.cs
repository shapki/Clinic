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

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
