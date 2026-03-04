using Clinic.AppServices;
using System;
using System.Windows.Forms;

namespace Clinic.AppForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            HideLogoutUi();
            ContextManager.parentForm = this;
        }

        public void HideLogoutUi()
        {
            logoutButton.Visible = false;
            userLoginLabel.Visible = false;
            userRoleLabel.Visible = false;
        }

        public void ShowLogoutUi()
        {
            logoutButton.Visible = true;
            userLoginLabel.Visible = true;
            userRoleLabel.Visible = true;
        }

        public void SetTitle(string title)
        {
            string tempTitle = "Поликлиника \"Ай Ой\": " + title;
            title = tempTitle;
            titleLabel.Text = title;
        }

        public void SetUserData()
        {
            userLoginLabel.Text = ContextManager.user.Login;
            userRoleLabel.Text = ContextManager.user.Role;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AuthManager.Logout(this);
        }
    }
}
