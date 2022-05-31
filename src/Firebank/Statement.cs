using System.Data;
using System.Windows.Forms;

namespace Firebank
{
    public partial class Statement : Form
    {
        public Statement(DataTable statement)
        {
            InitializeComponent();
            statementgrid.DataSource = statement;
        }
    }
}
