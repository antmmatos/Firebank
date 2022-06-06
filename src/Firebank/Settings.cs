using System;
using System.Data;
using System.Data.SqlClient;
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
            SqlCommand command = new SqlCommand()
            {
                Connection = Functions.db,
                CommandText = "UPDATE Users SET Password = @password WHERE Username = @username"
            };
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = ComputeSha256Hash(newPassword);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text;
            Functions.db.Open();
            command.ExecuteNonQuery();
            Functions.db.Close();
            Notifications notifier = new Notifications();
            notifier.showAlert("Password changed with success.", Notifications.enmType.Success);
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

        private void is2FAActivated_Click(object sender, EventArgs e)
        {
            Notifications notifier;
            if (is2FAActivated.Checked)
            {
                notifier = new Notifications();
                notifier.showAlert("2FA Enabled", Notifications.enmType.Info);
            }
            else
            {
                notifier = new Notifications();
                notifier.showAlert("2FA Disabled", Notifications.enmType.Info);
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
                notifier = new Notifications();
                notifier.showAlert("Phone Number is not verified", Notifications.enmType.Warning);
            }
        }
    }
}
