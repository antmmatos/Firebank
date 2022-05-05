namespace Firebank
{
    partial class Register
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterPanelButton = new System.Windows.Forms.Button();
            this.LoginPanelButton = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordTextBoxRegister = new System.Windows.Forms.TextBox();
            this.PasswordLabelRegister = new System.Windows.Forms.Label();
            this.UsernameTextBoxRegister = new System.Windows.Forms.TextBox();
            this.UsernameLabelRegister = new System.Windows.Forms.Label();
            this.EmailTextBoxRegister = new System.Windows.Forms.TextBox();
            this.EmailLabelRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl1.Location = new System.Drawing.Point(17, 139);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Firebank";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(222, 139);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(173, 21);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl2.Location = new System.Drawing.Point(216, 41);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(98, 32);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Login";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl3.Location = new System.Drawing.Point(219, 123);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(131, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Username or Email";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Location = new System.Drawing.Point(222, 212);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(173, 21);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl4.Location = new System.Drawing.Point(219, 196);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 13);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Password";
            // 
            // logo
            // 
            this.logo.Image = global::Firebank.Properties.Resources.firebank;
            this.logo.Location = new System.Drawing.Point(20, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 118);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.OrangeRed;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(222, 279);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 58);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(219, 473);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(159, 13);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Don\'t have an account?";
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(240, 439);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(116, 13);
            this.ForgotPasswordLabel.TabIndex = 9;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.RegisterPanelButton);
            this.panel1.Controls.Add(this.LoginPanelButton);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 362);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegisterPanelButton
            // 
            this.RegisterPanelButton.FlatAppearance.BorderSize = 0;
            this.RegisterPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPanelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.RegisterPanelButton.Location = new System.Drawing.Point(23, 289);
            this.RegisterPanelButton.Name = "RegisterPanelButton";
            this.RegisterPanelButton.Size = new System.Drawing.Size(137, 48);
            this.RegisterPanelButton.TabIndex = 12;
            this.RegisterPanelButton.Text = "Register";
            this.RegisterPanelButton.UseVisualStyleBackColor = true;
            this.RegisterPanelButton.Click += new System.EventHandler(this.RegisterPanelButton_Click);
            // 
            // LoginPanelButton
            // 
            this.LoginPanelButton.FlatAppearance.BorderSize = 0;
            this.LoginPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.LoginPanelButton.Location = new System.Drawing.Point(23, 191);
            this.LoginPanelButton.Name = "LoginPanelButton";
            this.LoginPanelButton.Size = new System.Drawing.Size(137, 48);
            this.LoginPanelButton.TabIndex = 11;
            this.LoginPanelButton.Text = "Login";
            this.LoginPanelButton.UseVisualStyleBackColor = true;
            this.LoginPanelButton.Click += new System.EventHandler(this.LoginPanelButton_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line1.Location = new System.Drawing.Point(23, 259);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(137, 6);
            this.line1.TabIndex = 11;
            this.line1.UseVisualStyleBackColor = false;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.EmailTextBoxRegister);
            this.RegisterPanel.Controls.Add(this.EmailLabelRegister);
            this.RegisterPanel.Controls.Add(this.RegisterLabel);
            this.RegisterPanel.Controls.Add(this.RegisterButton);
            this.RegisterPanel.Controls.Add(this.PasswordTextBoxRegister);
            this.RegisterPanel.Controls.Add(this.PasswordLabelRegister);
            this.RegisterPanel.Controls.Add(this.UsernameTextBoxRegister);
            this.RegisterPanel.Controls.Add(this.UsernameLabelRegister);
            this.RegisterPanel.Location = new System.Drawing.Point(195, 12);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(389, 338);
            this.RegisterPanel.TabIndex = 11;
            this.RegisterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RegisterPanel_Paint);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.RegisterLabel.Location = new System.Drawing.Point(21, 29);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(141, 32);
            this.RegisterLabel.TabIndex = 9;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.OrangeRed;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(27, 267);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(140, 58);
            this.RegisterButton.TabIndex = 13;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            // 
            // PasswordTextBoxRegister
            // 
            this.PasswordTextBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBoxRegister.Location = new System.Drawing.Point(27, 216);
            this.PasswordTextBoxRegister.Name = "PasswordTextBoxRegister";
            this.PasswordTextBoxRegister.PasswordChar = '*';
            this.PasswordTextBoxRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBoxRegister.Size = new System.Drawing.Size(173, 21);
            this.PasswordTextBoxRegister.TabIndex = 11;
            this.PasswordTextBoxRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordLabelRegister
            // 
            this.PasswordLabelRegister.AutoSize = true;
            this.PasswordLabelRegister.ForeColor = System.Drawing.Color.OrangeRed;
            this.PasswordLabelRegister.Location = new System.Drawing.Point(24, 200);
            this.PasswordLabelRegister.Name = "PasswordLabelRegister";
            this.PasswordLabelRegister.Size = new System.Drawing.Size(69, 13);
            this.PasswordLabelRegister.TabIndex = 12;
            this.PasswordLabelRegister.Text = "Password";
            // 
            // UsernameTextBoxRegister
            // 
            this.UsernameTextBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBoxRegister.Location = new System.Drawing.Point(27, 100);
            this.UsernameTextBoxRegister.Name = "UsernameTextBoxRegister";
            this.UsernameTextBoxRegister.Size = new System.Drawing.Size(173, 21);
            this.UsernameTextBoxRegister.TabIndex = 8;
            this.UsernameTextBoxRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernameLabelRegister
            // 
            this.UsernameLabelRegister.AutoSize = true;
            this.UsernameLabelRegister.ForeColor = System.Drawing.Color.OrangeRed;
            this.UsernameLabelRegister.Location = new System.Drawing.Point(24, 84);
            this.UsernameLabelRegister.Name = "UsernameLabelRegister";
            this.UsernameLabelRegister.Size = new System.Drawing.Size(73, 13);
            this.UsernameLabelRegister.TabIndex = 10;
            this.UsernameLabelRegister.Text = "Username";
            // 
            // EmailTextBoxRegister
            // 
            this.EmailTextBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBoxRegister.Location = new System.Drawing.Point(27, 159);
            this.EmailTextBoxRegister.Name = "EmailTextBoxRegister";
            this.EmailTextBoxRegister.Size = new System.Drawing.Size(173, 21);
            this.EmailTextBoxRegister.TabIndex = 14;
            this.EmailTextBoxRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailLabelRegister
            // 
            this.EmailLabelRegister.AutoSize = true;
            this.EmailLabelRegister.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmailLabelRegister.Location = new System.Drawing.Point(24, 143);
            this.EmailLabelRegister.Name = "EmailLabelRegister";
            this.EmailLabelRegister.Size = new System.Drawing.Size(43, 13);
            this.EmailLabelRegister.TabIndex = 15;
            this.EmailLabelRegister.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 362);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Register";
            this.Text = "Firebank - Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button line1;
        private System.Windows.Forms.Button LoginPanelButton;
        private System.Windows.Forms.Button RegisterPanelButton;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox PasswordTextBoxRegister;
        private System.Windows.Forms.Label PasswordLabelRegister;
        private System.Windows.Forms.TextBox UsernameTextBoxRegister;
        private System.Windows.Forms.Label UsernameLabelRegister;
        private System.Windows.Forms.TextBox EmailTextBoxRegister;
        private System.Windows.Forms.Label EmailLabelRegister;
    }
}

