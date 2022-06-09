namespace Firebank
{
    partial class Statement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statement));
            this.statementgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statementgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statementgrid
            // 
            this.statementgrid.AllowUserToAddRows = false;
            this.statementgrid.AllowUserToDeleteRows = false;
            this.statementgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statementgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statementgrid.Location = new System.Drawing.Point(0, 0);
            this.statementgrid.Name = "statementgrid";
            this.statementgrid.ReadOnly = true;
            this.statementgrid.RowHeadersVisible = false;
            this.statementgrid.Size = new System.Drawing.Size(603, 297);
            this.statementgrid.TabIndex = 0;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 297);
            this.Controls.Add(this.statementgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statement";
            this.Text = "Firebank - Statement Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.statementgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statementgrid;
    }
}