
namespace Firebank
{
    partial class RequestAccount
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
            this.AccountNameTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.addCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountNameTextBox
            // 
            this.AccountNameTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameTextBox.Location = new System.Drawing.Point(17, 50);
            this.AccountNameTextBox.Name = "AccountNameTextBox";
            this.AccountNameTextBox.Size = new System.Drawing.Size(312, 31);
            this.AccountNameTextBox.TabIndex = 19;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label1.Location = new System.Drawing.Point(61, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(221, 18);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Enter the Account Name";
            // 
            // addCardButton
            // 
            this.addCardButton.FlatAppearance.BorderSize = 2;
            this.addCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCardButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.addCardButton.Location = new System.Drawing.Point(89, 103);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(165, 47);
            this.addCardButton.TabIndex = 30;
            this.addCardButton.Text = "Request Account";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // RequestAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(343, 174);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.AccountNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RequestAccount";
            this.Text = "Firebank - Request Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountNameTextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button addCardButton;
    }
}