namespace Clinic.AppForms
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.birthDateSortLabel = new System.Windows.Forms.Label();
            this.birthDateSortComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.addPatientButton);
            this.splitContainer1.Panel1.Controls.Add(this.searchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.searchLabel);
            this.splitContainer1.Panel1.Controls.Add(this.genderComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.genderLabel);
            this.splitContainer1.Panel1.Controls.Add(this.birthDateSortComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.birthDateSortLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 326);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // birthDateSortLabel
            // 
            this.birthDateSortLabel.AutoSize = true;
            this.birthDateSortLabel.Location = new System.Drawing.Point(121, 89);
            this.birthDateSortLabel.Name = "birthDateSortLabel";
            this.birthDateSortLabel.Size = new System.Drawing.Size(106, 13);
            this.birthDateSortLabel.TabIndex = 5;
            this.birthDateSortLabel.Text = "Сортировка по ДР";
            this.birthDateSortLabel.Visible = false;
            // 
            // birthDateSortComboBox
            // 
            this.birthDateSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birthDateSortComboBox.FormattingEnabled = true;
            this.birthDateSortComboBox.Items.AddRange(new object[] {
            "Не использовать",
            "По возрастанию",
            "По убыванию"});
            this.birthDateSortComboBox.Location = new System.Drawing.Point(233, 86);
            this.birthDateSortComboBox.Name = "birthDateSortComboBox";
            this.birthDateSortComboBox.Size = new System.Drawing.Size(151, 21);
            this.birthDateSortComboBox.TabIndex = 6;
            this.birthDateSortComboBox.Visible = false;
            this.birthDateSortComboBox.SelectedIndexChanged += new System.EventHandler(this.birthDateSortComboBox_SelectedIndexChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(390, 89);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(28, 13);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Пол";
            this.genderLabel.Visible = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Все",
            "Муж",
            "Жен"});
            this.genderComboBox.Location = new System.Drawing.Point(424, 86);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(55, 21);
            this.genderComboBox.TabIndex = 8;
            this.genderComboBox.Visible = false;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(485, 89);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(40, 13);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Поиск";
            this.searchLabel.Visible = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(531, 85);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 22);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.Visible = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.Red;
            this.addPatientButton.Location = new System.Drawing.Point(702, 83);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(95, 23);
            this.addPatientButton.TabIndex = 11;
            this.addPatientButton.Text = "Доб. пациента";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Visible = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox birthDateSortComboBox;
        private System.Windows.Forms.Label birthDateSortLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button addPatientButton;
    }
}
