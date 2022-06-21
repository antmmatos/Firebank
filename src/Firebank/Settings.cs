using System;
using System.Data;
using System.Data.SqlClient;
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

        internal void SetUserInfo(string username, string email, string NIF, string CC, string phoneNumber, string birthday, bool fa)
        {
            UsernameTextBox.Text = username;
            EmailTextBox.Text = email;
            NIFTextBox.Text = NIF;
            CCTextBox.Text = CC;
            PhoneNumberTextBox.Text = phoneNumber;
            BirthdayTextBox.Text = birthday;
            is2FAActivated.Checked = fa;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox("Firebank - Change Password", "Enter your new password", true, "Password changed with success.");
            input.ShowDialog();
            string newPassword = input.value;
            if (newPassword.Length > 8)
            {
                SqlCommand command = new SqlCommand()
                {
                    Connection = Functions.db,
                    CommandText = "UPDATE Users SET Password = @password WHERE Username = @username"
                };
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = Functions.ComputeSha512Hash(newPassword);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text;
                Functions.db.Open();
                command.ExecuteNonQuery();
                Functions.db.Close();
                input.Dispose();
            }
            else
            {
                Functions.SendNotification("Invalid Password", Notifications.enmType.Error);
            }
        }

        private void Is2FAActivated_Click(object sender, EventArgs e)
        {
            if (is2FAActivated.Checked)
            {
                Functions.Alert("2FA Enabled", Notifications.enmType.Info);
            }
            else
            {
                Functions.Alert("2FA Disabled", Notifications.enmType.Info);
            }
            SqlCommand checkVerifiedPhone = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "SELECT VerifiedMobilePhone FROM Users WHERE NIF = @NIF"
            };
            checkVerifiedPhone.Parameters.Add("@NIF", SqlDbType.VarChar).Value = NIFTextBox.Text;
            Functions.db.Open();
            SqlDataReader reader = checkVerifiedPhone.ExecuteReader();
            reader.Read();
            if (reader["VerifiedMobilePhone"].ToString().Equals("True"))
            {
                Functions.db.Close();
                SqlCommand command = new SqlCommand
                {
                    Connection = Functions.db,
                    CommandText = "UPDATE Users SET is2FAEnabled = @NewValue WHERE NIF = @NIF"
                };
                command.Parameters.Add("@NewValue", SqlDbType.Bit).Value = is2FAActivated.Checked;
                command.Parameters.Add("@NIF", SqlDbType.VarChar).Value = NIFTextBox.Text;
                Functions.db.Open();
                command.ExecuteNonQuery();
                Functions.db.Close();
            }
            else
            {
                Functions.db.Close();
                is2FAActivated.Checked = false;
                Functions.Alert("Phone Number is not verified", Notifications.enmType.Warning);
            }
        }
    }
}
