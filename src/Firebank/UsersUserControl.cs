using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebank
{
    public partial class UsersUserControl : UserControl
    {
        public UsersUserControl()
        {
            InitializeComponent();
            SqlCommand command = new SqlCommand
            {
                Connection = Authentication.db,
                CommandText = "SELECT * FROM Users"
            };
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            UsersGrid.DataSource = dataSet.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Authentication.db,
                    CommandText = "SELECT * FROM Users"
                };
                Authentication.db.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UsersGrid.DataSource = null;
                UsersGrid.Rows.Clear();
                UsersGrid.DataSource = ds.Tables[0];
                Authentication.db.Close();
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = Authentication.db,
                    CommandText = "SELECT * FROM Users WHERE Username LIKE '%@Data%' OR Email LIKE '%@Data%' OR MobilePhoneNumber LIKE '%@Data%' OR NIF LIKE '%@Data%' OR CC LIKE '%@Data%'"
                };
                command.Parameters.AddWithValue("@Data", textBox1.Text);
                Authentication.db.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                UsersGrid.DataSource = ds.Tables[0];
                Authentication.db.Close();
            }
        }
    }
}
