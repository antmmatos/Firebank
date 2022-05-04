using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Firebank
{
    public partial class Login : Form
    {
        public static string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;";
        SqlConnection db = new SqlConnection(ConnectionString);
        public Login()
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
    }
}
