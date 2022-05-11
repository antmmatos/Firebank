using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
