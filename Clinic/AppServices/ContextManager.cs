using Clinic.AppForms;
using Clinic.AppModels;

namespace Clinic.AppServices
{
    /// <summary>
    /// PKGH
    /// Общее 'хранилище' для текущего пользователя и некоторых форм
    /// </summary>
    internal class ContextManager
    {
        public static Users user;
        public static ParentForm parentForm;
        public static LoginForm loginForm;
        public static MainForm mainForm;
    }
}
