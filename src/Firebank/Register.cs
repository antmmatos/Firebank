using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Register : Form
    {
        public static string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;";
        SqlConnection db = new SqlConnection(ConnectionString);
        private bool isRegisterPanel;
        public Register()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", db);
            command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
            command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
            db.Open();
            SqlDataReader commandReader = command.ExecuteReader();
            commandReader.Read();
            if (commandReader.HasRows)
            {
                MessageBox.Show(commandReader["Username"].ToString());
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            db.Close();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            new ForgotPassword().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = 
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanel.Visible = true;
        }

        private void LoginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanel.Visible = false;
        }
    }
}
