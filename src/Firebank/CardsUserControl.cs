using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Firebank
{
    public partial class CardsUserControl : UserControl
    {
        List<Account> accounts = new List<Account>();
        List<Card> cards = new List<Card>();
        SqlConnection db = Functions.db;
        public string NIF = "";
        private bool CardsFound = false;
        public CardsUserControl()
        {
            InitializeComponent();
            StartUPCards();
        }

        public void StartUPCards()
        {
            CardsComboBox.Items.Clear();
            cards.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = db;
            command.CommandText = "SELECT Cards.ID, CardNumber, CardExpireDate, CardCVV, AccountID, isActivated, isFreeze, isActivating, Accounts.AccountName FROM Users INNER JOIN Accounts ON Users.ID = Accounts.Account_Owner INNER JOIN Cards ON Accounts.ID = Cards.AccountID WHERE Users.NIF = @NIF";
            command.Parameters.Add("@NIF", SqlDbType.VarChar).Value = NIF;
            try
            {
                db.Open();
            }
            catch (Exception) { }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CardsComboBox.Items.Add("ID: " + reader.GetInt32(0).ToString() + " - Account Connected: " + reader.GetString(8).ToString());
                cards.Add(new Card(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetInt32(4), reader.GetBoolean(5), reader.GetBoolean(6), reader.GetBoolean(7)));
                CardsFound = true;
            }
            if (CardsComboBox.Items.Count == 0)
            {
                CardsComboBox.Items.Add("No Cards found");
            }
            reader.Close();
            db.Close();
        }
        private void CardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CardsFound)
            {
                CVVLabel.Visible = true;
                EDLabel.Visible = true;
                NumberLabel.Visible = true;
                CVVLabel.Text = cards.ElementAt(CardsComboBox.SelectedIndex).CardCVV.ToString();
                EDLabel.Text = cards.ElementAt(CardsComboBox.SelectedIndex).CardExpireDate.ToString("dd/MM/yyyy");
                NumberLabel.Text = cards.ElementAt(CardsComboBox.SelectedIndex).CardNumber.ToString();
                isFreeze.Visible = true;
                isActivated.Visible = true;
                FreezeButton.Visible = true;
                ActivateButton.Visible = true;
                if (cards.ElementAt(CardsComboBox.SelectedIndex).isFreeze)
                {
                    isFreeze.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    isFreeze.ForeColor = System.Drawing.Color.Red;
                }
                if (cards.ElementAt(CardsComboBox.SelectedIndex).isActivated)
                {
                    isActivated.ForeColor = System.Drawing.Color.Green;
                    ActivateButton.Enabled = false;
                }
                else
                {
                    isActivated.ForeColor = System.Drawing.Color.Red;
                    ActivateButton.Enabled = true;
                }
            }
        }

        private void FreezeButton_Click(object sender, EventArgs e)
        {
            if (cards.ElementAt(CardsComboBox.SelectedIndex).isFreeze)
            {
                db.Open();
                cards.ElementAt(CardsComboBox.SelectedIndex).isFreeze = false;
                SqlCommand command = new SqlCommand();
                command.Connection = db;
                command.CommandText = "UPDATE Cards SET isFreeze = 0 WHERE ID = @ID";
                command.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).ID;
                command.ExecuteNonQuery();
                db.Close();
                isFreeze.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                db.Open();
                cards.ElementAt(CardsComboBox.SelectedIndex).isFreeze = true;
                SqlCommand command = new SqlCommand();
                command.Connection = db;
                command.CommandText = "UPDATE Cards SET isFreeze = 1 WHERE ID = @ID";
                command.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).ID;
                command.ExecuteNonQuery();
                db.Close();
                isFreeze.ForeColor = System.Drawing.Color.Green;
            }
        }

        private async void ActivateButton_Click(object sender, EventArgs e)
        {
            if (cards.ElementAt(CardsComboBox.SelectedIndex).isActivating)
            {
                InputBox input = new InputBox("Card Activation", "Enter the activation code", false, "");
                input.ShowDialog();
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "SELECT ActivationCode FROM Cards WHERE ID = @ID"
                };
                command.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).ID;
                db.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (input.value == reader["ActivationCode"].ToString())
                {
                    reader.Close();
                    SqlCommand updateActivation = new SqlCommand
                    {
                        Connection = db,
                        CommandText = "UPDATE Cards SET isActivated = 1 WHERE ID = @ID"
                    };
                    updateActivation.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).ID;
                    updateActivation.ExecuteNonQuery();
                    Notifications notifier = new Notifications();
                    notifier.showAlert("Card Activated successfully", Notifications.enmType.Success);
                    isActivated.ForeColor = System.Drawing.Color.Green;
                    ActivateButton.Enabled = false;
                }
                db.Close();
            }
            else
            {
                string verificationCode = Functions.RandomVerificationCode();
                db.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = db,
                    CommandText = "INSERT INTO Transactions (Sender_ID, Sender_Account, Receiver_ID, Receiver_Account, Quantity, Description) VALUES (@Sender_ID, @Sender_Account, @Receiver_ID, @Receiver_Account, @Quantity, @Code)"
                };
                SqlCommand codeInsert = new SqlCommand
                {
                    Connection = db,
                    CommandText = "UPDATE Cards SET ActivationCode = @ActivationCode WHERE ID = @ID"
                };
                codeInsert.Parameters.Add("@ActivationCode", SqlDbType.VarChar).Value = verificationCode;
                codeInsert.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).ID;
                await codeInsert.ExecuteNonQueryAsync();
                SqlCommand getUserID = new SqlCommand
                {
                    Connection = db,
                    CommandText = "SELECT Users.ID FROM dbo.Accounts INNER JOIN dbo.Users ON Accounts.Account_Owner = Users.ID WHERE Accounts.ID = @ID"
                };
                SqlCommand isActivatingCardQuery = new SqlCommand
                {
                    Connection = db,
                    CommandText = "UPDATE Cards SET isActivating = 1 WHERE ID = @ID"
                };
                getUserID.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).AccountID;
                isActivatingCardQuery.Parameters.Add("@ID", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).ID;
                await isActivatingCardQuery.ExecuteNonQueryAsync();
                cards.ElementAt(CardsComboBox.SelectedIndex).isActivating = true;
                SqlDataReader getUserIDReader = getUserID.ExecuteReader();
                getUserIDReader.Read();
                command.Parameters.Add("@Code", SqlDbType.VarChar).Value = verificationCode;
                command.Parameters.Add("@Sender_ID", SqlDbType.Int).Value = 3;
                command.Parameters.Add("@Sender_Account", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@Receiver_ID", SqlDbType.Int).Value = getUserIDReader["ID"];
                command.Parameters.Add("@Receiver_Account", SqlDbType.Int).Value = cards.ElementAt(CardsComboBox.SelectedIndex).AccountID;
                command.Parameters.Add("@Quantity", SqlDbType.Int).Value = 1;
                getUserIDReader.Close();
                await command .ExecuteNonQueryAsync();
                db.Close();
                Notifications notifier = new Notifications();
                notifier.showAlert("A transaction has been added to your statement with the activation code.", Notifications.enmType.Info);
            }
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            new RequestCard(accounts).ShowDialog();
            StartUPCards();
        }
    }
}
