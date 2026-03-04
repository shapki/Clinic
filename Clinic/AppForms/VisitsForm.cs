using Clinic.AppControls;
using Clinic.AppModels;
using Clinic.AppServices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.AppForms
{
    public partial class VisitsForm : Clinic.AppForms.ParentForm
    {
        private Patients _patient;
        public VisitsForm(Patients patient)
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("История посещений");
            _patient = patient;
            this.Text = $"История обращений: {_patient.FullName}";
            LoadVisits();
        }

        private void LoadVisits()
        {
            flowLayoutPanel1.Controls.Clear();

            var visits = Program.context.Visits
                .Where(v => v.PatientId == _patient.IdPatient)
                .OrderByDescending(v => v.VisitDate)
                .ToList();

            foreach (var visit in visits)
            {
                var visitControl = new VisitUserControl(visit);
                flowLayoutPanel1.Controls.Add(visitControl);
            }

            if (visits.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "У пациента нет обращений",
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 10)
                };
                flowLayoutPanel1.Controls.Add(emptyLabel);
            }
        }
    }
}
