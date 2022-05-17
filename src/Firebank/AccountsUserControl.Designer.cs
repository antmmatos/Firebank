
namespace Firebank
{
    partial class AccountsUserControl
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
            this.addAccountButton = new System.Windows.Forms.Button();
            this.iBanLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.AccountBalance = new System.Windows.Forms.Label();
            this.AccountIDLabel = new System.Windows.Forms.Label();
            this.AccountiBanLabel = new System.Windows.Forms.Label();
            this.AccountsComboBox = new System.Windows.Forms.ComboBox();
            this.AccountSelectorLabel = new System.Windows.Forms.Label();
            this.AccountsManagementTitle = new System.Windows.Forms.Label();
            this.ChangeAccountNameLabel = new System.Windows.Forms.Label();
            this.NewNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAccountButton
            // 
            this.addAccountButton.FlatAppearance.BorderSize = 2;
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.addAccountButton.Location = new System.Drawing.Point(370, 35);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(124, 47);
            this.addAccountButton.TabIndex = 43;
            this.addAccountButton.Text = "Request Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // iBanLabel
            // 
            this.iBanLabel.AutoSize = true;
            this.iBanLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.iBanLabel.Location = new System.Drawing.Point(11, 225);
            this.iBanLabel.Name = "iBanLabel";
            this.iBanLabel.Size = new System.Drawing.Size(79, 16);
            this.iBanLabel.TabIndex = 37;
            this.iBanLabel.Text = "iBanLabel";
            this.iBanLabel.Visible = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.IDLabel.Location = new System.Drawing.Point(270, 225);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(63, 16);
            this.IDLabel.TabIndex = 38;
            this.IDLabel.Text = "IDLabel";
            this.IDLabel.Visible = false;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.BalanceLabel.Location = new System.Drawing.Point(11, 326);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(105, 16);
            this.BalanceLabel.TabIndex = 36;
            this.BalanceLabel.Text = "BalanceLabel";
            this.BalanceLabel.Visible = false;
            // 
            // AccountBalance
            // 
            this.AccountBalance.AutoSize = true;
            this.AccountBalance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalance.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountBalance.Location = new System.Drawing.Point(10, 282);
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(95, 23);
            this.AccountBalance.TabIndex = 35;
            this.AccountBalance.Text = "Balance";
            // 
            // AccountIDLabel
            // 
            this.AccountIDLabel.AutoSize = true;
            this.AccountIDLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountIDLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountIDLabel.Location = new System.Drawing.Point(269, 186);
            this.AccountIDLabel.Name = "AccountIDLabel";
            this.AccountIDLabel.Size = new System.Drawing.Size(36, 23);
            this.AccountIDLabel.TabIndex = 34;
            this.AccountIDLabel.Text = "ID";
            // 
            // AccountiBanLabel
            // 
            this.AccountiBanLabel.AutoSize = true;
            this.AccountiBanLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountiBanLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountiBanLabel.Location = new System.Drawing.Point(10, 186);
            this.AccountiBanLabel.Name = "AccountiBanLabel";
            this.AccountiBanLabel.Size = new System.Drawing.Size(58, 23);
            this.AccountiBanLabel.TabIndex = 33;
            this.AccountiBanLabel.Text = "iBan";
            // 
            // AccountsComboBox
            // 
            this.AccountsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountsComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsComboBox.FormattingEnabled = true;
            this.AccountsComboBox.Items.AddRange(new object[] {
            "---"});
            this.AccountsComboBox.Location = new System.Drawing.Point(14, 118);
            this.AccountsComboBox.Name = "AccountsComboBox";
            this.AccountsComboBox.Size = new System.Drawing.Size(406, 31);
            this.AccountsComboBox.TabIndex = 32;
            this.AccountsComboBox.SelectedIndexChanged += new System.EventHandler(this.AccountsComboBox_SelectedIndexChanged);
            // 
            // AccountSelectorLabel
            // 
            this.AccountSelectorLabel.AutoSize = true;
            this.AccountSelectorLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSelectorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountSelectorLabel.Location = new System.Drawing.Point(8, 83);
            this.AccountSelectorLabel.Name = "AccountSelectorLabel";
            this.AccountSelectorLabel.Size = new System.Drawing.Size(153, 32);
            this.AccountSelectorLabel.TabIndex = 31;
            this.AccountSelectorLabel.Text = "Accounts";
            // 
            // AccountsManagementTitle
            // 
            this.AccountsManagementTitle.AutoSize = true;
            this.AccountsManagementTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsManagementTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountsManagementTitle.Location = new System.Drawing.Point(8, 18);
            this.AccountsManagementTitle.Name = "AccountsManagementTitle";
            this.AccountsManagementTitle.Size = new System.Drawing.Size(342, 32);
            this.AccountsManagementTitle.TabIndex = 30;
            this.AccountsManagementTitle.Text = "Acounts Management";
            this.AccountsManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeAccountNameLabel
            // 
            this.ChangeAccountNameLabel.AutoSize = true;
            this.ChangeAccountNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAccountNameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ChangeAccountNameLabel.Location = new System.Drawing.Point(271, 282);
            this.ChangeAccountNameLabel.Name = "ChangeAccountNameLabel";
            this.ChangeAccountNameLabel.Size = new System.Drawing.Size(160, 23);
            this.ChangeAccountNameLabel.TabIndex = 44;
            this.ChangeAccountNameLabel.Text = "Change Name";
            // 
            // NewNameTextBox
            // 
            this.NewNameTextBox.Location = new System.Drawing.Point(273, 316);
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.NewNameTextBox.TabIndex = 45;
            this.NewNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.FlatAppearance.BorderSize = 2;
            this.ChangeNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNameButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ChangeNameButton.Location = new System.Drawing.Point(273, 342);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(154, 28);
            this.ChangeNameButton.TabIndex = 46;
            this.ChangeNameButton.Text = "Change";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // AccountsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.NewNameTextBox);
            this.Controls.Add(this.ChangeAccountNameLabel);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.iBanLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.AccountBalance);
            this.Controls.Add(this.AccountIDLabel);
            this.Controls.Add(this.AccountiBanLabel);
            this.Controls.Add(this.AccountsComboBox);
            this.Controls.Add(this.AccountSelectorLabel);
            this.Controls.Add(this.AccountsManagementTitle);
            this.Name = "AccountsUserControl";
            this.Size = new System.Drawing.Size(503, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Label iBanLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label AccountBalance;
        private System.Windows.Forms.Label AccountIDLabel;
        private System.Windows.Forms.Label AccountiBanLabel;
        private System.Windows.Forms.ComboBox AccountsComboBox;
        private System.Windows.Forms.Label AccountSelectorLabel;
        private System.Windows.Forms.Label AccountsManagementTitle;
        private System.Windows.Forms.Label ChangeAccountNameLabel;
        private System.Windows.Forms.TextBox NewNameTextBox;
        private System.Windows.Forms.Button ChangeNameButton;
    }
}
