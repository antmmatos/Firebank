using System;
using System.Net;
using System.Net.Mail;

namespace Firebank
{
    static class Functions
    {
        private static readonly string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;MultipleActiveResultSets=true;";
        public static System.Data.SqlClient.SqlConnection db = new System.Data.SqlClient.SqlConnection(ConnectionString);
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
    }
}
