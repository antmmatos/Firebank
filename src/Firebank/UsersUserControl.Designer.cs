
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.Label();
            this.ChangeAdminState = new System.Windows.Forms.Button();
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
            this.UsersGrid.AllowUserToAddRows = false;
            this.UsersGrid.AllowUserToDeleteRows = false;
            this.UsersGrid.AllowUserToResizeColumns = false;
            this.UsersGrid.AllowUserToResizeRows = false;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.EnableHeadersVisualStyles = false;
            this.UsersGrid.Location = new System.Drawing.Point(14, 115);
            this.UsersGrid.MultiSelect = false;
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ReadOnly = true;
            this.UsersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UsersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGrid.Size = new System.Drawing.Size(474, 263);
            this.UsersGrid.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.AutoSize = true;
            this.SearchBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.SearchBox.Location = new System.Drawing.Point(11, 58);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(69, 18);
            this.SearchBox.TabIndex = 34;
            this.SearchBox.Text = "Search";
            // 
            // ChangeAdminState
            // 
            this.ChangeAdminState.FlatAppearance.BorderSize = 2;
            this.ChangeAdminState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAdminState.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAdminState.ForeColor = System.Drawing.Color.OrangeRed;
            this.ChangeAdminState.Location = new System.Drawing.Point(364, 52);
            this.ChangeAdminState.Name = "ChangeAdminState";
            this.ChangeAdminState.Size = new System.Drawing.Size(124, 47);
            this.ChangeAdminState.TabIndex = 44;
            this.ChangeAdminState.Text = "Change Admin State";
            this.ChangeAdminState.UseVisualStyleBackColor = true;
            this.ChangeAdminState.Click += new System.EventHandler(this.ChangeAdminState_Click);
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChangeAdminState);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchBox;
        private System.Windows.Forms.Button ChangeAdminState;
    }
}
