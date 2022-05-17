using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Firebank
{
    public partial class RequestAccount : Form
    {
        private string NIF;
        private int ID;
        private string IBan = "PT50 ";
        public RequestAccount(string NIF)
        {
            this.NIF = NIF;
            InitializeComponent();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = Authentication.db,
                CommandText = "SELECT ID FROM Users WHERE NIF = @NIF"
            };
            command.Parameters.Add("@NIF", System.Data.SqlDbType.VarChar).Value = NIF;
            Authentication.db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            ID = (int)reader["ID"];
            reader.Close();
            command = new SqlCommand
            {
                Connection = Authentication.db,
                CommandText = "INSERT INTO Accounts (Account_Owner, IBan, AccountName) VALUES (@AccountOwner, @IBan, @AccountName)"
            };
            Random random = new Random();
            string[] randomArray = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for (int i = 0; i < 21; i++)
            {
                IBan += randomArray[random.Next(10)];
            }
            command.Parameters.Add("@AccountOwner", System.Data.SqlDbType.Int).Value = ID;
            command.Parameters.Add("@IBan", System.Data.SqlDbType.VarChar).Value = IBan;
            command.Parameters.Add("@AccountName", System.Data.SqlDbType.VarChar).Value = AccountNameTextBox.Text;
            command.ExecuteNonQuery();
            Authentication.db.Close();
            MessageBox.Show("Created successfully");
            this.Dispose();
        }
    }
}
