using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace Firebank
{
    public partial class RequestCard : Form
    {
        List<Account> accounts = new List<Account>();
        public RequestCard(List<Account> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
            foreach (var item in accounts)
            {
                CardsComboBox.Items.Add("ID: " + item.ID + " - Account Name: " + item.Name);
            }
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            string[] randomArray = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string CardNumber = "";
            string CardCVV = "";
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                CardNumber += randomArray[random.Next(10)];
            }
            DateTime start = new DateTime(2022, 1, 1);
            int range = (DateTime.Today - start).Days;
            for (int i = 0; i < 3; i++)
            {
                CardCVV += randomArray[random.Next(10)];
            }
            SqlCommand command = new SqlCommand
            {
                Connection = Authentication.db,
                CommandText = "INSERT INTO Cards (CardNumber, CardExpireDate, CardCVV, AccountID) VALUES (@CardNumber, @CardExpireDate, @CardCVV, @AccountID)"
            };
            command.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = CardNumber;
            command.Parameters.Add("@CardExpireDate", SqlDbType.Date).Value = start.AddDays(random.Next(range)).AddYears(2);
            command.Parameters.Add("@CardCVV", SqlDbType.VarChar).Value = CardCVV;
            command.Parameters.Add("@AccountID", SqlDbType.Int).Value = Convert.ToInt32(accounts.ElementAt(CardsComboBox.SelectedIndex).ID);
            Authentication.db.Open();
            command.ExecuteNonQuery();
            Authentication.db.Close();
            MessageBox.Show("Card requested successfully");
            this.Dispose();
        }
    }
}
