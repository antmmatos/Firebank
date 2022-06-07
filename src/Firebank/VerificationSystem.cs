using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Windows.Forms;

namespace Firebank
{
    public partial class VerificationSystem : Form
    {
        private string _verificationCode;
        private string _PhoneNumber;
        private string _Email;
        private bool IsEmailVerified = false;
        private bool IsPhoneVerified = false;
        private string _IP;
        private string _CountryIP;
        public VerificationSystem()
        {
            InitializeComponent();
        }

        public void Setup(string email, string phone)
        {
            GetIp();
            GetCountryIp(_IP);

            _Email = email;
            _PhoneNumber = phone;
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "SELECT * FROM Users WHERE Email = @Email"
            };
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = _Email;
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            IsEmailVerified = Convert.ToBoolean(reader["VerifiedEmail"]);
            IsPhoneVerified = Convert.ToBoolean(reader["VerifiedMobilePhone"]);
            CheckIsVerified();
        }

        private void CheckIsVerified()
        {
            if (!IsEmailVerified)
            {
                string verificationCode = Functions.RandomVerificationCode();
                Functions.EmailSend("Verification Code", "\nYour verification code to recover password is: " + verificationCode, _Email);
                _verificationCode = verificationCode;
            }
            else if (!IsPhoneVerified)
            {
                VerifyLabel.Text = "SMS Verification";
                CheckLabel.Text = "Enter the code sent by SMS";
                string verificationCode = Functions.RandomVerificationCode();
                _verificationCode = verificationCode;
                Functions.SendSMS(_CountryIP, _PhoneNumber, _verificationCode);
            }
            else
            {
                this.Close();
            }
        }

        private void GetIp()
        {
            var httpClient = new HttpClient();
            string ip = httpClient.GetStringAsync("https://api.ipify.org").Result;
            _IP = ip;
        }

        private void GetCountryIp(string IP)
        {
            var httpClient = new HttpClient();
            string country = httpClient.GetStringAsync($"http://ip-api.com/json/{IP}").Result;
            _CountryIP = country;
        }
        
        private void Phone()
        {
            if (!IsPhoneVerified)
            {
                VerifyLabel.Text = "SMS Verification";
                CheckLabel.Text = "Enter the code sent by SMS";
                VerifyEmailCodeTextBox.Text = "";
                Functions.SendSMS(_CountryIP, _PhoneNumber, _verificationCode);
            }
            else
            {
                this.Close();
            }
        }

        private async void VerifyEmailButton_Click(object sender, EventArgs e)
        {
            if (_verificationCode == VerifyEmailCodeTextBox.Text)
            {
                if (!IsEmailVerified)
                {
                    Functions.Alert("Email verified!", Notifications.enmType.Success);
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "UPDATE Users SET VerifiedEmail = 1 WHERE Email = @Email"
                    };
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = _Email;
                    await command.ExecuteNonQueryAsync();
                    IsEmailVerified = true;
                    Phone();
                }
                else
                {
                    Functions.Alert("Phone verified!", Notifications.enmType.Success);
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "UPDATE Users SET VerifiedMobilePhone = 1 WHERE Email = @Email"
                    };
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = _Email;
                    await command.ExecuteNonQueryAsync();
                    IsPhoneVerified = true;
                    this.Close();
                }
            }
            else
            {
                Functions.Alert("Invalid code.", Notifications.enmType.Error);
            }
        }
    }
}
