namespace Firebank
{
    partial class ForgotPassword
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.RecoverPasswordButton = new System.Windows.Forms.Button();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.VerificationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.VerificationTypeLabel = new System.Windows.Forms.Label();
            this.AutomaticPhoneCodeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(218, 146);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(173, 21);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl3.Location = new System.Drawing.Point(215, 130);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(160, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Email or Phone Number";
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.BackColor = System.Drawing.Color.OrangeRed;
            this.RecoverPasswordButton.FlatAppearance.BorderSize = 0;
            this.RecoverPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecoverPasswordButton.ForeColor = System.Drawing.Color.White;
            this.RecoverPasswordButton.Location = new System.Drawing.Point(218, 193);
            this.RecoverPasswordButton.Name = "RecoverPasswordButton";
            this.RecoverPasswordButton.Size = new System.Drawing.Size(140, 58);
            this.RecoverPasswordButton.TabIndex = 7;
            this.RecoverPasswordButton.Text = "Recover Password";
            this.RecoverPasswordButton.UseVisualStyleBackColor = false;
            this.RecoverPasswordButton.Click += new System.EventHandler(this.RecoverPasswordButton_Click);
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.OrangeRed;
            this.VerifyButton.Enabled = false;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.ForeColor = System.Drawing.Color.White;
            this.VerifyButton.Location = new System.Drawing.Point(218, 341);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(140, 58);
            this.VerifyButton.TabIndex = 10;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeTextBox.Enabled = false;
            this.CodeTextBox.Location = new System.Drawing.Point(218, 296);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(173, 21);
            this.CodeTextBox.TabIndex = 8;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(215, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Verification Code";
            // 
            // logo
            // 
            this.logo.Image = global::Firebank.Properties.Resources.firebank;
            this.logo.Location = new System.Drawing.Point(18, 132);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 118);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl1.Location = new System.Drawing.Point(15, 259);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Firebank";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 422);
            this.panel1.TabIndex = 11;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(212, 24);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(270, 32);
            this.ForgotPasswordLabel.TabIndex = 12;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            this.ForgotPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerificationTypeComboBox
            // 
            this.VerificationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerificationTypeComboBox.FormattingEnabled = true;
            this.VerificationTypeComboBox.Items.AddRange(new object[] {
            "Mobile Phone",
            "Email"});
            this.VerificationTypeComboBox.Location = new System.Drawing.Point(218, 83);
            this.VerificationTypeComboBox.Name = "VerificationTypeComboBox";
            this.VerificationTypeComboBox.Size = new System.Drawing.Size(173, 21);
            this.VerificationTypeComboBox.TabIndex = 13;
            this.VerificationTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.VerificationTypeComboBox_SelectedIndexChanged);
            // 
            // VerificationTypeLabel
            // 
            this.VerificationTypeLabel.AutoSize = true;
            this.VerificationTypeLabel.BackColor = System.Drawing.Color.White;
            this.VerificationTypeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerificationTypeLabel.Location = new System.Drawing.Point(215, 67);
            this.VerificationTypeLabel.Name = "VerificationTypeLabel";
            this.VerificationTypeLabel.Size = new System.Drawing.Size(118, 13);
            this.VerificationTypeLabel.TabIndex = 14;
            this.VerificationTypeLabel.Text = "Verification Type";
            // 
            // AutomaticPhoneCodeCheckBox
            // 
            this.AutomaticPhoneCodeCheckBox.AutoSize = true;
            this.AutomaticPhoneCodeCheckBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.AutomaticPhoneCodeCheckBox.Location = new System.Drawing.Point(218, 170);
            this.AutomaticPhoneCodeCheckBox.Name = "AutomaticPhoneCodeCheckBox";
            this.AutomaticPhoneCodeCheckBox.Size = new System.Drawing.Size(222, 17);
            this.AutomaticPhoneCodeCheckBox.TabIndex = 15;
            this.AutomaticPhoneCodeCheckBox.Text = "Get Phone Code Automatically";
            this.AutomaticPhoneCodeCheckBox.UseVisualStyleBackColor = true;
            this.AutomaticPhoneCodeCheckBox.Visible = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 422);
            this.Controls.Add(this.AutomaticPhoneCodeCheckBox);
            this.Controls.Add(this.VerificationTypeLabel);
            this.Controls.Add(this.VerificationTypeComboBox);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecoverPasswordButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.lbl3);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ForgotPassword";
            this.Text = "Firebank - Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button RecoverPasswordButton;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private System.Windows.Forms.ComboBox VerificationTypeComboBox;
        private System.Windows.Forms.Label VerificationTypeLabel;
        private System.Windows.Forms.CheckBox AutomaticPhoneCodeCheckBox;
    }
}

