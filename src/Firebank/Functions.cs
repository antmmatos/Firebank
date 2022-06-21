using Infobip.Api.Client;
using Infobip.Api.Client.Api;
using Infobip.Api.Client.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Firebank
{
    static class Functions
    {
        private static readonly string ConnectionString = $"Server={DatabaseInformation.Host};Database={DatabaseInformation.Database};User Id={DatabaseInformation.Username};Password={DatabaseInformation.Password};MultipleActiveResultSets=true;";
        public static SqlConnection db = new SqlConnection(ConnectionString);
        private static string _CountryCode;
        private const string BASE_URL = "https://gy2yge.api.infobip.com";
        private const string API_KEY = "3ed9d56ba5092fa8bcf06ddd32ef6ffc-07df9850-5fd2-4368-b169-a6eb26939882";
        public static int UserID;
        private static void ThreadProc()
        {
            Application.Run(new Authentication());
        }

        public static void Alert(string msg, Notifications.enmType type)
        {
            Notifications notifier = new Notifications();
            notifier.showAlert(msg, type);
        }

        public static void EmailSend(string subject, string body, string email)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("firebank.no.reply@gmail.com", "cmiz gljj vctq pbmq"),
                EnableSsl = true,
            };
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("firebank.no.reply@gmail.com"),
                Subject = subject,
                Body = body,
                IsBodyHtml = false,
            };
            mailMessage.To.Add(email);
            smtpClient.Send(mailMessage);
        }

        public static string RandomVerificationCode()
        {
            string[] randomArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string verificationCode = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                verificationCode += randomArray[random.Next(35)];
            }
            return verificationCode;
        }

        public static void SendNotification(string message, Notifications.enmType type)
        {
            Functions.Alert(message, type);
        }

        public static void SendSMS(string IP, string phoneNumber, string verificationCode)
        {
            JArray array = JArray.Parse(File.ReadAllText("countriescode.json"));
            JObject countrySettings = JObject.Parse(IP);
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i]["name"].ToString() == countrySettings["country"].ToString())
                {
                    _CountryCode = array[i]["dial_code"].ToString();
                    break;
                }
            }
            phoneNumber = _CountryCode + phoneNumber;
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
                        new SmsDestination(to: phoneNumber)
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
            }
            catch (ApiException apiException)
            {
                Functions.Alert($"Error occurred! \n\tMessage: {apiException.ErrorContent}. \n\tCode: {apiException.ErrorCode}", Notifications.enmType.Error);
            }
        }

        public static void Logout()
        {
            UserID = 0;
            Thread logoutThread = new Thread(ThreadProc);
            logoutThread.Start();
        }

        public static bool StillAdmin(int id)
        {
            if (id == 0) { return false; }
            bool isAdmin;
            SqlCommand command = new SqlCommand
            {
                Connection = db,
                CommandText = "SELECT isAdmin FROM Users WHERE ID = @ID"
            };
            command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = id;
            try
            {
                db.Open();
            } catch { }
            isAdmin = (bool)command.ExecuteScalar();
            db.Close();
            return isAdmin;
        }

        public static string ComputeSha512Hash(string rawData)
        {
            using (SHA512 sha256Hash = SHA512.Create())
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
