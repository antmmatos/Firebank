using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Authentication : Form
    {
        private bool seePassword;
        private string FACode;
        private string _Email;

        public Authentication()
        {
            InitializeComponent();
        }

        private string GetIp()
        {
            var httpClient = new HttpClient();
            string ip = httpClient.GetStringAsync("https://api.ipify.org").Result;
            return ip;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length >= 6 && PasswordTextBox.Text.Length >= 8 && UsernameTextBox.Text.Length <= 32 && PasswordTextBox.Text.Length <= 20)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", Functions.db);
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = UsernameTextBox.Text;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = ComputeSha256Hash(PasswordTextBox.Text);
                Functions.db.Open();
                SqlDataReader commandReader = command.ExecuteReader();
                if (commandReader.HasRows)
                {
                    commandReader.Read();
                    _Email = commandReader["Email"].ToString();
                    this.Hide();
                    Regex rx = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                    if (!rx.IsMatch(_Email))
                    {
                        Notifications notifier = new Notifications();
                        notifier.showAlert("An error ocorred. Please contact support.", Notifications.enmType.Error);
                        return;
                    }
                    if (!Convert.ToBoolean(commandReader["VerifiedEmail"].ToString()) || !Convert.ToBoolean(commandReader["VerifiedMobilePhone"].ToString()))
                    {
                        VerificationSystem a = new VerificationSystem();
                        a.Setup(commandReader["Email"].ToString(), commandReader["MobilePhoneNumber"].ToString());
                        a.ShowDialog();
                    }
                    else
                    {
                        string IP = GetIp();
                        if (Convert.ToString(commandReader["LastIP"]) == "")
                        {
                            command = new SqlCommand
                            {
                                Connection = Functions.db,
                                CommandText = "UPDATE Users SET LastIP = @IP WHERE ID = @ID"
                            };
                            command.Parameters.Add("@IP", SqlDbType.VarChar).Value = IP;
                            command.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(commandReader["ID"]);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            if (Convert.ToString(commandReader["LastIP"]) == IP)
                            {
                                ContinueLogin(commandReader);
                            }
                            else
                            {
                                string verificationCode = Functions.RandomVerificationCode();
                                Functions.EmailSend("Verification Code", "\nYour verification code to recover password is: " + verificationCode, _Email);
                                FACode = verificationCode;
                                Notifications notifier = new Notifications();
                                notifier.showAlert("Code sent to Email successfully", Notifications.enmType.Info);
                                InputBox input = new InputBox("Firebank - New IP Detected", "Enter the code sent by Email", false, "");
                                input.ShowDialog();
                                if (input.value == FACode)
                                {
                                    await ChangeIP(IP, Convert.ToInt32(commandReader["ID"]));
                                    ContinueLogin(commandReader);
                                }
                                else
                                {
                                    notifier = new Notifications();
                                    notifier.showAlert("Wrong Verification Code", Notifications.enmType.Error);
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    Notifications notifier = new Notifications();
                    notifier.showAlert("Username or Password is incorrect", Notifications.enmType.Error);
                    commandReader.Close();
                }
                Functions.db.Close();
            }
            else
            {
                Notifications notifier;
                if (!(UsernameTextBox.Text.Length >= 6))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(UsernameTextBox.Text.Length <= 32))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBox.Text.Length >= 8))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBox.Text.Length <= 20))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
            }
        }

        private async Task ChangeIP(string IP, int IDUser)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "UPDATE Users SET LastIP = @IP WHERE ID = @ID"
            };
            command.Parameters.Add("@IP", SqlDbType.VarChar).Value = IP;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = IDUser;
            await command.ExecuteNonQueryAsync();
        }

        private void ContinueLogin(dynamic commandReader)
        {
            if (Convert.ToBoolean(commandReader["is2FAEnabled"]))
            {
                _Email = commandReader["Email"].ToString();
                string verificationCode = Functions.RandomVerificationCode();
                Functions.EmailSend("Verification Code", "\nYour verification code to recover password is: " + verificationCode, _Email);
                FACode = verificationCode;
                Notifications notifier = new Notifications();
                notifier.showAlert("Code sent to Email successfully", Notifications.enmType.Info);
                InputBox input = new InputBox("Firebank - 2FA", "Enter the code sent by Email", false, "");
                input.ShowDialog();
                if (input.value == FACode)
                {
                    if (!Convert.ToBoolean(commandReader["isAdmin"]))
                    {
                        OpenUser(commandReader);
                    }
                    else
                    {
                        OpenAdmin(commandReader);
                    }
                }
                else
                {
                    notifier = new Notifications();
                    notifier.showAlert("Wrong 2FA Code", Notifications.enmType.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                if (!Convert.ToBoolean(commandReader["isAdmin"]))
                {
                    OpenUser(commandReader);
                }
                else
                {
                    OpenAdmin(commandReader);
                }

            }
        }

        private void OpenAdmin(dynamic commandReader)
        {
            AdminDashboard homepage = new AdminDashboard(commandReader["Username"].ToString(), commandReader["Email"].ToString(), commandReader["NIF"].ToString(), commandReader["CC"].ToString(), commandReader["MobilePhoneNumber"].ToString(), commandReader["Birthday"].ToString(), Functions.db, Convert.ToBoolean(commandReader["is2FAEnabled"]));
            homepage.Closed += (s, args) => this.Close();
            homepage.Show();
            Notifications notifier = new Notifications();
            notifier.showAlert("Successfully logged in", Notifications.enmType.Success);
        }

        private void OpenUser(dynamic commandReader)
        {
            Homepage homepage = new Homepage(commandReader["Username"].ToString(), commandReader["Email"].ToString(), commandReader["NIF"].ToString(), commandReader["CC"].ToString(), commandReader["MobilePhoneNumber"].ToString(), commandReader["Birthday"].ToString(), Functions.db, Convert.ToBoolean(commandReader["is2FAEnabled"]));
            homepage.Closed += (s, args) => this.Close();
            homepage.Show();
            Notifications notifier = new Notifications();
            notifier.showAlert("Successfully logged in", Notifications.enmType.Success);
        }

        private void RegisterPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanel.Visible = true;
            seePassword = false;
            SeePasswordPhotoLogin.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            SeePasswordPhoto.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            PasswordTextBox.PasswordChar = '*';
        }

        private void LoginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanel.Visible = false;
            seePassword = false;
            SeePasswordPhotoLogin.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            SeePasswordPhoto.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            PasswordTextBox.PasswordChar = '*';
        }

        private void SeePassword_Click(object sender, EventArgs e)
        {
            if (!seePassword)
            {
                seePassword = true;
                SeePasswordPhoto.Image = global::Firebank.Properties.Resources.visible_removebg_preview;
                PasswordTextBoxRegister.PasswordChar = '\0';
            }
            else
            {
                seePassword = false;
                SeePasswordPhoto.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
                PasswordTextBoxRegister.PasswordChar = '*';
            }
        }

        private void SeePasswordPhotoLogin_Click(object sender, EventArgs e)
        {
            if (!seePassword)
            {
                seePassword = true;
                SeePasswordPhotoLogin.Image = global::Firebank.Properties.Resources.visible_removebg_preview;
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                seePassword = false;
                SeePasswordPhotoLogin.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            if (UsernameTextBoxRegister.Text.Length >= 6 && PasswordTextBoxRegister.Text.Length >= 8 && UsernameTextBoxRegister.Text.Length <= 32 && PasswordTextBoxRegister.Text.Length <= 20 && rx.IsMatch(EmailTextBoxRegister.Text))
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Functions.db,
                    CommandText = "SELECT * FROM Users WHERE Username = @Username OR Email = @Email OR MobilePhoneNumber = @MobilePhoneNumber OR NIF = @NIF OR CC = @CC"
                };
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = UsernameTextBoxRegister.Text;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = EmailTextBoxRegister.Text;
                command.Parameters.Add("@MobilePhoneNumber", SqlDbType.VarChar).Value = PhoneTextBoxRegister.Text;
                command.Parameters.Add("@NIF", SqlDbType.VarChar).Value = TAXTextBoxRegister.Text;
                command.Parameters.Add("@CC", SqlDbType.VarChar).Value = CCNTextBox.Text;
                Functions.db.Open();
                SqlDataReader commandReader = command.ExecuteReader();
                commandReader.Read();
                if (commandReader.HasRows)
                {
                    ClearReaders(commandReader, command);
                    Notifications notifier = new Notifications();
                    notifier.showAlert("There is already an account with that informations.", Notifications.enmType.Error);
                }
                else
                {
                    ClearReaders(commandReader, command);
                    command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "INSERT INTO Users (Username, Password, Email, NIF, CC, Birthday, MobilePhoneNumber) VALUES (@Username, @Password, @Email, @NIF, @CC, @Birthday, @MobilePhoneNumber)"
                    };
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = UsernameTextBoxRegister.Text;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = ComputeSha256Hash(PasswordTextBoxRegister.Text);
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = EmailTextBoxRegister.Text;
                    command.Parameters.Add("@NIF", SqlDbType.VarChar).Value = TAXTextBoxRegister.Text;
                    command.Parameters.Add("@CC", SqlDbType.VarChar).Value = CCNTextBox.Text;
                    command.Parameters.Add("@Birthday", SqlDbType.Date).Value = DatePickerRegister.Text;
                    command.Parameters.Add("@MobilePhoneNumber", SqlDbType.VarChar).Value = PhoneTextBoxRegister.Text;
                    command.ExecuteNonQuery();
                    Notifications notifier = new Notifications();
                    notifier.showAlert("Account created successfully.", Notifications.enmType.Success);
                    VerificationSystem a = new VerificationSystem();
                    a.Setup(EmailTextBoxRegister.Text, PhoneTextBoxRegister.Text);
                    a.ShowDialog();
                    new Homepage(UsernameTextBoxRegister.Text, EmailTextBoxRegister.Text, TAXTextBoxRegister.Text, CCNTextBox.Text, PhoneTextBoxRegister.Text, DatePickerRegister.Text, Functions.db, false).Show();
                    this.Hide();
                }
                Functions.db.Close();
            }
            else
            {
                Notifications notifier;
                if (!(UsernameTextBoxRegister.Text.Length >= 6))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(UsernameTextBoxRegister.Text.Length <= 32))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBoxRegister.Text.Length >= 8))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBoxRegister.Text.Length <= 20))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
                else if (!(EmailTextBoxRegister.Text.Contains("@")))
                {
                    notifier = new Notifications();
                    notifier.showAlert("Invalid Email.", Notifications.enmType.Error);
                }
            }
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

        private void Lbl6_Click(object sender, EventArgs e)
        {
            new ForgotPassword().ShowDialog();
        }

        private void ClearReaders(SqlDataReader commandReader, SqlCommand command)
        {
            commandReader.Close();
            commandReader.Dispose();
            command.Dispose();
        }
    }
}
