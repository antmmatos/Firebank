
namespace Firebank
{
    partial class InputBox
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
            this.CustomLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomLabel
            // 
            this.CustomLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CustomLabel.Location = new System.Drawing.Point(0, 0);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(268, 51);
            this.CustomLabel.TabIndex = 0;
            this.CustomLabel.Text = "None";
            this.CustomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.SubmitButton.Location = new System.Drawing.Point(66, 92);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(136, 48);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTextBox.Location = new System.Drawing.Point(54, 56);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(161, 26);
            this.ValueTextBox.TabIndex = 2;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(268, 149);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CustomLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ValueTextBox;
    }
}