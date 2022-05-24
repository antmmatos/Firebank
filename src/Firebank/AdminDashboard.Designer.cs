
namespace Firebank
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AccountManagementButton = new System.Windows.Forms.Button();
            this.UsersManagementButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SettingsUserControl = new Firebank.Settings();
            this.UsersUserControl = new Firebank.UsersUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.AccountManagementButton);
            this.panel1.Controls.Add(this.UsersManagementButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 415);
            this.panel1.TabIndex = 12;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.SettingsButton.FlatAppearance.BorderSize = 2;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.SettingsButton.Location = new System.Drawing.Point(21, 349);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(140, 44);
            this.SettingsButton.TabIndex = 17;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AccountManagementButton
            // 
            this.AccountManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountManagementButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.AccountManagementButton.FlatAppearance.BorderSize = 2;
            this.AccountManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountManagementButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountManagementButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountManagementButton.Location = new System.Drawing.Point(21, 292);
            this.AccountManagementButton.Name = "AccountManagementButton";
            this.AccountManagementButton.Size = new System.Drawing.Size(140, 44);
            this.AccountManagementButton.TabIndex = 16;
            this.AccountManagementButton.Text = "Accounts Management";
            this.AccountManagementButton.UseVisualStyleBackColor = true;
            // 
            // UsersManagementButton
            // 
            this.UsersManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersManagementButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.UsersManagementButton.FlatAppearance.BorderSize = 2;
            this.UsersManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersManagementButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersManagementButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.UsersManagementButton.Location = new System.Drawing.Point(21, 235);
            this.UsersManagementButton.Name = "UsersManagementButton";
            this.UsersManagementButton.Size = new System.Drawing.Size(140, 44);
            this.UsersManagementButton.TabIndex = 15;
            this.UsersManagementButton.Text = "Users Management";
            this.UsersManagementButton.UseVisualStyleBackColor = true;
            this.UsersManagementButton.Click += new System.EventHandler(this.UsersManagementButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.HomeButton.FlatAppearance.BorderSize = 2;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.HomeButton.Location = new System.Drawing.Point(21, 180);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(140, 44);
            this.HomeButton.TabIndex = 14;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(21, 12);
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
            this.lbl1.Location = new System.Drawing.Point(18, 139);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Firebank";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.WelcomeLabel.Location = new System.Drawing.Point(212, 12);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(154, 32);
            this.WelcomeLabel.TabIndex = 13;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsUserControl
            // 
            this.SettingsUserControl.Location = new System.Drawing.Point(218, 12);
            this.SettingsUserControl.Name = "SettingsUserControl";
            this.SettingsUserControl.Size = new System.Drawing.Size(503, 391);
            this.SettingsUserControl.TabIndex = 14;
            this.SettingsUserControl.Visible = false;
            // 
            // UsersUserControl
            // 
            this.UsersUserControl.Location = new System.Drawing.Point(218, 12);
            this.UsersUserControl.Name = "UsersUserControl";
            this.UsersUserControl.Size = new System.Drawing.Size(503, 391);
            this.UsersUserControl.TabIndex = 15;
            this.UsersUserControl.Visible = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 415);
            this.Controls.Add(this.UsersUserControl);
            this.Controls.Add(this.SettingsUserControl);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminDashboard";
            this.Text = "Firebank - Administrative Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button AccountManagementButton;
        private System.Windows.Forms.Button UsersManagementButton;
        private System.Windows.Forms.Button SettingsButton;
        private Settings SettingsUserControl;
        private UsersUserControl UsersUserControl;
    }
}