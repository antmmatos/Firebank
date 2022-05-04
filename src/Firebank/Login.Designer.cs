namespace Firebank
{
    partial class Login
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
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl1.Location = new System.Drawing.Point(226, 133);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Firebank";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(213, 249);
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
            this.lbl2.Location = new System.Drawing.Point(251, 165);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 32);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Login";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(210, 233);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(73, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Location = new System.Drawing.Point(213, 322);
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
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(210, 306);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 13);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Password";
            // 
            // logo
            // 
            this.logo.Image = global::Firebank.Properties.Resources.firebank_original;
            this.logo.Location = new System.Drawing.Point(228, 2);
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
            this.LoginButton.Location = new System.Drawing.Point(228, 386);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 58);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(596, 496);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Firebank - Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
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
    }
}

