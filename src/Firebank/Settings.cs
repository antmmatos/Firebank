using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = newPassword; // TODO: Encrypt password
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text;
            Authentication.db.Open();
            command.ExecuteNonQuery();
            Authentication.db.Close();
            MessageBox.Show("Password changed with success.");
            input.Dispose();
        }
    }
}
