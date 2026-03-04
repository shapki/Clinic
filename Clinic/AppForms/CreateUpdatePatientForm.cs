using Clinic.AppModels;
using Clinic.AppServices;
using System;
using System.Windows.Forms;

namespace Clinic.AppForms
{
    public partial class CreateUpdatePatientForm : Clinic.AppForms.ParentForm
    {
        private Patients _patient;
        private bool _isInvalidnost = false;
        public CreateUpdatePatientForm()
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("Добавление пациента");
            _patient = new Patients();
        }

        public CreateUpdatePatientForm(Patients patient)
        {
            InitializeComponent();
            ContextManager.parentForm.SetTitle("Изменение пациента");
            _patient = patient;
        }

        private void CreateUpdatePatientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_clinicDataSet.Genders". При необходимости она может быть перемещена или удалена.
            this.gendersTableAdapter.Fill(this.shapkin_clinicDataSet.Genders);

            FillForm();
        }

        private void FillForm()
        {
            if (_patient.IdPatient != 0)
            {
                fullNameTextBox.Text = _patient.FullName;

                genderIdComboBox.SelectedValue = _patient.GenderId;

                birthDateDateTimePicker.Value = _patient.BirthDate;
                insurancePolicyTextBox.Text = _patient.InsurancePolicy;
                fluragrafiaDateDateTimePicker.Value = _patient.FluragrafiaDate;
                dIspanserizaciaDateDateTimePicker.Value = _patient.DIspanserizaciaDate;
                heightNumericUpDown.Value = _patient.Height;
                weightNumericUpDown.Value = _patient.Weight;
                photoTextBox.Text = _patient.Photo;

                InvalidnostGroupCheck();
            }
        }

        private void InvalidnostGroupCheck()
        {
            if (_patient.InvalidnostGroup.HasValue && _patient.InvalidnostGroupDate.HasValue)
            {
                invalidnostGroupNumericUpDown.Value = _patient.InvalidnostGroup.Value;
                invalidnostGroupDateDateTimePicker.Value = _patient.InvalidnostGroupDate.Value;
                UpdateInvalidnostControlsState(true);
                _isInvalidnost = true;
            }
            else
            {
                UpdateInvalidnostControlsState(false);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                {
                    MessageBox.Show("Введите ФИО пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fullNameTextBox.Focus();
                    return;
                }

                if (genderIdComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Выберите пол пациента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    genderIdComboBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(insurancePolicyTextBox.Text))
                {
                    MessageBox.Show("Введите номер страхового полиса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    insurancePolicyTextBox.Focus();
                    return;
                }

                _patient.FullName = fullNameTextBox.Text.Trim();
                _patient.GenderId = (int)genderIdComboBox.SelectedValue;
                _patient.BirthDate = birthDateDateTimePicker.Value;
                _patient.InsurancePolicy = insurancePolicyTextBox.Text.Trim();
                _patient.FluragrafiaDate = fluragrafiaDateDateTimePicker.Value;
                _patient.DIspanserizaciaDate = dIspanserizaciaDateDateTimePicker.Value;
                _patient.Height = heightNumericUpDown.Value;
                _patient.Weight = weightNumericUpDown.Value;
                _patient.Photo = string.IsNullOrWhiteSpace(photoTextBox.Text) ? null : photoTextBox.Text.Trim();

                if (_isInvalidnost)
                {
                    _patient.InvalidnostGroup = invalidnostGroupNumericUpDown.Value;
                    _patient.InvalidnostGroupDate = invalidnostGroupDateDateTimePicker.Value;
                }
                else
                {
                    _patient.InvalidnostGroup = null;
                    _patient.InvalidnostGroupDate = null;
                }

                if (_patient.IdPatient == 0)
                {
                    Program.context.Patients.Add(_patient);
                }
                else
                {
                    Program.context.Entry(_patient).State = System.Data.Entity.EntityState.Modified;
                }

                Program.context.SaveChanges();

                MessageBox.Show("Данные пациента сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInvalidnostControlsState(bool enabled)
        {
            invalidnostGroupNumericUpDown.Enabled = enabled;
            invalidnostGroupDateDateTimePicker.Enabled = enabled;
        }

        private void invalidnostToggleButton_Click(object sender, EventArgs e)
        {
            _isInvalidnost = !_isInvalidnost;
            UpdateInvalidnostControlsState(_isInvalidnost);
        }
    }
}
