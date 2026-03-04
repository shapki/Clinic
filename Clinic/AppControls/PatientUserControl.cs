using Clinic.AppServices;
using System;
using System.Windows.Forms;

namespace Clinic.AppControls
{
    public partial class PatientUserControl : UserControl
    {
        private bool userAccess = false;
        public PatientUserControl()
        {
            InitializeComponent();
            CheckUserAccess();
        }

        private void CheckUserAccess()
        {
            if (AccessManager.IsAdmin() || AccessManager.IsMedic())
            {
                visitsHistoryButton.Visible = true;
                userAccess = true;
            }
        }

        private void visitsHistoryButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PatientUserControl_Click(object sender, EventArgs e)
        {
            if (userAccess)
            {

            }
        }
    }
}
