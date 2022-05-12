
namespace Firebank
{
    partial class CardsUserControl
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
            this.addCardButton = new System.Windows.Forms.Button();
            this.isActivated = new System.Windows.Forms.Label();
            this.isFreeze = new System.Windows.Forms.Label();
            this.ActivateButton = new System.Windows.Forms.Button();
            this.FreezeButton = new System.Windows.Forms.Button();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.EDLabel = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.CardCVVLabel = new System.Windows.Forms.Label();
            this.CardExpireDate = new System.Windows.Forms.Label();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.CardsComboBox = new System.Windows.Forms.ComboBox();
            this.CardSelectorLabel = new System.Windows.Forms.Label();
            this.CardsManagementTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCardButton
            // 
            this.addCardButton.FlatAppearance.BorderSize = 2;
            this.addCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCardButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.addCardButton.Location = new System.Drawing.Point(370, 35);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(124, 47);
            this.addCardButton.TabIndex = 43;
            this.addCardButton.Text = "Request Card";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // isActivated
            // 
            this.isActivated.AutoSize = true;
            this.isActivated.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActivated.ForeColor = System.Drawing.Color.Green;
            this.isActivated.Location = new System.Drawing.Point(358, 298);
            this.isActivated.Name = "isActivated";
            this.isActivated.Size = new System.Drawing.Size(78, 16);
            this.isActivated.TabIndex = 42;
            this.isActivated.Text = "Activated";
            this.isActivated.Visible = false;
            // 
            // isFreeze
            // 
            this.isFreeze.AutoSize = true;
            this.isFreeze.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isFreeze.ForeColor = System.Drawing.Color.Red;
            this.isFreeze.Location = new System.Drawing.Point(226, 298);
            this.isFreeze.Name = "isFreeze";
            this.isFreeze.Size = new System.Drawing.Size(58, 16);
            this.isFreeze.TabIndex = 41;
            this.isFreeze.Text = "Freeze";
            this.isFreeze.Visible = false;
            // 
            // ActivateButton
            // 
            this.ActivateButton.FlatAppearance.BorderSize = 2;
            this.ActivateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivateButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ActivateButton.Location = new System.Drawing.Point(337, 326);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(124, 47);
            this.ActivateButton.TabIndex = 40;
            this.ActivateButton.Text = "Activate Card";
            this.ActivateButton.UseVisualStyleBackColor = true;
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // FreezeButton
            // 
            this.FreezeButton.FlatAppearance.BorderSize = 2;
            this.FreezeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FreezeButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreezeButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.FreezeButton.Location = new System.Drawing.Point(199, 326);
            this.FreezeButton.Name = "FreezeButton";
            this.FreezeButton.Size = new System.Drawing.Size(115, 47);
            this.FreezeButton.TabIndex = 39;
            this.FreezeButton.Text = "Freeze Card";
            this.FreezeButton.UseVisualStyleBackColor = true;
            this.FreezeButton.Click += new System.EventHandler(this.FreezeButton_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.NumberLabel.Location = new System.Drawing.Point(11, 225);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(65, 16);
            this.NumberLabel.TabIndex = 37;
            this.NumberLabel.Text = "Number";
            this.NumberLabel.Visible = false;
            // 
            // EDLabel
            // 
            this.EDLabel.AutoSize = true;
            this.EDLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.EDLabel.Location = new System.Drawing.Point(270, 225);
            this.EDLabel.Name = "EDLabel";
            this.EDLabel.Size = new System.Drawing.Size(92, 16);
            this.EDLabel.TabIndex = 38;
            this.EDLabel.Text = "Expire Date";
            this.EDLabel.Visible = false;
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.CVVLabel.Location = new System.Drawing.Point(11, 326);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(38, 16);
            this.CVVLabel.TabIndex = 36;
            this.CVVLabel.Text = "CVV";
            this.CVVLabel.Visible = false;
            // 
            // CardCVVLabel
            // 
            this.CardCVVLabel.AutoSize = true;
            this.CardCVVLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCVVLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardCVVLabel.Location = new System.Drawing.Point(10, 282);
            this.CardCVVLabel.Name = "CardCVVLabel";
            this.CardCVVLabel.Size = new System.Drawing.Size(110, 23);
            this.CardCVVLabel.TabIndex = 35;
            this.CardCVVLabel.Text = "Card CVV";
            // 
            // CardExpireDate
            // 
            this.CardExpireDate.AutoSize = true;
            this.CardExpireDate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardExpireDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardExpireDate.Location = new System.Drawing.Point(269, 186);
            this.CardExpireDate.Name = "CardExpireDate";
            this.CardExpireDate.Size = new System.Drawing.Size(192, 23);
            this.CardExpireDate.TabIndex = 34;
            this.CardExpireDate.Text = "Card Expire Date";
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardNumberLabel.Location = new System.Drawing.Point(10, 186);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(151, 23);
            this.CardNumberLabel.TabIndex = 33;
            this.CardNumberLabel.Text = "Card Number";
            // 
            // CardsComboBox
            // 
            this.CardsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardsComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsComboBox.FormattingEnabled = true;
            this.CardsComboBox.Location = new System.Drawing.Point(14, 118);
            this.CardsComboBox.Name = "CardsComboBox";
            this.CardsComboBox.Size = new System.Drawing.Size(406, 31);
            this.CardsComboBox.TabIndex = 32;
            this.CardsComboBox.SelectedIndexChanged += new System.EventHandler(this.CardsComboBox_SelectedIndexChanged);
            // 
            // CardSelectorLabel
            // 
            this.CardSelectorLabel.AutoSize = true;
            this.CardSelectorLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardSelectorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardSelectorLabel.Location = new System.Drawing.Point(8, 83);
            this.CardSelectorLabel.Name = "CardSelectorLabel";
            this.CardSelectorLabel.Size = new System.Drawing.Size(101, 32);
            this.CardSelectorLabel.TabIndex = 31;
            this.CardSelectorLabel.Text = "Cards";
            // 
            // CardsManagementTitle
            // 
            this.CardsManagementTitle.AutoSize = true;
            this.CardsManagementTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsManagementTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardsManagementTitle.Location = new System.Drawing.Point(8, 18);
            this.CardsManagementTitle.Name = "CardsManagementTitle";
            this.CardsManagementTitle.Size = new System.Drawing.Size(306, 32);
            this.CardsManagementTitle.TabIndex = 30;
            this.CardsManagementTitle.Text = "Cards Management";
            this.CardsManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.isActivated);
            this.Controls.Add(this.isFreeze);
            this.Controls.Add(this.ActivateButton);
            this.Controls.Add(this.FreezeButton);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.EDLabel);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.CardCVVLabel);
            this.Controls.Add(this.CardExpireDate);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.CardsComboBox);
            this.Controls.Add(this.CardSelectorLabel);
            this.Controls.Add(this.CardsManagementTitle);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(503, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Label isActivated;
        private System.Windows.Forms.Label isFreeze;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.Button FreezeButton;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label EDLabel;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.Label CardCVVLabel;
        private System.Windows.Forms.Label CardExpireDate;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.ComboBox CardsComboBox;
        private System.Windows.Forms.Label CardSelectorLabel;
        private System.Windows.Forms.Label CardsManagementTitle;
    }
}
