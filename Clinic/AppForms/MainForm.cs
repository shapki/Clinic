using Clinic.AppControls;
using Clinic.AppModels;
using Clinic.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.AppForms
{
    public partial class MainForm : Clinic.AppForms.ParentForm
    {
        private List<Patients> _patients;
        public MainForm()
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("Пациенты");
            ContextManager.parentForm.ShowLogoutUi();
            ContextManager.parentForm.SetUserData();
            ContextManager.mainForm = this;
            CheckUserAccess();
            InitializeComboBoxes();
        }

        /// <summary>
        /// PKGH
        /// Первоначальная подстановка значений для выпадающих списков
        /// </summary>
        private void InitializeComboBoxes()
        {
            birthDateSortComboBox.SelectedIndex = 0;
            genderComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// PKGH
        /// Проверка уровня доступа пользователя
        /// </summary>
        private void CheckUserAccess()
        {
            if (AccessManager.IsAdmin() || AccessManager.IsMedic())
            {
                birthDateSortLabel.Visible = true;
                birthDateSortComboBox.Visible = true;
                genderLabel.Visible = true;
                genderComboBox.Visible = true;
                searchLabel.Visible = true;
                searchTextBox.Visible = true;
                addPatientButton.Visible = true;
            }
        }

        /// <summary>
        /// PKGH
        /// Очистка пациентов
        /// </summary>
        private void ClearPatients()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        /// <summary>
        /// PKGH
        /// Вывод пациентов
        /// </summary>
        private void ShowPatients()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Patients patient in _patients)
            {
                flowLayoutPanel1.Controls.Add(new PatientUserControl(patient));
            }
        }

        /// <summary>
        /// PKGH
        /// Выборка пациентов
        /// </summary>
        private void SelectPatients()
        {
            string searchInput = searchTextBox.Text.Trim();
            string sortOption = birthDateSortComboBox.SelectedItem?.ToString() ?? "Не использовать";
            string genderFilter = genderComboBox.SelectedItem?.ToString() ?? "Все";

            IQueryable<Patients> tmpPatients = Program.context.Patients;

            if (!string.IsNullOrEmpty(searchInput))
            {
                tmpPatients = tmpPatients.Where(p =>
                    p.FullName.Contains(searchInput)
                );
            }

            if (genderFilter != "Все")
            {
                int genderId = genderFilter == "Муж" ? 1 : 2;
                tmpPatients = tmpPatients.Where(p => p.GenderId == genderId);
            }

            switch (sortOption)
            {
                case "По возрастанию":
                    tmpPatients = tmpPatients.OrderBy(p => p.BirthDate);
                    break;
                case "По убыванию":
                    tmpPatients = tmpPatients.OrderByDescending(p => p.BirthDate);
                    break;
                case "Не использовать":
                default:
                    tmpPatients = tmpPatients.OrderBy(p => p.FullName);
                    break;
            }

            _patients = tmpPatients.ToList();
        }

        /// <summary>
        /// PKGH
        /// Обновление панели с пациентами
        /// </summary>
        public void Refresh()
        {
            ClearPatients();
            SelectPatients();
            ShowPatients();
        }

        private void birthDateSortComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void genderComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void addPatientButton_Click(object sender, System.EventArgs e)
        {
            var addForm = new CreateUpdatePatientForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
