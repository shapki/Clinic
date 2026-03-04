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

        /// <summary>
        /// PKGH
        /// Установка заголовка окна и заголовка на форме
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            string tempTitle = "Поликлиника \"Ай Ой\": " + title;
            title = tempTitle;
            titleLabel.Text = title;
        }

        /// <summary>
        /// PKGH
        /// Установка данных пользователя для отображения в правом верхнем углу
        /// </summary>
        public void SetUserData()
        {
            userLoginLabel.Text = ContextManager.user.FullName;
            userRoleLabel.Text = ContextManager.user.Role;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AuthManager.Logout(this);
        }
    }
}
