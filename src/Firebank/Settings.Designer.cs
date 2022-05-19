
namespace Firebank
{
    partial class Settings
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsTitle = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NIFTextBox = new System.Windows.Forms.TextBox();
            this.NIFLabel = new System.Windows.Forms.Label();
            this.CCTextBox = new System.Windows.Forms.TextBox();
            this.CCLabel = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.is2FAActivated = new Firebank.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.AutoSize = true;
            this.SettingsTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.SettingsTitle.Location = new System.Drawing.Point(8, 18);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Size = new System.Drawing.Size(139, 32);
            this.SettingsTitle.TabIndex = 30;
            this.SettingsTitle.Text = "Settings";
            this.SettingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.UsernameLabel.Location = new System.Drawing.Point(11, 89);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(98, 18);
            this.UsernameLabel.TabIndex = 31;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(14, 127);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(133, 20);
            this.UsernameTextBox.TabIndex = 32;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(354, 127);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ReadOnly = true;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(133, 20);
            this.PhoneNumberTextBox.TabIndex = 34;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(351, 89);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(139, 18);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Location = new System.Drawing.Point(14, 225);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.ReadOnly = true;
            this.BirthdayTextBox.Size = new System.Drawing.Size(133, 20);
            this.BirthdayTextBox.TabIndex = 36;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.BirthdayLabel.Location = new System.Drawing.Point(11, 187);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(82, 18);
            this.BirthdayLabel.TabIndex = 35;
            this.BirthdayLabel.Text = "Birthday";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(186, 127);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(133, 20);
            this.EmailTextBox.TabIndex = 38;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmailLabel.Location = new System.Drawing.Point(183, 89);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(54, 18);
            this.EmailLabel.TabIndex = 37;
            this.EmailLabel.Text = "Email";
            // 
            // NIFTextBox
            // 
            this.NIFTextBox.Location = new System.Drawing.Point(186, 225);
            this.NIFTextBox.Name = "NIFTextBox";
            this.NIFTextBox.ReadOnly = true;
            this.NIFTextBox.Size = new System.Drawing.Size(133, 20);
            this.NIFTextBox.TabIndex = 40;
            // 
            // NIFLabel
            // 
            this.NIFLabel.AutoSize = true;
            this.NIFLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIFLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.NIFLabel.Location = new System.Drawing.Point(183, 187);
            this.NIFLabel.Name = "NIFLabel";
            this.NIFLabel.Size = new System.Drawing.Size(117, 18);
            this.NIFLabel.TabIndex = 39;
            this.NIFLabel.Text = "Tax Number";
            // 
            // CCTextBox
            // 
            this.CCTextBox.Location = new System.Drawing.Point(354, 225);
            this.CCTextBox.Name = "CCTextBox";
            this.CCTextBox.ReadOnly = true;
            this.CCTextBox.Size = new System.Drawing.Size(133, 20);
            this.CCTextBox.TabIndex = 42;
            // 
            // CCLabel
            // 
            this.CCLabel.AutoSize = true;
            this.CCLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CCLabel.Location = new System.Drawing.Point(351, 187);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Size = new System.Drawing.Size(32, 18);
            this.CCLabel.TabIndex = 41;
            this.CCLabel.Text = "CC";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.ChangePasswordButton.FlatAppearance.BorderSize = 2;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ChangePasswordButton.Location = new System.Drawing.Point(14, 271);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(133, 49);
            this.ChangePasswordButton.TabIndex = 43;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.LogoutButton.FlatAppearance.BorderSize = 2;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.LogoutButton.Location = new System.Drawing.Point(401, 338);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(86, 39);
            this.LogoutButton.TabIndex = 44;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // is2FAActivated
            // 
            this.is2FAActivated.AutoSize = true;
            this.is2FAActivated.Location = new System.Drawing.Point(442, 284);
            this.is2FAActivated.MinimumSize = new System.Drawing.Size(45, 22);
            this.is2FAActivated.Name = "is2FAActivated";
            this.is2FAActivated.OffBackColor = System.Drawing.Color.White;
            this.is2FAActivated.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.is2FAActivated.OnBackColor = System.Drawing.Color.White;
            this.is2FAActivated.OnToggleColor = System.Drawing.Color.OrangeRed;
            this.is2FAActivated.Size = new System.Drawing.Size(45, 22);
            this.is2FAActivated.TabIndex = 46;
            this.is2FAActivated.UseVisualStyleBackColor = true;
            this.is2FAActivated.Click += new System.EventHandler(this.is2FAActivated_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(266, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Activate 2FA Email";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.is2FAActivated);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.CCTextBox);
            this.Controls.Add(this.CCLabel);
            this.Controls.Add(this.NIFTextBox);
            this.Controls.Add(this.NIFLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.BirthdayTextBox);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SettingsTitle);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(503, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SettingsTitle;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NIFTextBox;
        private System.Windows.Forms.Label NIFLabel;
        private System.Windows.Forms.TextBox CCTextBox;
        private System.Windows.Forms.Label CCLabel;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button LogoutButton;
        private ToggleSwitch is2FAActivated;
        private System.Windows.Forms.Label label1;
    }
}
