using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Firebank
{
    public partial class RequestAccount : Form
    {
        public RequestAccount()
        {
            InitializeComponent();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand
            { //TODO
                Connection = Authentication.db,
                CommandText = "INSERT INTO "
            };
        }
    }
}
