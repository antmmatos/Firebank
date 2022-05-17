
namespace Firebank
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AccountManagementButton = new System.Windows.Forms.Button();
            this.CardsManagementButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ComboBox();
            this.BalanceLabelValue = new System.Windows.Forms.Label();
            this.StatementLabel = new System.Windows.Forms.Label();
            this.OpenStatementButton = new System.Windows.Forms.Button();
            this.CardsManagement = new Firebank.CardsUserControl();
            this.AccountsManagement = new Firebank.AccountsUserControl();
            this.SettingsUserControl = new Firebank.Settings();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.AccountManagementButton);
            this.panel1.Controls.Add(this.CardsManagementButton);
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
            this.AccountManagementButton.Click += new System.EventHandler(this.AccountsManagementButton_Click);
            // 
            // CardsManagementButton
            // 
            this.CardsManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardsManagementButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.CardsManagementButton.FlatAppearance.BorderSize = 2;
            this.CardsManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardsManagementButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsManagementButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardsManagementButton.Location = new System.Drawing.Point(21, 235);
            this.CardsManagementButton.Name = "CardsManagementButton";
            this.CardsManagementButton.Size = new System.Drawing.Size(140, 44);
            this.CardsManagementButton.TabIndex = 15;
            this.CardsManagementButton.Text = "Cards Management";
            this.CardsManagementButton.UseVisualStyleBackColor = true;
            this.CardsManagementButton.Click += new System.EventHandler(this.CardsManagementButton_Click);
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
            this.lbl1.Size = new System.Drawing.Size(146, 32);
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
            this.WelcomeLabel.Size = new System.Drawing.Size(153, 32);
            this.WelcomeLabel.TabIndex = 13;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.BalanceLabel.Location = new System.Drawing.Point(213, 187);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(104, 25);
            this.BalanceLabel.TabIndex = 14;
            this.BalanceLabel.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(212, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account";
            // 
            // AccountList
            // 
            this.AccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountList.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountList.FormattingEnabled = true;
            this.AccountList.Items.AddRange(new object[] {
            "erty",
            "werty"});
            this.AccountList.Location = new System.Drawing.Point(218, 112);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(406, 31);
            this.AccountList.TabIndex = 16;
            this.AccountList.SelectedIndexChanged += new System.EventHandler(this.AccountList_SelectedIndexChanged);
            // 
            // BalanceLabelValue
            // 
            this.BalanceLabelValue.AutoSize = true;
            this.BalanceLabelValue.BackColor = System.Drawing.SystemColors.Control;
            this.BalanceLabelValue.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.BalanceLabelValue.Location = new System.Drawing.Point(211, 235);
            this.BalanceLabelValue.Name = "BalanceLabelValue";
            this.BalanceLabelValue.Size = new System.Drawing.Size(144, 38);
            this.BalanceLabelValue.TabIndex = 17;
            this.BalanceLabelValue.Text = "€00.00";
            // 
            // StatementLabel
            // 
            this.StatementLabel.AutoSize = true;
            this.StatementLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatementLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.StatementLabel.Location = new System.Drawing.Point(427, 187);
            this.StatementLabel.Name = "StatementLabel";
            this.StatementLabel.Size = new System.Drawing.Size(237, 25);
            this.StatementLabel.TabIndex = 18;
            this.StatementLabel.Text = "Account Statement";
            // 
            // OpenStatementButton
            // 
            this.OpenStatementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenStatementButton.Enabled = false;
            this.OpenStatementButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.OpenStatementButton.FlatAppearance.BorderSize = 2;
            this.OpenStatementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenStatementButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenStatementButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.OpenStatementButton.Location = new System.Drawing.Point(432, 235);
            this.OpenStatementButton.Name = "OpenStatementButton";
            this.OpenStatementButton.Size = new System.Drawing.Size(163, 64);
            this.OpenStatementButton.TabIndex = 19;
            this.OpenStatementButton.Text = "Statement";
            this.OpenStatementButton.UseVisualStyleBackColor = true;
            this.OpenStatementButton.Click += new System.EventHandler(this.OpenStatementButton_Click);
            // 
            // CardsManagement
            // 
            this.CardsManagement.Location = new System.Drawing.Point(218, 12);
            this.CardsManagement.Name = "CardsManagement";
            this.CardsManagement.Size = new System.Drawing.Size(503, 391);
            this.CardsManagement.TabIndex = 21;
            this.CardsManagement.Visible = false;
            // 
            // AccountsManagement
            // 
            this.AccountsManagement.Location = new System.Drawing.Point(218, 12);
            this.AccountsManagement.Name = "AccountsManagement";
            this.AccountsManagement.Size = new System.Drawing.Size(503, 391);
            this.AccountsManagement.TabIndex = 20;
            this.AccountsManagement.Visible = false;
            // 
            // SettingsUserControl
            // 
            this.SettingsUserControl.Location = new System.Drawing.Point(218, 12);
            this.SettingsUserControl.Name = "SettingsUserControl";
            this.SettingsUserControl.Size = new System.Drawing.Size(503, 391);
            this.SettingsUserControl.TabIndex = 22;
            this.SettingsUserControl.Visible = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 415);
            this.Controls.Add(this.CardsManagement);
            this.Controls.Add(this.SettingsUserControl);
            this.Controls.Add(this.AccountsManagement);
            this.Controls.Add(this.OpenStatementButton);
            this.Controls.Add(this.StatementLabel);
            this.Controls.Add(this.BalanceLabelValue);
            this.Controls.Add(this.AccountList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Homepage";
            this.Text = "Firebank - Homepage";
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
        private System.Windows.Forms.Button CardsManagementButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AccountList;
        private System.Windows.Forms.Label BalanceLabelValue;
        private System.Windows.Forms.Label StatementLabel;
        private System.Windows.Forms.Button OpenStatementButton;
        private AccountsUserControl AccountsManagement;
        private CardsUserControl CardsManagement;
        private Settings SettingsUserControl;
    }
}