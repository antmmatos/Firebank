using Infobip.Api.Client;
using Infobip.Api.Client.Api;
using Infobip.Api.Client.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebank
{
    public partial class VerificationSystem : Form
    {
        private static readonly string BASE_URL = "https://gy2yge.api.infobip.com";
        private static readonly string API_KEY = "3ed9d56ba5092fa8bcf06ddd32ef6ffc-07df9850-5fd2-4368-b169-a6eb26939882";
        private static string _verificationCode;
        private string _PhoneNumber;
        private readonly string _Email;
        private bool IsEmailVerified = false;
        private readonly bool IsPhoneVerified = false;
        private string _IP;
        private string _CountryIP;
        private string _CountryCode;
        public VerificationSystem(string email, string phone)
        {
            InitializeComponent();
            GetIp();
            GetCountryIp(_IP);
            _Email = email;
            _PhoneNumber = phone;
            SqlCommand command = new SqlCommand
            {
                Connection = Authentication.db,
                CommandText = "SELECT * FROM Users WHERE Email = @Email"
            };
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = _Email;
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            IsEmailVerified = Convert.ToBoolean(reader["VerifiedEmail"]);
            IsPhoneVerified = Convert.ToBoolean(reader["VerifiedMobilePhone"]);
            if (!IsEmailVerified)
            {
                SendEmail();
            }
        }
        async private void GetIp()
        {
            var httpClient = new HttpClient();
            string ip = await httpClient.GetStringAsync("https://api.ipify.org");
            _IP = ip;
        }
        async private void GetCountryIp(string IP)
        {
            var httpClient = new HttpClient();
            string country = await httpClient.GetStringAsync($"http://ip-api.com/json/{IP}");
            _CountryIP = country;
        }

        private void SendEmail()
        {
            string[] randomArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string verificationCode = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                verificationCode += randomArray[random.Next(35)];
            }
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("firebank.no.reply@gmail.com", "Matecas1"),
                EnableSsl = true,
            };
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("firebank.no.reply@gmail.com"),
                Subject = "Verification Code",
                Body = "\nYour verification code to recover password is: " + verificationCode,
                IsBodyHtml = false,
            };
            mailMessage.To.Add(_Email);
            smtpClient.Send(mailMessage);
            _verificationCode = verificationCode;
        }

        private void SendSMS()
        {
            string[] randomArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string verificationCode = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                verificationCode += randomArray[random.Next(35)];
            }
            JArray array = JArray.Parse(File.ReadAllText("countriescode.json"));
            JObject countrySettings = JObject.Parse(_CountryIP);
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]["name"].ToString() == countrySettings["country"].ToString())
                {
                    _CountryCode = array[i]["dial_code"].ToString();
                    break;
                }
            }
            _PhoneNumber = _CountryCode + _PhoneNumber;
            var configuration = new Configuration()
            {
                BasePath = BASE_URL,
                ApiKeyPrefix = "App",
                ApiKey = API_KEY
            };

            var sendSmsApi = new SendSmsApi(configuration);

            var smsMessage = new SmsTextualMessage()
            {
                From = "SMSVerify",
                Destinations = new List<SmsDestination>()
                    {
                        new SmsDestination(to: _PhoneNumber)
                    },
                Text = "Your verification code to recover password is: " + verificationCode
            };

            var smsRequest = new SmsAdvancedTextualRequest()
            {
                Messages = new List<SmsTextualMessage>() { smsMessage }
            };

            try
            {
                var smsResponse = sendSmsApi.SendSmsMessage(smsRequest);
                _verificationCode = verificationCode;
            }
            catch (ApiException apiException)
            {
                MessageBox.Show($"Error occurred! \n\tMessage: {apiException.ErrorContent}. \n\tCode: {apiException.ErrorCode}");
            }
        }
        
        private void VerifyEmailButton_Click(object sender, EventArgs e)
        {
            if(_verificationCode == VerifyEmailCodeTextBox.Text)
            {
                if (!IsEmailVerified)
                {
                    MessageBox.Show("Email verified!");
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Authentication.db,
                        CommandText = "UPDATE Users SET VerifiedEmail = 1 WHERE Email = @Email"
                    };
                    command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = _Email;
                    command.ExecuteNonQuery();
                    VerifyLabel.Text = "SMS Verification";
                    CheckLabel.Text = "Enter the code sent by SMS";
                    IsEmailVerified = true;
                    VerifyEmailCodeTextBox.Text = "";
                    if (!IsPhoneVerified)
                    {
                        SendSMS();
                    }
                }
                else
                {
                    if (!IsPhoneVerified)
                    {
                        MessageBox.Show("Phone number verified!");
                        SqlCommand command = new SqlCommand
                        {
                            Connection = Authentication.db,
                            CommandText = "UPDATE Users SET VerifiedMobilePhone = 1 WHERE Email = @Email"
                        };
                        command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = _Email;
                        command.ExecuteNonQuery();
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid code.");
            }
        }
    }
}
