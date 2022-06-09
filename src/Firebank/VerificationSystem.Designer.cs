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
            this.lbl1.Location = new System.Drawing.Point(18, 255);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 32);
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
            this.panel1.Size = new System.Drawing.Size(180, 415);
            this.panel1.TabIndex = 13;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(21, 128);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 118);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerificationLabel.Location = new System.Drawing.Point(212, 12);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(189, 32);
            this.VerificationLabel.TabIndex = 14;
            this.VerificationLabel.Text = "Verification";
            this.VerificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerifyLabel
            // 
            this.VerifyLabel.AutoSize = true;
            this.VerifyLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerifyLabel.Location = new System.Drawing.Point(214, 59);
            this.VerifyLabel.Name = "VerifyLabel";
            this.VerifyLabel.Size = new System.Drawing.Size(203, 23);
            this.VerifyLabel.TabIndex = 15;
            this.VerifyLabel.Text = "Email Verification";
            this.VerifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLabel.ForeColor = System.Drawing.Color.Black;
            this.CheckLabel.Location = new System.Drawing.Point(215, 94);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(250, 16);
            this.CheckLabel.TabIndex = 16;
            this.CheckLabel.Text = "Enter the code sent to your email";
            this.CheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerifyEmailCodeTextBox
            // 
            this.VerifyEmailCodeTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyEmailCodeTextBox.Location = new System.Drawing.Point(218, 128);
            this.VerifyEmailCodeTextBox.Name = "VerifyEmailCodeTextBox";
            this.VerifyEmailCodeTextBox.Size = new System.Drawing.Size(130, 31);
            this.VerifyEmailCodeTextBox.TabIndex = 17;
            // 
            // VerifyEmailButton
            // 
            this.VerifyEmailButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.VerifyEmailButton.FlatAppearance.BorderSize = 2;
            this.VerifyEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyEmailButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyEmailButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.VerifyEmailButton.Location = new System.Drawing.Point(218, 175);
            this.VerifyEmailButton.Name = "VerifyEmailButton";
            this.VerifyEmailButton.Size = new System.Drawing.Size(96, 42);
            this.VerifyEmailButton.TabIndex = 18;
            this.VerifyEmailButton.Text = "Verify";
            this.VerifyEmailButton.UseVisualStyleBackColor = true;
            this.VerifyEmailButton.Click += new System.EventHandler(this.VerifyEmailButton_Click);
            // 
            // VerificationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 415);
            this.Controls.Add(this.VerifyEmailButton);
            this.Controls.Add(this.VerifyEmailCodeTextBox);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.VerifyLabel);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerificationSystem";
            this.Text = "Verification System";
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