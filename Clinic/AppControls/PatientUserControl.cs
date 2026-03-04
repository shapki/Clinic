using Clinic.AppForms;
using Clinic.AppModels;
using Clinic.AppServices;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Clinic.AppControls
{
    public partial class PatientUserControl : UserControl
    {
        private Patients _patient;
        private bool userAccess = false;
        public PatientUserControl(Patients patient)
        {
            InitializeComponent();
            CheckUserAccess();
            _patient = patient;
            showPatientInfo();
        }

        private void showPatientInfo()
        {
            LastNameLabel.Text = _patient.FullName;
            genderLabel.Text = _patient.Genders.GenderName;
            insurancePolicyLabel.Text = _patient.InsurancePolicy;
            photoPictureBox.Image = GetImage();
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
            var visitsForm = new VisitsForm(_patient);
            visitsForm.ShowDialog();
        }

        private void PatientUserControl_Click(object sender, EventArgs e)
        {
            if (userAccess)
            {
                var editForm = new CreateUpdatePatientForm(_patient);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    if (ContextManager.mainForm != null)
                    {
                        ContextManager.mainForm.Refresh();
                    }
                }
            }
        }

        private Image GetImage()
        {
            Image img;
            try
            {
                {
                    img = new Bitmap(Image.FromFile(FileManager.GetImgPath(_patient.Photo)));
                }

            }
            catch (FileNotFoundException ex)
            {
                img = Image.FromFile(FileManager.GetImgPath("photo.jpg"));
            }

            return img;
        }
    }
}
