using Clinic.AppForms;
using Clinic.AppModels;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.AppServices
{
    internal class AuthManager
    {
        public static void Login(string login, string password)
        {
            Users tmpUser = Program.context.Users
            .Where(user => user.Login == login)
            .Where(user => user.Password == password)
            .FirstOrDefault();
            if (tmpUser == null)
            {
                MessageBox.Show("Неверны логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ContextManager.user = tmpUser;

            MainForm mainForm = new MainForm();
            ContextManager.mainForm = mainForm;

            mainForm.Show();
            ContextManager.loginForm.Hide();
        }

        public static void Logout(ParentForm form)
        {
            ContextManager.user = null;
            form.Hide();
            ContextManager.loginForm.Show();
        }
    }
}
