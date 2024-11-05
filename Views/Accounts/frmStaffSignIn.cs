using StudentAdministrationSystemRevive.Accounts;
using StudentAdministrationSystemRevive.Views.Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.Accounts
{
    public partial class frmStaffSignIn : Form
    {
        public frmStaffSignIn()
        {
            InitializeComponent();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.Show();
            this.Close();
        }

        private void btnStaffSignIn_Click(object sender, EventArgs e)
        {
            frmAdministratorPortal frmAdminPortal = new frmAdministratorPortal();
            frmAdminPortal.Show();
            this.Close();
        }
    }
}
