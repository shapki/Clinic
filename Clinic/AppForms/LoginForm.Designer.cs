namespace Clinic.AppForms
{
    partial class LoginForm
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.shapkin_clinicDataSet = new Clinic.Shapkin_clinicDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Clinic.Shapkin_clinicDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Clinic.Shapkin_clinicDataSetTableAdapters.TableAdapterManager();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.guestLoginButton = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guestLoginButton);
            this.splitContainer1.Panel2.Controls.Add(this.loginButton);
            this.splitContainer1.Panel2.Controls.Add(loginLabel);
            this.splitContainer1.Panel2.Controls.Add(this.loginTextBox);
            this.splitContainer1.Panel2.Controls.Add(passwordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passwordTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(539, 450);
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(138, 105);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(40, 13);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(138, 133);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(47, 13);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль";
            // 
            // shapkin_clinicDataSet
            // 
            this.shapkin_clinicDataSet.DataSetName = "Shapkin_clinicDataSet";
            this.shapkin_clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.shapkin_clinicDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GendersTableAdapter = null;
            this.tableAdapterManager.MedicsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinic.Shapkin_clinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.VisitsTableAdapter = null;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(203, 102);
            this.loginTextBox.MaxLength = 50;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(186, 22);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(203, 130);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(186, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(141, 158);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(248, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guestLoginButton
            // 
            this.guestLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.guestLoginButton.Location = new System.Drawing.Point(427, 291);
            this.guestLoginButton.Name = "guestLoginButton";
            this.guestLoginButton.Size = new System.Drawing.Size(100, 23);
            this.guestLoginButton.TabIndex = 5;
            this.guestLoginButton.Text = "Войти как гость";
            this.guestLoginButton.UseVisualStyleBackColor = false;
            this.guestLoginButton.Click += new System.EventHandler(this.guestLoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Name = "LoginForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapkin_clinicDataSet shapkin_clinicDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Shapkin_clinicDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Shapkin_clinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button guestLoginButton;
    }
}