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
    }
}
