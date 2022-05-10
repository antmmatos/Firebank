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
    public partial class HomePage : Form
    {
        private class Item
        {
            public dynamic Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public Item(int name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Convert.ToString(Name);
            }
        }
        private string _Username;
        private string _Email;
        private string _NIF;
        private string _CC;
        private string _PhoneNumber;
        private string _Birthday;
        private SqlConnection db;
        List<Account> accounts = new List<Account>();
        public HomePage(SqlDataReader reader, SqlConnection db)
        {
            InitializeComponent();
            _Username = reader["Username"].ToString();
            _Email = reader["Email"].ToString();
            _NIF = reader["NIF"].ToString();
            _CC = reader["CC"].ToString();
            _PhoneNumber = reader["MobilePhoneNumber"].ToString();
            _Birthday = reader["Birthday"].ToString();
            reader.Close();
            this.db = db;
            StartUP();
        }
        
        public HomePage(string Username, string Email, string NIF, string CC, string PhoneNumber, string Birthday, SqlConnection db)
        {
            InitializeComponent();
            _Username = Username;
            _Email = Email;
            _NIF = NIF;
            _CC = CC;
            _PhoneNumber = PhoneNumber;
            _Birthday = Birthday;
            this.db = db;
            StartUP();
        }

        private void StartUP()
        {
            AccountList.Items.Clear();
            WelcomeLabel.Text = "Welcome " + _Username;
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT Accounts.ID, Account_Owner, IBan, Balance, isnull(AccountName, 'SEM NOME') FROM Users INNER JOIN Accounts ON Users.ID = Accounts.Account_Owner";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AccountList.Items.Add("ID: " + reader.GetInt32(0).ToString() + " - Account Name: " + reader.GetString(4));
                accounts.Add(new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), AccountList.Items.Count));
            }
            if (AccountList.Items.Count == 0)
            {
                AccountList.Items.Add(new Item("No Accounts found", 1));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceLabelValue.Text = accounts.ElementAt(AccountList.SelectedIndex).Balance.ToString();
        }
    }
}
