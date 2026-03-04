namespace Clinic.AppControls
{
    partial class PatientUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.visitsHistoryButton = new System.Windows.Forms.Button();
            this.insurancePolicyLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.flurographiaPictureBox = new System.Windows.Forms.PictureBox();
            this.invalidPictureBox = new System.Windows.Forms.PictureBox();
            this.dispancerPictureBox = new System.Windows.Forms.PictureBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flurographiaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispancerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.visitsHistoryButton);
            this.splitContainer1.Panel1.Controls.Add(this.insurancePolicyLabel);
            this.splitContainer1.Panel1.Controls.Add(this.genderLabel);
            this.splitContainer1.Panel1.Controls.Add(this.LastNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.flurographiaPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.invalidPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.dispancerPictureBox);
            this.splitContainer1.Panel1.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.photoPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(775, 148);
            this.splitContainer1.SplitterDistance = 655;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // visitsHistoryButton
            // 
            this.visitsHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.visitsHistoryButton.Location = new System.Drawing.Point(505, 117);
            this.visitsHistoryButton.Name = "visitsHistoryButton";
            this.visitsHistoryButton.Size = new System.Drawing.Size(142, 23);
            this.visitsHistoryButton.TabIndex = 8;
            this.visitsHistoryButton.Text = "История обращений";
            this.visitsHistoryButton.UseVisualStyleBackColor = false;
            this.visitsHistoryButton.Visible = false;
            this.visitsHistoryButton.Click += new System.EventHandler(this.visitsHistoryButton_Click);
            // 
            // insurancePolicyLabel
            // 
            this.insurancePolicyLabel.AutoSize = true;
            this.insurancePolicyLabel.Location = new System.Drawing.Point(5, 132);
            this.insurancePolicyLabel.Name = "insurancePolicyLabel";
            this.insurancePolicyLabel.Size = new System.Drawing.Size(99, 13);
            this.insurancePolicyLabel.TabIndex = 7;
            this.insurancePolicyLabel.Text = "Страховой полис: ";
            this.insurancePolicyLabel.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(5, 68);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(33, 13);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Пол: ";
            this.genderLabel.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(3, 12);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(40, 13);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "ФИО: ";
            this.LastNameLabel.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // flurographiaPictureBox
            // 
            this.flurographiaPictureBox.Image = global::Clinic.Properties.Resources.fluorography;
            this.flurographiaPictureBox.Location = new System.Drawing.Point(505, 65);
            this.flurographiaPictureBox.Name = "flurographiaPictureBox";
            this.flurographiaPictureBox.Size = new System.Drawing.Size(50, 50);
            this.flurographiaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flurographiaPictureBox.TabIndex = 2;
            this.flurographiaPictureBox.TabStop = false;
            this.flurographiaPictureBox.Visible = false;
            this.flurographiaPictureBox.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // invalidPictureBox
            // 
            this.invalidPictureBox.Image = global::Clinic.Properties.Resources.handicaped;
            this.invalidPictureBox.Location = new System.Drawing.Point(561, 9);
            this.invalidPictureBox.Name = "invalidPictureBox";
            this.invalidPictureBox.Size = new System.Drawing.Size(50, 50);
            this.invalidPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invalidPictureBox.TabIndex = 1;
            this.invalidPictureBox.TabStop = false;
            this.invalidPictureBox.Visible = false;
            this.invalidPictureBox.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // dispancerPictureBox
            // 
            this.dispancerPictureBox.Image = global::Clinic.Properties.Resources.dispanser;
            this.dispancerPictureBox.Location = new System.Drawing.Point(505, 9);
            this.dispancerPictureBox.Name = "dispancerPictureBox";
            this.dispancerPictureBox.Size = new System.Drawing.Size(50, 50);
            this.dispancerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dispancerPictureBox.TabIndex = 0;
            this.dispancerPictureBox.TabStop = false;
            this.dispancerPictureBox.Visible = false;
            this.dispancerPictureBox.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Image = global::Clinic.Properties.Resources.photo;
            this.photoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(108, 142);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.PatientUserControl_Click);
            // 
            // PatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PatientUserControl";
            this.Size = new System.Drawing.Size(775, 148);
            this.Click += new System.EventHandler(this.PatientUserControl_Click);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flurographiaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invalidPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispancerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox invalidPictureBox;
        private System.Windows.Forms.PictureBox dispancerPictureBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.PictureBox flurographiaPictureBox;
        private System.Windows.Forms.Label insurancePolicyLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button visitsHistoryButton;
    }
}
