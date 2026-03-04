namespace Clinic.AppControls
{
    partial class VisitUserControl
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.specialistLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(32, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата";
            // 
            // specialistLabel
            // 
            this.specialistLabel.AutoSize = true;
            this.specialistLabel.Location = new System.Drawing.Point(3, 46);
            this.specialistLabel.Name = "specialistLabel";
            this.specialistLabel.Size = new System.Drawing.Size(70, 13);
            this.specialistLabel.TabIndex = 1;
            this.specialistLabel.Text = "Специалист";
            // 
            // VisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.specialistLabel);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "VisitUserControl";
            this.Size = new System.Drawing.Size(775, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label specialistLabel;
    }
}
