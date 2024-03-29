﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Homepage : Form
    {
        private readonly string _Username;
        private readonly string _Email;
        private readonly string _NIF;
        private readonly string _CC;
        private readonly string _PhoneNumber;
        private readonly string _Birthday;
        private readonly bool _2FA;
        private string _IP;
        private DataTable _CurrentStatement;
        readonly List<Account> accounts = new List<Account>();

        public Homepage(string Username, string Email, string NIF, string CC, string PhoneNumber, string Birthday, bool FA)
        {
            InitializeComponent();
            GetIp();
            _Username = Username;
            _Email = Email;
            _NIF = NIF;
            _CC = CC;
            _PhoneNumber = PhoneNumber;
            _Birthday = Birthday;
            _2FA = FA;
            SettingsUserControl.ButtonClick += new EventHandler(LogoutButtonClick);
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "UPDATE Users SET LastIP = @IP WHERE Username = @Username"
            };
            command.Parameters.AddWithValue("@IP", SqlDbType.VarChar).Value = _IP;
            StartUPFunctions();
            StartUPUserInfo();
        }
        async private void GetIp()
        {
            var httpClient = new HttpClient();
            string ip = await httpClient.GetStringAsync("https://api.ipify.org");
            _IP = ip;
        }

        private void StartUPUserInfo()
        {
            SettingsUserControl.SetUserInfo(_Username, _Email, _NIF, _CC, _PhoneNumber, _Birthday, _2FA);
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            Functions.Logout();
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
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "SELECT Accounts.ID, Account_Owner, IBan, Balance, isnull(AccountName, 'SEM NOME') FROM Users INNER JOIN Accounts ON Users.ID = Accounts.Account_Owner"
            };
            Functions.db.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AccountList.Items.Add("ID: " + reader.GetInt32(0).ToString() + " - Account Name: " + reader.GetString(4));
                accounts.Add(new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4)));
            }
            if (AccountList.Items.Count == 0)
            {
                AccountList.Items.Add("No Accounts found");
            }
            reader.Close();
            Functions.db.Close();
        }

        private void AccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accounts.Count == 0) return;
            BalanceLabelValue.Text = "€" + accounts.ElementAt(AccountList.SelectedIndex).Balance.ToString();
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "SELECT * FROM Transactions WHERE Sender_Account = @ID OR Receiver_Account = @ID"
            };
            command.Parameters.Add("@ID", SqlDbType.Int).Value = accounts.ElementAt(AccountList.SelectedIndex).ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            _CurrentStatement = dataSet.Tables[0];
            OpenStatementButton.Enabled = true;
            TransferButton.Enabled = true;
        }

        private void OpenStatementButton_Click(object sender, EventArgs e)
        {
            new Statement(_CurrentStatement).ShowDialog();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            CardsManagement.Visible = false;
            AccountsManagement.Visible = false;
            SettingsUserControl.Visible = false;
        }

        private void CardsManagementButton_Click(object sender, EventArgs e)
        {
            CardsManagement.NIF = _NIF;
            CardsManagement.StartUPCards();
            CardsManagement.Visible = true;
            AccountsManagement.Visible = false;
        }

        private void AccountsManagementButton_Click(object sender, EventArgs e)
        {
            AccountsManagement.NIF = _NIF;
            AccountsManagement.StartUPAccounts();
            CardsManagement.Visible = false;
            AccountsManagement.Visible = true;
            SettingsUserControl.Visible = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsUserControl.Visible = true;
            CardsManagement.Visible = false;
            AccountsManagement.Visible = false;
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            new BankTransfer(accounts.ElementAt(AccountList.SelectedIndex).ID).ShowDialog();
        }
    }
}
