using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;

namespace Firebank
{
    public partial class ForgotPassword : Form
    {
        public static string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;";
        private static string _verificationCode;
        private string _emailRecover;
        SqlConnection db = new SqlConnection(ConnectionString);
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void RecoverPasswordButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT * FROM Users WHERE Email = @Var or Username = @Var";
            command.Parameters.Add("@Var", System.Data.SqlDbType.VarChar).Value = UsernameTextBox.Text;
            db.Open();
            SqlDataReader commandReader = command.ExecuteReader();
            string[] randomArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            string verificationCode = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                verificationCode = verificationCode + randomArray[random.Next(35)];
            }
            commandReader.Read();
            if (commandReader.HasRows)
            {
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
                mailMessage.To.Add("antonio.martim.matos@gmail.com");
                smtpClient.Send(mailMessage);
                MessageBox.Show("Foi enviado um email com um código que validação.");
                CodeTextBox.Enabled = true;
                VerifyButton.Enabled = true;
                _verificationCode = verificationCode;
            }
            else
            {
                MessageBox.Show("Username or Email non existant.");
            }
            db.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if(_verificationCode == CodeTextBox.Text)
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
    }
}
