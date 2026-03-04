namespace Clinic.AppForms
{
    partial class CreateUpdatePatientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label genderIdLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label insurancePolicyLabel;
            System.Windows.Forms.Label fluragrafiaDateLabel;
            System.Windows.Forms.Label dIspanserizaciaDateLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label invalidnostGroupLabel;
            System.Windows.Forms.Label invalidnostGroupDateLabel;
            System.Windows.Forms.Label photoLabel;
            this.invalidnostGroupBox = new System.Windows.Forms.GroupBox();
            this.invalidnostGroupDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_clinicDataSet = new Clinic.Shapkin_clinicDataSet();
            this.invalidnostGroupNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.patientsTableAdapter = new Clinic.Shapkin_clinicDataSetTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new Clinic.Shapkin_clinicDataSetTableAdapters.TableAdapterManager();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insurancePolicyTextBox = new System.Windows.Forms.TextBox();
            this.fluragrafiaDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dIspanserizaciaDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.gendersTableAdapter = new Clinic.Shapkin_clinicDataSetTableAdapters.GendersTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.invalidnostToggleButton = new System.Windows.Forms.Button();
            fullNameLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            insurancePolicyLabel = new System.Windows.Forms.Label();
            fluragrafiaDateLabel = new System.Windows.Forms.Label();
            dIspanserizaciaDateLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            invalidnostGroupLabel = new System.Windows.Forms.Label();
            invalidnostGroupDateLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.invalidnostGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidnostGroupNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(fullNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(genderIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.genderIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(birthDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.birthDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(insurancePolicyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.insurancePolicyTextBox);
            this.splitContainer1.Panel2.Controls.Add(fluragrafiaDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fluragrafiaDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(dIspanserizaciaDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dIspanserizaciaDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(heightLabel);
            this.splitContainer1.Panel2.Controls.Add(this.heightNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(weightLabel);
            this.splitContainer1.Panel2.Controls.Add(this.weightNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.invalidnostGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(539, 570);
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(97, 39);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(31, 13);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "ФИО";
            // 
            // genderIdLabel
            // 
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(97, 67);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(28, 13);
            genderIdLabel.TabIndex = 3;
            genderIdLabel.Text = "Пол";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(97, 95);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(62, 13);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date:";
            // 
            // insurancePolicyLabel
            // 
            insurancePolicyLabel.AutoSize = true;
            insurancePolicyLabel.Location = new System.Drawing.Point(97, 122);
            insurancePolicyLabel.Name = "insurancePolicyLabel";
            insurancePolicyLabel.Size = new System.Drawing.Size(99, 13);
            insurancePolicyLabel.TabIndex = 7;
            insurancePolicyLabel.Text = "Страховой полис";
            // 
            // fluragrafiaDateLabel
            // 
            fluragrafiaDateLabel.AutoSize = true;
            fluragrafiaDateLabel.Location = new System.Drawing.Point(97, 151);
            fluragrafiaDateLabel.Name = "fluragrafiaDateLabel";
            fluragrafiaDateLabel.Size = new System.Drawing.Size(112, 13);
            fluragrafiaDateLabel.TabIndex = 9;
            fluragrafiaDateLabel.Text = "Дата Флюрографии";
            // 
            // dIspanserizaciaDateLabel
            // 
            dIspanserizaciaDateLabel.AutoSize = true;
            dIspanserizaciaDateLabel.Location = new System.Drawing.Point(97, 179);
            dIspanserizaciaDateLabel.Name = "dIspanserizaciaDateLabel";
            dIspanserizaciaDateLabel.Size = new System.Drawing.Size(132, 13);
            dIspanserizaciaDateLabel.TabIndex = 11;
            dIspanserizaciaDateLabel.Text = "Дата Диспансеризации";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(97, 203);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(30, 13);
            heightLabel.TabIndex = 13;
            heightLabel.Text = "Рост";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(97, 231);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(25, 13);
            weightLabel.TabIndex = 15;
            weightLabel.Text = "Вес";
            // 
            // invalidnostGroupLabel
            // 
            invalidnostGroupLabel.AutoSize = true;
            invalidnostGroupLabel.Location = new System.Drawing.Point(6, 51);
            invalidnostGroupLabel.Name = "invalidnostGroupLabel";
            invalidnostGroupLabel.Size = new System.Drawing.Size(44, 13);
            invalidnostGroupLabel.TabIndex = 17;
            invalidnostGroupLabel.Text = "Группа";
            // 
            // invalidnostGroupDateLabel
            // 
            invalidnostGroupDateLabel.AutoSize = true;
            invalidnostGroupDateLabel.Location = new System.Drawing.Point(6, 83);
            invalidnostGroupDateLabel.Name = "invalidnostGroupDateLabel";
            invalidnostGroupDateLabel.Size = new System.Drawing.Size(106, 13);
            invalidnostGroupDateLabel.TabIndex = 19;
            invalidnostGroupDateLabel.Text = "Дата определения";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(97, 374);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(33, 13);
            photoLabel.TabIndex = 21;
            photoLabel.Text = "Фото";
            // 
            // invalidnostGroupBox
            // 
            this.invalidnostGroupBox.Controls.Add(this.invalidnostToggleButton);
            this.invalidnostGroupBox.Controls.Add(invalidnostGroupLabel);
            this.invalidnostGroupBox.Controls.Add(this.invalidnostGroupDateDateTimePicker);
            this.invalidnostGroupBox.Controls.Add(invalidnostGroupDateLabel);
            this.invalidnostGroupBox.Controls.Add(this.invalidnostGroupNumericUpDown);
            this.invalidnostGroupBox.Location = new System.Drawing.Point(100, 259);
            this.invalidnostGroupBox.Name = "invalidnostGroupBox";
            this.invalidnostGroupBox.Size = new System.Drawing.Size(333, 106);
            this.invalidnostGroupBox.TabIndex = 0;
            this.invalidnostGroupBox.TabStop = false;
            this.invalidnostGroupBox.Text = "Инвалидность";
            // 
            // invalidnostGroupDateDateTimePicker
            // 
            this.invalidnostGroupDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "InvalidnostGroupDate", true));
            this.invalidnostGroupDateDateTimePicker.Enabled = false;
            this.invalidnostGroupDateDateTimePicker.Location = new System.Drawing.Point(142, 79);
            this.invalidnostGroupDateDateTimePicker.Name = "invalidnostGroupDateDateTimePicker";
            this.invalidnostGroupDateDateTimePicker.Size = new System.Drawing.Size(185, 22);
            this.invalidnostGroupDateDateTimePicker.TabIndex = 20;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.shapkin_clinicDataSet;
            // 
            // shapkin_clinicDataSet
            // 
            this.shapkin_clinicDataSet.DataSetName = "Shapkin_clinicDataSet";
            this.shapkin_clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invalidnostGroupNumericUpDown
            // 
            this.invalidnostGroupNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "InvalidnostGroup", true));
            this.invalidnostGroupNumericUpDown.Enabled = false;
            this.invalidnostGroupNumericUpDown.Location = new System.Drawing.Point(142, 51);
            this.invalidnostGroupNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.invalidnostGroupNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.invalidnostGroupNumericUpDown.Name = "invalidnostGroupNumericUpDown";
            this.invalidnostGroupNumericUpDown.Size = new System.Drawing.Size(185, 22);
            this.invalidnostGroupNumericUpDown.TabIndex = 18;
            this.invalidnostGroupNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GendersTableAdapter = null;
            this.tableAdapterManager.MedicsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Clinic.Shapkin_clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VisitsTableAdapter = null;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(233, 36);
            this.fullNameTextBox.MaxLength = 100;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "GenderId", true));
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientsBindingSource, "GenderId", true));
            this.genderIdComboBox.DataSource = this.gendersBindingSource;
            this.genderIdComboBox.DisplayMember = "GenderName";
            this.genderIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(233, 64);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderIdComboBox.TabIndex = 4;
            this.genderIdComboBox.ValueMember = "IdGender";
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataMember = "Genders";
            this.gendersBindingSource.DataSource = this.shapkin_clinicDataSet;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(233, 91);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthDateDateTimePicker.TabIndex = 6;
            // 
            // insurancePolicyTextBox
            // 
            this.insurancePolicyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "InsurancePolicy", true));
            this.insurancePolicyTextBox.Location = new System.Drawing.Point(233, 119);
            this.insurancePolicyTextBox.MaxLength = 50;
            this.insurancePolicyTextBox.Name = "insurancePolicyTextBox";
            this.insurancePolicyTextBox.Size = new System.Drawing.Size(200, 22);
            this.insurancePolicyTextBox.TabIndex = 8;
            // 
            // fluragrafiaDateDateTimePicker
            // 
            this.fluragrafiaDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "FluragrafiaDate", true));
            this.fluragrafiaDateDateTimePicker.Location = new System.Drawing.Point(233, 147);
            this.fluragrafiaDateDateTimePicker.Name = "fluragrafiaDateDateTimePicker";
            this.fluragrafiaDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fluragrafiaDateDateTimePicker.TabIndex = 10;
            // 
            // dIspanserizaciaDateDateTimePicker
            // 
            this.dIspanserizaciaDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "DIspanserizaciaDate", true));
            this.dIspanserizaciaDateDateTimePicker.Location = new System.Drawing.Point(233, 175);
            this.dIspanserizaciaDateDateTimePicker.Name = "dIspanserizaciaDateDateTimePicker";
            this.dIspanserizaciaDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dIspanserizaciaDateDateTimePicker.TabIndex = 12;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "Height", true));
            this.heightNumericUpDown.Location = new System.Drawing.Point(233, 203);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.heightNumericUpDown.TabIndex = 14;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "Weight", true));
            this.weightNumericUpDown.Location = new System.Drawing.Point(233, 231);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.weightNumericUpDown.TabIndex = 16;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(233, 371);
            this.photoTextBox.MaxLength = 50;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(200, 22);
            this.photoTextBox.TabIndex = 22;
            // 
            // gendersTableAdapter
            // 
            this.gendersTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Red;
            this.saveButton.Location = new System.Drawing.Point(100, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(333, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // invalidnostToggleButton
            // 
            this.invalidnostToggleButton.Location = new System.Drawing.Point(6, 19);
            this.invalidnostToggleButton.Name = "invalidnostToggleButton";
            this.invalidnostToggleButton.Size = new System.Drawing.Size(148, 23);
            this.invalidnostToggleButton.TabIndex = 21;
            this.invalidnostToggleButton.Text = "Имеется инвалидность";
            this.invalidnostToggleButton.UseVisualStyleBackColor = true;
            this.invalidnostToggleButton.Click += new System.EventHandler(this.invalidnostToggleButton_Click);
            // 
            // CreateUpdatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(539, 570);
            this.Name = "CreateUpdatePatientForm";
            this.Load += new System.EventHandler(this.CreateUpdatePatientForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.invalidnostGroupBox.ResumeLayout(false);
            this.invalidnostGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidnostGroupNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox invalidnostGroupBox;
        private Shapkin_clinicDataSet shapkin_clinicDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Shapkin_clinicDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private Shapkin_clinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.ComboBox genderIdComboBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox insurancePolicyTextBox;
        private System.Windows.Forms.DateTimePicker fluragrafiaDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dIspanserizaciaDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.NumericUpDown invalidnostGroupNumericUpDown;
        private System.Windows.Forms.DateTimePicker invalidnostGroupDateDateTimePicker;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private Shapkin_clinicDataSetTableAdapters.GendersTableAdapter gendersTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button invalidnostToggleButton;
    }
}
