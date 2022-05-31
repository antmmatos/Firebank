using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebank
{
    public partial class BankTransfer : Form
    {
        private readonly int AccountSelected;
        public BankTransfer(int Account)
        {
            InitializeComponent();
            AccountSelected = Account;
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "SELECT AccountName, Balance FROM Accounts WHERE ID = @ID"
            };
            command.Parameters.Add("@ID", SqlDbType.Int).Value = AccountSelected;
            Functions.db.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            AccountTextBox.Text = reader["AccountName"].ToString();
            BalanceTextBox.Text = reader["Balance"].ToString();
            Functions.db.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if(ReceiverTextBox.Text != "" && AmountTextBox.Text != "" && !(Convert.ToInt32(AmountTextBox.Text) < 1))
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Functions.db,
                    CommandText = "SELECT Balance FROM Accounts WHERE IBan = @IBan"
                };
                command.Parameters.Add("@IBan", SqlDbType.VarChar).Value = ReceiverTextBox.Text;
                Functions.db.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "SELECT Balance FROM Accounts WHERE ID = @ID"
                    };
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = AccountSelected;
                    SqlDataReader balanceReader = command.ExecuteReader();
                    balanceReader.Read();
                    if(Convert.ToInt32(balanceReader["Balance"].ToString()) < Convert.ToInt32(AmountTextBox.Text))
                    {
                        Functions.Alert("Insufficient balance", Notifications.enmType.Error);
                    }
                    else
                    {
                        command = new SqlCommand
                        {
                            Connection = Functions.db,
                            CommandText = "UPDATE Accounts SET Balance = Balance - @Value WHERE ID = @ID"
                        };
                        command.Parameters.Add("@ID", SqlDbType.VarChar).Value = AccountSelected;
                        command.Parameters.Add("@Value", SqlDbType.Int).Value = AmountTextBox.Text;
                        command.ExecuteNonQuery();
                        command = new SqlCommand
                        {
                            Connection = Functions.db,
                            CommandText = "UPDATE Accounts SET Balance = Balance + @Value WHERE IBan = @IBan"
                        };
                        command.Parameters.Add("@IBan", SqlDbType.VarChar).Value = ReceiverTextBox.Text;
                        command.Parameters.Add("@Value", SqlDbType.Int).Value = AmountTextBox.Text;
                        command.ExecuteNonQuery();
                        Functions.db.Close();
                        Functions.Alert("Sent successfully", Notifications.enmType.Success);
                        this.Dispose();
                    }
                }
                else
                {
                    Functions.Alert("Invalid transference", Notifications.enmType.Error);
                }
            }
        }
    }
}
