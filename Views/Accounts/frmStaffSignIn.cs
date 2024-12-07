using StudentAdministrationSystemRevive.Accounts;
using StudentAdministrationSystemRevive.Views.Administrator;

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
