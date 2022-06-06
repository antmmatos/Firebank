namespace Firebank
{
    partial class VerificationSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationSystem));
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.VerifyLabel = new System.Windows.Forms.Label();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.VerifyEmailCodeTextBox = new System.Windows.Forms.TextBox();
            this.VerifyEmailButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl1.Location = new System.Drawing.Point(27, 392);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(223, 49);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 638);
            this.panel1.TabIndex = 13;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(32, 197);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(210, 182);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerificationLabel.Location = new System.Drawing.Point(318, 18);
            this.VerificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(286, 49);
            this.VerificationLabel.TabIndex = 14;
            this.VerificationLabel.Text = "Verification";
            this.VerificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerifyLabel
            // 
            this.VerifyLabel.AutoSize = true;
            this.VerifyLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerifyLabel.Location = new System.Drawing.Point(321, 91);
            this.VerifyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerifyLabel.Name = "VerifyLabel";
            this.VerifyLabel.Size = new System.Drawing.Size(302, 35);
            this.VerifyLabel.TabIndex = 15;
            this.VerifyLabel.Text = "Email Verification";
            this.VerifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLabel.ForeColor = System.Drawing.Color.Black;
            this.CheckLabel.Location = new System.Drawing.Point(322, 145);
            this.CheckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(386, 25);
            this.CheckLabel.TabIndex = 16;
            this.CheckLabel.Text = "Enter the code sent to your email";
            this.CheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerifyEmailCodeTextBox
            // 
            this.VerifyEmailCodeTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyEmailCodeTextBox.Location = new System.Drawing.Point(327, 197);
            this.VerifyEmailCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerifyEmailCodeTextBox.Name = "VerifyEmailCodeTextBox";
            this.VerifyEmailCodeTextBox.Size = new System.Drawing.Size(193, 42);
            this.VerifyEmailCodeTextBox.TabIndex = 17;
            // 
            // VerifyEmailButton
            // 
            this.VerifyEmailButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.VerifyEmailButton.FlatAppearance.BorderSize = 2;
            this.VerifyEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyEmailButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyEmailButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerifyEmailButton.Location = new System.Drawing.Point(327, 269);
            this.VerifyEmailButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerifyEmailButton.Name = "VerifyEmailButton";
            this.VerifyEmailButton.Size = new System.Drawing.Size(144, 65);
            this.VerifyEmailButton.TabIndex = 18;
            this.VerifyEmailButton.Text = "Verify";
            this.VerifyEmailButton.UseVisualStyleBackColor = true;
            this.VerifyEmailButton.Click += new System.EventHandler(this.VerifyEmailButton_Click);
            // 
            // VerificationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 638);
            this.Controls.Add(this.VerifyEmailButton);
            this.Controls.Add(this.VerifyEmailCodeTextBox);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.VerifyLabel);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VerificationSystem";
            this.Text = "VerificationSystem";
            this.Activated += new System.EventHandler(this.VerificationSystem_Activated);
            this.Load += new System.EventHandler(this.VerificationSystem_Load);
            this.VisibleChanged += new System.EventHandler(this.VerificationSystem_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VerificationLabel;
        private System.Windows.Forms.Label VerifyLabel;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.TextBox VerifyEmailCodeTextBox;
        private System.Windows.Forms.Button VerifyEmailButton;
    }
}