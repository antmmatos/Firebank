using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
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
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Functions.ComputeSha512Hash(PasswordTextBox.Text);
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
                        Functions.Alert("An error occurred. Please contact support team.", Notifications.enmType.Error);
                        return;
                    }
                    if (!Convert.ToBoolean(commandReader["VerifiedEmail"].ToString()) || !Convert.ToBoolean(commandReader["VerifiedMobilePhone"].ToString()))
                    {
                        VerificationSystem vs = new VerificationSystem();
                        vs.Setup(commandReader["Email"].ToString(), commandReader["MobilePhoneNumber"].ToString());
                        vs.ShowDialog(this);
                    }
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
                        await command.ExecuteNonQueryAsync();
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
                            InputBox input = new InputBox("Firebank - New IP Detected", "New IP Detected\nEnter the code sent by Email", false, "");
                            Functions.Alert("Check your mailbox with the verification code", Notifications.enmType.Info);
                            input.ShowDialog(this);
                            if (input.value == FACode)
                            {
                                await ChangeIP(IP, Convert.ToInt32(commandReader["ID"]));
                                ContinueLogin(commandReader);
                            }
                            else
                            {
                                MessageBox.Show("Wrong Verification Code");
                                Environment.Exit(0);
                            }
                        }
                    }
                    
                }
                else
                {
                    Functions.Alert("Username or Password is incorrect", Notifications.enmType.Error);
                    commandReader.Close();
                }
                Functions.db.Close();
            }
            else
            {
                if (!(UsernameTextBox.Text.Length >= 6))
                {
                    Functions.Alert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(UsernameTextBox.Text.Length <= 32))
                {
                    Functions.Alert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBox.Text.Length >= 8))
                {
                    Functions.Alert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBox.Text.Length <= 20))
                {
                    Functions.Alert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
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
                Functions.Alert("Check your mailbox with the verification code", Notifications.enmType.Info);
                InputBox input = new InputBox("Firebank - 2FA", "Enter the code sent by Email", false, "");
                input.ShowDialog(this);
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
                    MessageBox.Show("Wrong Verification Code");
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
            Functions.UserID = Convert.ToInt32(commandReader["ID"]);
            AdminDashboard homepage = new AdminDashboard(commandReader["Username"].ToString(), commandReader["Email"].ToString(), commandReader["NIF"].ToString(), commandReader["CC"].ToString(), commandReader["MobilePhoneNumber"].ToString(), commandReader["Birthday"].ToString(), Convert.ToBoolean(commandReader["is2FAEnabled"]));
            homepage.Closed += (s, args) => this.Close();
            homepage.Show();
            Functions.Alert("Successfully logged in", Notifications.enmType.Success);
        }

        private void OpenUser(dynamic commandReader)
        {
            Functions.UserID = Convert.ToInt32(commandReader["ID"]);
            Homepage homepage = new Homepage(commandReader["Username"].ToString(), commandReader["Email"].ToString(), commandReader["NIF"].ToString(), commandReader["CC"].ToString(), commandReader["MobilePhoneNumber"].ToString(), commandReader["Birthday"].ToString(), Convert.ToBoolean(commandReader["is2FAEnabled"]));
            homepage.Closed += (s, args) => this.Close();
            homepage.Show();
            Functions.Alert("Successfully logged in", Notifications.enmType.Success);
        }

        private void RegisterPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            RegisterPanel.Visible = true;
            seePassword = false;
            SeePasswordPhotoLogin.Image = Properties.Resources.invisible_removebg_preview;
            SeePasswordPhoto.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            PasswordTextBox.PasswordChar = '*';
        }

        private void LoginPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RegisterPanel.Visible = false;
            seePassword = false;
            SeePasswordPhotoLogin.Image = Properties.Resources.invisible_removebg_preview;
            SeePasswordPhoto.Image = Properties.Resources.invisible_removebg_preview;
            PasswordTextBox.PasswordChar = '*';
        }

        private void SeePassword_Click(object sender, EventArgs e)
        {
            if (!seePassword)
            {
                seePassword = true;
                SeePasswordPhoto.Image = Properties.Resources.visible_removebg_preview;
                PasswordTextBoxRegister.PasswordChar = '\0';
            }
            else
            {
                seePassword = false;
                SeePasswordPhoto.Image = Properties.Resources.invisible_removebg_preview;
                PasswordTextBoxRegister.PasswordChar = '*';
            }
        }

        private void SeePasswordPhotoLogin_Click(object sender, EventArgs e)
        {
            if (!seePassword)
            {
                seePassword = true;
                SeePasswordPhotoLogin.Image = Properties.Resources.visible_removebg_preview;
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                seePassword = false;
                SeePasswordPhotoLogin.Image = Properties.Resources.invisible_removebg_preview;
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
                    Functions.Alert("There is already an account with that informations.", Notifications.enmType.Error);
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
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Functions.ComputeSha512Hash(PasswordTextBoxRegister.Text);
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = EmailTextBoxRegister.Text;
                    command.Parameters.Add("@NIF", SqlDbType.VarChar).Value = TAXTextBoxRegister.Text;
                    command.Parameters.Add("@CC", SqlDbType.VarChar).Value = CCNTextBox.Text;
                    command.Parameters.Add("@Birthday", SqlDbType.Date).Value = DatePickerRegister.Text;
                    command.Parameters.Add("@MobilePhoneNumber", SqlDbType.VarChar).Value = PhoneTextBoxRegister.Text;
                    command.ExecuteNonQuery();
                    command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "SELECT SCOPE_IDENTITY()"
                    };
                    Functions.Alert("Account created successfully.", Notifications.enmType.Success);
                    VerificationSystem a = new VerificationSystem();
                    a.Setup(EmailTextBoxRegister.Text, PhoneTextBoxRegister.Text);
                    a.ShowDialog(this);
                    Functions.UserID = (int)command.ExecuteScalar();
                    new Homepage(UsernameTextBoxRegister.Text, EmailTextBoxRegister.Text, TAXTextBoxRegister.Text, CCNTextBox.Text, PhoneTextBoxRegister.Text, DatePickerRegister.Text, false).Show();
                    this.Hide();
                }
                Functions.db.Close();
            }
            else
            {
                if (!(UsernameTextBoxRegister.Text.Length >= 6))
                {
                    Functions.Alert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(UsernameTextBoxRegister.Text.Length <= 32))
                {
                    Functions.Alert("Enter an username between 6 and 32 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBoxRegister.Text.Length >= 8))
                {
                    Functions.Alert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
                else if (!(PasswordTextBoxRegister.Text.Length <= 20))
                {
                    Functions.Alert("Enter a password between 8 and 20 characters.", Notifications.enmType.Error);
                }
                else if (!(EmailTextBoxRegister.Text.Contains("@")))
                {
                    Functions.Alert("Invalid Email.", Notifications.enmType.Error);
                }
            }
        }

        private void Lbl6_Click(object sender, EventArgs e)
        {
            new ForgotPassword().ShowDialog(this);
        }

        private void ClearReaders(SqlDataReader commandReader, SqlCommand command)
        {
            commandReader.Close();
            commandReader.Dispose();
            command.Dispose();
        }
    }
}
