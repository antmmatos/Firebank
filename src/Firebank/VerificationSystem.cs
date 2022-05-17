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
        private string _IP;
        private string _CountryIP;
        private string _CountryCode;
        private string _PhoneNumber;
        private string _Email;
        private bool _IsEmailVerified;
        public VerificationSystem()
        {
            InitializeComponent();
            SendEmail();
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
                Credentials = new NetworkCredential("tomas.vaz05@gmail.com", "Habravinha#2005"),
                EnableSsl = true,
            };
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("tomas.vaz05@gmail.com"),
                Subject = "Verification Code",
                Body = "\nYour verification code to recover password is: " + verificationCode,
                IsBodyHtml = false,
            };
            mailMessage.To.Add(_Email);
            smtpClient.Send(mailMessage);
            MessageBox.Show("An email has been sent with a validation code.");
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
                MessageBox.Show("A SMS has been sent with a validation code.");
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
                if (!_IsEmailVerified)
                {
                    MessageBox.Show("Email verified!");
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Authentication.db,
                        CommandText = "UPDATE Users SET VerifiedEmail = 1 WHERE Email = @Email"
                    };
                    command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = _Email;
                    VerifyLabel.Text = "SMS Verification";
                    CheckLabel.Text = "Enter the code sent by SMS";
                    _IsEmailVerified = true;
                    SendSMS();
                }
                else
                {
                    MessageBox.Show("Phone number verified!");
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Authentication.db,
                        CommandText = "UPDATE Users SET VerifiedMobilePhone = 1 WHERE Email = @Email"
                    };
                    command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = _Email;
                }
            }
            else
            {
                MessageBox.Show("Invalid code.");
            }
        }
    }
}
