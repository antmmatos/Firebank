using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Homepage : Form
    {
        private string _Username;
        private string _Email;
        private string _NIF;
        private string _CC;
        private string _PhoneNumber;
        private string _Birthday;
        private SqlConnection db;
        private DataTable _CurrentStatement;
        List<Account> accounts = new List<Account>();
        List<Card> cards = new List<Card>();
        private static void ThreadProc()
        {
            Application.Run(new Authentication());
        }        

        public Homepage(string Username, string Email, string NIF, string CC, string PhoneNumber, string Birthday, SqlConnection db)
        {
            InitializeComponent();
            _Username = Username;
            _Email = Email;
            _NIF = NIF;
            _CC = CC;
            _PhoneNumber = PhoneNumber;
            _Birthday = Birthday;
            this.db = db;
            SettingsUserControl.ButtonClick += new EventHandler(LogoutButtonClick);
            StartUPFunctions();
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
            this.Dispose();
        }
        private void StartUPFunctions()
        {
            StartUPHomepage();
        }

        private void StartUPHomepage()
        {
            AccountList.Items.Clear();
            WelcomeLabel.Text = "Welcome " + _Username;
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT Accounts.ID, Account_Owner, IBan, Balance, isnull(AccountName, 'SEM NOME') FROM Users INNER JOIN Accounts ON Users.ID = Accounts.Account_Owner";
            db.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AccountList.Items.Add("ID: " + reader.GetInt32(0).ToString() + " - Account Name: " + reader.GetString(4));
                accounts.Add(new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4)));
            }
            if (AccountList.Items.Count == 0)
            {
                AccountList.Items.Add("No Accounts found");
            }
            reader.Close();
            db.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BalanceLabelValue.Text = accounts.ElementAt(AccountList.SelectedIndex).Balance.ToString();
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM Transactions WHERE Sender_Account = @ID OR Receiver_Account = @ID";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = accounts.ElementAt(AccountList.SelectedIndex).ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            _CurrentStatement = dataSet.Tables[0];
            OpenStatementButton.Enabled = true;
        }

        private void OpenStatementButton_Click(object sender, EventArgs e)
        {
            new Statement(_CurrentStatement).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardsManagement.NIF = _NIF;
            CardsManagement.Visible = true;
            AccountsManagement.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CardsManagement.Visible = false;
            AccountsManagement.Visible = false;
            SettingsUserControl.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountsManagement.NIF = _NIF;
            CardsManagement.Visible = false;
            AccountsManagement.Visible = true;
            SettingsUserControl.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SettingsUserControl.Visible = true;
            CardsManagement.Visible = false;
            AccountsManagement.Visible = false;
        }
    }
}
