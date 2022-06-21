using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebank
{
    public partial class UsersUserControl : UserControl
    {
        private bool Confirm = false;
        public UsersUserControl()
        {
            InitializeComponent();
            StartUPDataGridView(false);
        }

        private void StartUPDataGridView(bool clear)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                if (clear)
                {
                    UsersGrid.DataSource = null;
                    UsersGrid.Rows.Clear();
                }
                SqlCommand command = new SqlCommand
                {
                    Connection = Functions.db,
                    CommandText = "SELECT ID, Username, Email, MobilePhoneNumber, Birthday, NIF, CC, VerifiedEmail, VerifiedMobilePhone, is2FAEnabled, LastIP, isAdmin FROM Users"
                };
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                UsersGrid.DataSource = dataSet.Tables[0];
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                if (textBox1.Text == "")
                {
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "SELECT ID, Username, Email, MobilePhoneNumber, Birthday, NIF, CC, VerifiedEmail, VerifiedMobilePhone, is2FAEnabled, LastIP, isAdmin FROM Users"
                    };
                    Functions.db.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    UsersGrid.DataSource = null;
                    UsersGrid.Rows.Clear();
                    UsersGrid.DataSource = ds.Tables[0];
                    Functions.db.Close();
                }
                else
                {
                    SqlCommand command = new SqlCommand
                    {
                        Connection = Functions.db,
                        CommandText = "SELECT ID, Username, Email, MobilePhoneNumber, Birthday, NIF, CC, VerifiedEmail, VerifiedMobilePhone, is2FAEnabled, LastIP, isAdmin FROM Users WHERE Username LIKE @Data OR Email LIKE @Data OR MobilePhoneNumber LIKE @Data OR NIF LIKE @Data OR CC LIKE @Data"
                    };
                    command.Parameters.AddWithValue("@Data", $"%{textBox1.Text}%");
                    Functions.db.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    UsersGrid.DataSource = ds.Tables[0];
                    Functions.db.Close();
                }
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }

        private async void ChangeAdminState_Click(object sender, EventArgs e)
        {
            if (Functions.StillAdmin(Functions.UserID))
            {
                int ID = (int)UsersGrid.SelectedRows[0].Cells[0].Value;
                if (Functions.UserID != ID)
                {
                    if (Confirm)
                    {
                        await RemoveAdmin(ID);
                        Confirm = false;
                    }
                    else
                    {
                        Confirm = true;
                        Functions.SendNotification("Click on the button again to confirm.", Notifications.enmType.Info);
                        await Task.Delay(5000);
                        if (Confirm)
                            Confirm = false;
                    }
                }
                else
                {
                    Functions.SendNotification("You can't remove yourself from Admin!", Notifications.enmType.Error);
                }
                
            }
            else
            {
                Functions.Logout();
                this.Dispose();
            }
        }

        private async Task RemoveAdmin(int ID)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = Functions.db,
                CommandText = "UPDATE Users SET isAdmin = @AdminState WHERE ID = @ID"
            };
            command.Parameters.Add("@AdminState", SqlDbType.Bit).Value = !Convert.ToBoolean(UsersGrid.SelectedRows[0].Cells[UsersGrid.ColumnCount - 1].Value);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            Functions.db.Open();
            await command.ExecuteNonQueryAsync();
            Functions.db.Close();
            StartUPDataGridView(true);
        }
    }
}
