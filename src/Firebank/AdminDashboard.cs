using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Firebank
{
    public partial class AdminDashboard : Form
    {
        private readonly string _Username;
        private readonly string _Email;
        private readonly string _NIF;
        private readonly string _CC;
        private readonly string _PhoneNumber;
        private readonly string _Birthday;
        private readonly bool _2FA;
        private static void ThreadProc()
        {
            Application.Run(new Authentication());
        }        

        public AdminDashboard(string Username, string Email, string NIF, string CC, string PhoneNumber, string Birthday, bool FA)
        {
            InitializeComponent();
            _Username = Username;
            _Email = Email;
            _NIF = NIF;
            _CC = CC;
            _PhoneNumber = PhoneNumber;
            _Birthday = Birthday;
            _2FA = FA;
            SettingsUserControl.ButtonClick += new EventHandler(LogoutButtonClick);
            StartUPHomepage();
            StartUPUserInfo();
        }

        private void StartUPUserInfo()
        {
            SettingsUserControl.SetUserInfo(_Username, _Email, _NIF, _CC, _PhoneNumber, _Birthday, _2FA);
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
            this.Dispose();
        }

        private void StartUPHomepage()
        {
            WelcomeLabel.Text = "Welcome " + _Username;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                SettingsUserControl.Visible = true;
                UsersUserControl.Visible = false;
                AccountManagerUserControl.Visible = false;
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                SettingsUserControl.Visible = false;
                UsersUserControl.Visible = false;
                AccountManagerUserControl.Visible = false;
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }

        private void UsersManagementButton_Click(object sender, EventArgs e)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                SettingsUserControl.Visible = false;
                UsersUserControl.Visible = true;
                AccountManagerUserControl.Visible = false;
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }

        private void AccountManagementButton_Click(object sender, EventArgs e)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                AccountManagerUserControl.Visible = true;
                SettingsUserControl.Visible = false;
                UsersUserControl.Visible = false;
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }
    }
}
