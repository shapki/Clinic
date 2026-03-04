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

        private void birthDateSortComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void addPatientButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
