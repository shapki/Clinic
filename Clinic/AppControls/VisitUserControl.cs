using Clinic.AppModels;
using System;
using System.Windows.Forms;

namespace Clinic.AppControls
{
    public partial class VisitUserControl : UserControl
    {
        private Visits _visit;
        public VisitUserControl()
        {
            InitializeComponent();
        }

        public VisitUserControl(Visits visit)
        {
            InitializeComponent();
            _visit = visit;
            ShowVisitInfo();
        }

        /// <summary>
        /// PKGH
        /// Подстановка информации о визите пациента
        /// </summary>
        private void ShowVisitInfo()
        {
            dateLabel.Text = $"Дата: {_visit.VisitDate:dd.MM.yyyy}";
            specialistLabel.Text = $"Врач: {_visit.Medics.MedicName}";
        }
    }
}
