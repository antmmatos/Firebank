using System;
using System.Windows.Forms;

namespace Firebank
{
    public partial class InputBox : Form
    {
        public string value;
        private bool isPassword = false;
        private string _successMessage;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        public InputBox(string Title, string Label, bool password, string successMessage)
        {
            InitializeComponent();
            this.Text = Title;
            CustomLabel.Text = Label;
            _successMessage = successMessage;
            if (password)
            {
                ValueTextBox.PasswordChar = '*';
                isPassword = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (isPassword)
            {
                if (ValueTextBox.TextLength >= 8)
                {
                    value = ValueTextBox.Text;
                    MessageBox.Show(_successMessage);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A minimum of 8 characters is required.");
                }
            }
            else
            {
                if (ValueTextBox.TextLength > 0)
                {
                    value = ValueTextBox.Text;
                    MessageBox.Show(_successMessage);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid value.");
                }
            }
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
    }
}
