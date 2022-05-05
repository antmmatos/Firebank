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
            this.lbl1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.RecoverPasswordButton = new System.Windows.Forms.Button();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl1.Location = new System.Drawing.Point(225, 133);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Firebank";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(85, 261);
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
            this.lbl2.Location = new System.Drawing.Point(163, 165);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(271, 32);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Forgot Password";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(82, 245);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(131, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Username or Email";
            // 
            // logo
            // 
            this.logo.Image = global::Firebank.Properties.Resources.firebank;
            this.logo.Location = new System.Drawing.Point(228, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 118);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.BackColor = System.Drawing.Color.OrangeRed;
            this.RecoverPasswordButton.FlatAppearance.BorderSize = 0;
            this.RecoverPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecoverPasswordButton.ForeColor = System.Drawing.Color.White;
            this.RecoverPasswordButton.Location = new System.Drawing.Point(100, 331);
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
            this.VerifyButton.Location = new System.Drawing.Point(355, 331);
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
            this.CodeTextBox.Location = new System.Drawing.Point(340, 261);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(173, 21);
            this.CodeTextBox.TabIndex = 8;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Verification Code";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(596, 422);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecoverPasswordButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ForgotPassword";
            this.Text = "Firebank - Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button RecoverPasswordButton;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label label1;
    }
}

