using Clinic.AppServices;

namespace Clinic.AppForms
{
    public partial class MainForm : Clinic.AppForms.ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("Пациенты");
            ContextManager.parentForm.ShowLogoutUi();
            ContextManager.parentForm.SetUserData();
            ContextManager.mainForm = this;
        }
    }
}
