
namespace Firebank
{
    partial class UsersUserControl
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
            this.AccountsManagementTitle = new System.Windows.Forms.Label();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsManagementTitle
            // 
            this.AccountsManagementTitle.AutoSize = true;
            this.AccountsManagementTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsManagementTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.AccountsManagementTitle.Location = new System.Drawing.Point(8, 18);
            this.AccountsManagementTitle.Name = "AccountsManagementTitle";
            this.AccountsManagementTitle.Size = new System.Drawing.Size(305, 32);
            this.AccountsManagementTitle.TabIndex = 31;
            this.AccountsManagementTitle.Text = "Users Management";
            this.AccountsManagementTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersGrid
            // 
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(14, 64);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.Size = new System.Drawing.Size(474, 314);
            this.UsersGrid.TabIndex = 32;
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsersGrid);
            this.Controls.Add(this.AccountsManagementTitle);
            this.Name = "UsersUserControl";
            this.Size = new System.Drawing.Size(503, 391);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountsManagementTitle;
        private System.Windows.Forms.DataGridView UsersGrid;
    }
}
