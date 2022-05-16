﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.AccountManagementButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ComboBox();
            this.BalanceLabelValue = new System.Windows.Forms.Label();
            this.StatementLabel = new System.Windows.Forms.Label();
            this.OpenStatementButton = new System.Windows.Forms.Button();
            this.AccountsManagement = new Firebank.AccountsUserControl();
            this.CardsManagement = new Firebank.CardsUserControl();
            this.accountsUserControl1 = new Firebank.AccountsUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AccountManagementButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 415);
            this.panel1.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.OrangeRed;
            this.button4.Location = new System.Drawing.Point(21, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 44);
            this.button4.TabIndex = 17;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = true;
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
            this.AccountManagementButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(21, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cards Management";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(21, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Firebank.Properties.Resources.firebank;
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
            this.BalanceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(212, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
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
            // AccountsManagement
            // 
            this.AccountsManagement.Location = new System.Drawing.Point(218, 12);
            this.AccountsManagement.Name = "AccountsManagement";
            this.AccountsManagement.Size = new System.Drawing.Size(503, 391);
            this.AccountsManagement.TabIndex = 21;
            this.AccountsManagement.Visible = false;
            // 
            // CardsManagement
            // 
            this.CardsManagement.Location = new System.Drawing.Point(218, 12);
            this.CardsManagement.Name = "CardsManagement";
            this.CardsManagement.Size = new System.Drawing.Size(503, 391);
            this.CardsManagement.TabIndex = 20;
            this.CardsManagement.Visible = false;
            // 
            // accountsUserControl1
            // 
            this.accountsUserControl1.Location = new System.Drawing.Point(218, 12);
            this.accountsUserControl1.Name = "accountsUserControl1";
            this.accountsUserControl1.Size = new System.Drawing.Size(503, 391);
            this.accountsUserControl1.TabIndex = 21;
            this.accountsUserControl1.Visible = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 415);
            this.Controls.Add(this.accountsUserControl1);
            this.Controls.Add(this.AccountsManagement);
            this.Controls.Add(this.CardsManagement);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AccountManagementButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AccountList;
        private System.Windows.Forms.Label BalanceLabelValue;
        private System.Windows.Forms.Label StatementLabel;
        private System.Windows.Forms.Button OpenStatementButton;
        private CardsUserControl CardsManagement;
        private AccountsUserControl AccountsManagement;
        private AccountsUserControl accountsUserControl1;
    }
}