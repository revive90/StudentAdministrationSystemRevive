using StudentAdministrationSystemRevive.Views.Alerts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.Administrator
{
    public partial class frmAdministratorPortal : Form
    {
        public frmAdministratorPortal()
        {
            InitializeComponent();
        }

        private void btnHomeScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Display the exit form as a dialog window

            frmExitDialog frm = new frmExitDialog();
            frm.ShowDialog();
        }
    }
}
