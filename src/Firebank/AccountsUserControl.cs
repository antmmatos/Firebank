﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Firebank
{
    public partial class AccountsUserControl : UserControl
    {
        List<Account> accounts = new List<Account>();
        SqlConnection db = Functions.db;
        public string NIF = "";
        public AccountsUserControl()
        {
            InitializeComponent();
            StartUPAccounts();
        }

        public void StartUPAccounts()
        {
            AccountsComboBox.Items.Clear();
            accounts.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT Accounts.ID, Account_Owner, IBan, Balance, AccountName FROM Users INNER JOIN Accounts ON Users.ID = Accounts.Account_Owner WHERE Users.NIF = @NIF";
            command.Parameters.Add("@NIF", SqlDbType.VarChar).Value = NIF;
            try
            {
                db.Open();
            }
            catch (Exception) { }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AccountsComboBox.Items.Add("ID: " + reader.GetInt32(0).ToString() + " - Account Name: " + reader.GetString(4));
                accounts.Add(new Account(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetDecimal(3), reader.GetString(4)));
            }
            if (AccountsComboBox.Items.Count == 0)
            {
                AccountsComboBox.Items.Add("No Accounts found");
            }
            reader.Close();
            db.Close();
        }
        private void AccountsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accounts.Count == 0) return;
            BalanceLabel.Visible = true;
            IDLabel.Visible = true;
            IBANLabel.Visible = true;
            BalanceLabel.Text = accounts.ElementAt(AccountsComboBox.SelectedIndex).Balance.ToString();
            IDLabel.Text = accounts.ElementAt(AccountsComboBox.SelectedIndex).ID.ToString();
            IBANLabel.Text = accounts.ElementAt(AccountsComboBox.SelectedIndex).IBAN.ToString();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            new RequestAccount(NIF).ShowDialog();
            StartUPAccounts();
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            if(AccountsComboBox.SelectedIndex != -1)
            {
                IBANLabel.Text = "";
                IDLabel.Text = "";
                BalanceLabel.Text = "";
                SqlCommand command = new SqlCommand();
                command.Connection = db;
                command.CommandText = "UPDATE Accounts SET AccountName = @Name WHERE ID = @ID";
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = NewNameTextBox.Text;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = accounts.ElementAt(AccountsComboBox.SelectedIndex).ID;
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                StartUPAccounts();
            }
        }
    }
}
