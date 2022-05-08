using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Authentication : Form
    {
        public static string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;";
        SqlConnection db = new SqlConnection(ConnectionString);
        private bool seePassword;
        public Authentication()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length >= 6 && PasswordTextBox.Text.Length >= 8 && UsernameTextBox.Text.Length <= 32 && PasswordTextBox.Text.Length <= 20)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", db);
                command.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                db.Open();
                SqlDataReader commandReader = command.ExecuteReader();
                commandReader.Read();
                if (commandReader.HasRows)
                {
                    MessageBox.Show(commandReader["Username"].ToString());
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
                db.Close();
            }
            else
            {
                if (!(UsernameTextBox.Text.Length >= 6))
                {
                    MessageBox.Show("Enter an username between 6 and 32 characters.");
                }
                else if (!(UsernameTextBox.Text.Length <= 32))
                {
                    MessageBox.Show("Enter an username between 6 and 32 characters.");
                }
                else if (!(PasswordTextBox.Text.Length >= 8))
                {
                    MessageBox.Show("Enter a password between 8 and 20 characters.");
                }
                else if (!(PasswordTextBox.Text.Length <= 20))
                {
                    MessageBox.Show("Enter a password between 8 and 20 characters.");
                }
            }
        }

        private void RegisterPanelButton_Click(object sender, EventArgs e)
        {
            LoginPanelButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanelButton.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RegisterPanel.Visible = true;
            seePassword = false;
            SeePasswordPhotoLogin.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            PasswordTextBox.PasswordChar = '*';
            seePassword = false;
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
            seePassword = false;
            SeePasswordPhoto.Image = global::Firebank.Properties.Resources.invisible_removebg_preview;
            PasswordTextBox.PasswordChar = '*';
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
            if (UsernameTextBoxRegister.Text.Length >= 6 && PasswordTextBoxRegister.Text.Length >= 8 && UsernameTextBoxRegister.Text.Length <= 32 && PasswordTextBoxRegister.Text.Length <= 20 && EmailTextBoxRegister.Text.Contains("@"))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = db;
                command.CommandText = "SELECT * FROM Users WHERE Username = @Username OR Email = @Email OR MobilePhoneNumber = @MobilePhoneNumber OR NIF = @NIF OR CC = @CC";
                command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar).Value = UsernameTextBoxRegister.Text;
                command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = EmailTextBoxRegister.Text;
                command.Parameters.Add("@MobilePhoneNumber", System.Data.SqlDbType.VarChar).Value = PhoneTextBoxRegister.Text;
                command.Parameters.Add("@NIF", System.Data.SqlDbType.VarChar).Value = TAXTextBoxRegister.Text;
                command.Parameters.Add("@CC", System.Data.SqlDbType.VarChar).Value = CCNTextBox.Text;
                db.Open();
                SqlDataReader commandReader = command.ExecuteReader();
                commandReader.Read();
                if (commandReader.HasRows)
                {
                    ClearReaders(commandReader, command);
                    MessageBox.Show("There is already an account with that informations.");
                }
                else
                {
                    ClearReaders(commandReader, command);
                    command = new SqlCommand();
                    command.Connection = db;
                    command.CommandText = "INSERT INTO Users (Username, Password, Email, NIF, CC, Birthday, MobilePhoneNumber) VALUES (@Username, @Password, @Email, @NIF, @CC, @Birthday, @MobilePhoneNumber)";
                    command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar).Value = UsernameTextBoxRegister.Text;
                    command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = PasswordTextBoxRegister.Text;
                    command.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = EmailTextBoxRegister.Text;
                    command.Parameters.Add("@NIF", System.Data.SqlDbType.VarChar).Value = TAXTextBoxRegister.Text;
                    command.Parameters.Add("@CC", System.Data.SqlDbType.VarChar).Value = CCNTextBox.Text;
                    command.Parameters.Add("@Birthday", System.Data.SqlDbType.Date).Value = DatePickerRegister.Text;
                    command.Parameters.Add("@MobilePhoneNumber", System.Data.SqlDbType.VarChar).Value = PhoneTextBoxRegister.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully.");
                    this.Close();
                    this.Dispose();
                    //new CredentialsVerification();
                }
                db.Close();
            }
            else
            {
                if (!(UsernameTextBoxRegister.Text.Length >= 6))
                {
                    MessageBox.Show("Enter an username between 6 and 32 characters.");
                }
                else if (!(UsernameTextBoxRegister.Text.Length <= 32))
                {
                    MessageBox.Show("Enter an username between 6 and 32 characters.");
                }
                else if (!(PasswordTextBoxRegister.Text.Length >= 8))
                {
                    MessageBox.Show("Enter a password between 8 and 20 characters.");
                }
                else if (!(PasswordTextBoxRegister.Text.Length <= 20))
                {
                    MessageBox.Show("Enter a password between 8 and 20 characters.");
                }
                else if (!(EmailTextBoxRegister.Text.Contains("@")))
                {
                    MessageBox.Show("Invalid Email.");
                }
            }
        }

        private void lbl6_Click(object sender, EventArgs e)
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
