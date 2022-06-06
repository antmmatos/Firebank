using Infobip.Api.Client;
using Infobip.Api.Client.Api;
using Infobip.Api.Client.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Windows.Forms;

namespace Firebank
{
    public partial class VerificationSystem : Form
    {
        private const string BASE_URL = "https://gy2yge.api.infobip.com";
        private const string API_KEY = "3ed9d56ba5092fa8bcf06ddd32ef6ffc-07df9850-5fd2-4368-b169-a6eb26939882";
        private string _verificationCode;
        private string _PhoneNumber;
        private string _Email;
        private bool IsEmailVerified = false;
        private bool IsPhoneVerified = false;
        private string _IP;
        private string _CountryIP;
        private string _CountryCode;


        private bool notificationHasBeenShowned = false;
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

        private void SendSMS()
        {
            string verificationCode = Functions.RandomVerificationCode();
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
                Notifications notifier = new Notifications();
                notifier.showAlert($"Error occurred! \n\tMessage: {apiException.ErrorContent}. \n\tCode: {apiException.ErrorCode}", Notifications.enmType.Error);
            }
        }
        
        private void VerifyEmailButton_Click(object sender, EventArgs e)
        {
            if(_verificationCode == VerifyEmailCodeTextBox.Text)
            {
                if (!IsEmailVerified)
                {
                    Notifications notifier = new Notifications();
                    notifier.showAlert("Email verified!", Notifications.enmType.Success);
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "UPDATE Users SET VerifiedEmail = 1 WHERE Email = @Email"
                    };
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = _Email;
                    command.ExecuteNonQuery();
                    VerifyLabel.Text = "SMS Verification";
                    CheckLabel.Text = "Enter the code sent by SMS";
                    IsEmailVerified = true;
                    VerifyEmailCodeTextBox.Text = "";
                    if (!IsPhoneVerified)
                    {
                        SendSMS();
                        notifier = new Notifications();
                        notifier.showAlert("Code sent by SMS successfully", Notifications.enmType.Info);
                    }
                }
                else
                {
                    if (!IsPhoneVerified)
                    {
                        Notifications notifier = new Notifications();
                        notifier.showAlert("Phone number verified!", Notifications.enmType.Success);
                        SqlCommand command = new SqlCommand
                        {
                            Connection = Functions.db,
                            CommandText = "UPDATE Users SET VerifiedMobilePhone = 1 WHERE Email = @Email"
                        };
                        command.Parameters.Add("@Email", SqlDbType.VarChar).Value = _Email;
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                Notifications notifier = new Notifications();
                notifier.showAlert("Invalid code.", Notifications.enmType.Error);
            }
        }

        private void VerificationSystem_Load(object sender, EventArgs e)
        {

        }

        private void VerificationSystem_Activated(object sender, EventArgs e)
        {
           
        }

        private void VerificationSystem_VisibleChanged(object sender, EventArgs e)
        {
            if (notificationHasBeenShowned)
                return;

            notificationHasBeenShowned = true;

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
            if (!IsEmailVerified)
            {
                string verificationCode = Functions.RandomVerificationCode();
                Functions.EmailSend("Verification Code", "\nYour verification code to recover password is: " + verificationCode, _Email);
                _verificationCode = verificationCode;
                Notifications notifier = new Notifications();
                notifier.showAlert("Code sent to Email successfully", Notifications.enmType.Info);
            }
        }
    }
}
