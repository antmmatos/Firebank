using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;
using Infobip.Api.Client;
using Infobip.Api.Client.Api;
using Infobip.Api.Client.Model;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http;

namespace Firebank
{
    public partial class ForgotPassword : Form
    {
        private static readonly string BASE_URL = "https://gy2yge.api.infobip.com";
        private static readonly string API_KEY = "3ed9d56ba5092fa8bcf06ddd32ef6ffc-07df9850-5fd2-4368-b169-a6eb26939882";

        private static readonly string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;";
        private static string _verificationCode;
        private string _IP;
        private string _CountryIP;
        private string _CountryCode;
        private string _PhoneNumber;
        readonly SqlConnection db = new SqlConnection(ConnectionString);
        public ForgotPassword()
        {
            InitializeComponent();
            GetIp();
            GetCountryIp(_IP);
        }

        private void RecoverPasswordButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = db,
                CommandText = "SELECT * FROM Users WHERE Email = @Var or Username = @Var or MobilePhoneNumber = @Var"
            };
            command.Parameters.Add("@Var", System.Data.SqlDbType.VarChar).Value = UsernameTextBox.Text;
            db.Open();
            SqlDataReader commandReader = command.ExecuteReader();
            string[] randomArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string verificationCode = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                verificationCode += randomArray[random.Next(35)];
            }
            commandReader.Read();
            if (commandReader.HasRows)
            {
                if (VerificationTypeComboBox.SelectedItem.ToString() == "Email")
                {
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
                    mailMessage.To.Add(UsernameTextBox.Text);
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("An email has been sent with a validation code.");
                    CodeTextBox.Enabled = true;
                    VerifyButton.Enabled = true;
                    _verificationCode = verificationCode;
                }
                else if (VerificationTypeComboBox.SelectedItem.ToString() == "Mobile Phone")
                {
                    _PhoneNumber = UsernameTextBox.Text;
                    if (AutomaticPhoneCodeCheckBox.Checked)
                    {
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
                    }
                    else
                    {
                        if (_PhoneNumber.Contains("+"))
                        {
                            _PhoneNumber = _PhoneNumber.Replace("+", "");
                        }
                    }

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
                        CodeTextBox.Enabled = true;
                        VerifyButton.Enabled = true;
                        _verificationCode = verificationCode;
                    }
                    catch (ApiException apiException)
                    {
                        MessageBox.Show($"Error occurred! \n\tMessage: {apiException.ErrorContent}. \n\tCode: {apiException.ErrorCode}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Username or Email invalid.");
            }
            db.Close();
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

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (_verificationCode == CodeTextBox.Text)
            {
                InputBox newPassword = new InputBox("Firebank - Change Password", "Enter your new password", true, "Password changed with success.");
                newPassword.ShowDialog();
                SqlCommand command = new SqlCommand();
                string _newPassword = newPassword.value;
                command.Connection = db;
                command.CommandText = "UPDATE users SET Password=@Password WHERE Email=@Email OR Username=@Username";
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = UsernameTextBox.Text;
                command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar).Value = UsernameTextBox.Text;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = _newPassword;
                newPassword.Dispose();
                db.Open();
                command.ExecuteNonQuery();
                db.Close();
                this.Close();
                this.Dispose();
            }
        }
        private void VerificationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VerificationTypeComboBox.SelectedItem.ToString() == "Mobile Phone")
            {
                AutomaticPhoneCodeCheckBox.Visible = true;
            }
            else
            {
                AutomaticPhoneCodeCheckBox.Visible = false;
            }
        }
    }
}