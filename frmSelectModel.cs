using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI1000_Example
{
    public partial class frmSelectModel : Form
    {
        public frmSelectModel()
        {
            InitializeComponent();
        }

        private void btnOpenDi1000_Click(object sender, EventArgs e)
        {
            (new frmDi1000()).Show(); //show frmDi1000
            this.Hide(); //application will exit from frmDi1000
        }

        private void btnOpenDi10001k_click(object sender, EventArgs e)
        {
            (new frmDi10001k()).Show(); //show frmDi1000
            this.Hide(); //application will exit from frmDi1000
        }
    }
}
