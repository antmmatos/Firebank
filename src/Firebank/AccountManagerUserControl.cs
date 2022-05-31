using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Firebank
{
    public partial class AccountManagerUserControl : UserControl
    {
        public AccountManagerUserControl()
        {
            InitializeComponent();
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "SELECT Accounts.ID, Users.Name, IBan, Balance, AccountName FROM Accounts INNER JOIN Users ON Accounts.Account_Owner = Users.ID"
            };
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            UsersGrid.DataSource = dataSet.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Functions.db,
                    CommandText = "SELECT Accounts.ID, Users.Name, IBan, Balance, AccountName FROM Accounts INNER JOIN Users ON Accounts.Account_Owner = Users.ID"
                };
                Functions.db.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UsersGrid.DataSource = null;
                UsersGrid.Rows.Clear();
                UsersGrid.DataSource = ds.Tables[0];
                Functions.db.Close();
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Functions.db,
                    CommandText = "SELECT Accounts.ID, Users.Name, IBan, Balance, AccountName FROM Accounts INNER JOIN Users ON Accounts.Account_Owner = Users.ID WHERE Users.Name LIKE @Data OR IBan LIKE @Data OR AccountName LIKE @Data"
                };
                command.Parameters.AddWithValue("@Data", $"%{textBox1.Text}%");
                Functions.db.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UsersGrid.DataSource = ds.Tables[0];
                Functions.db.Close();
            }
        }
    }
}
