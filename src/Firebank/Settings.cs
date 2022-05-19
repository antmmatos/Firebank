﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Settings : UserControl
    {
        public event EventHandler ButtonClick;
        public Settings()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }

        internal void SetUserInfo(string username, string email, string NIF, string CC, string phoneNumber, string birthday)
        {
            UsernameTextBox.Text = username;
            EmailTextBox.Text = email;
            NIFTextBox.Text = NIF;
            CCTextBox.Text = CC;
            PhoneNumberTextBox.Text = phoneNumber;
            BirthdayTextBox.Text = birthday;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox("Firebank - Change Password", "Enter your new password", true, "Password changed with success.");
            input.ShowDialog();
            string newPassword = input.value;
            SqlCommand command = new SqlCommand()
            {
                Connection = Authentication.db,
                CommandText = "UPDATE Users SET Password = @password WHERE Username = @username"
            };
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = ComputeSha256Hash(newPassword);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text;
            Authentication.db.Open();
            command.ExecuteNonQuery();
            Authentication.db.Close();
            MessageBox.Show("Password changed with success.");
            input.Dispose();
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
