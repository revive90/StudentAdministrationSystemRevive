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
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.Show();
            this.Close();
        }

        private void btnStaffSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username and password cannot be blank");
            }
            else
            {
                frmAdministratorPortal frmAdminPortal = new frmAdministratorPortal();
                frmAdminPortal.Show();
                this.Close();
            }
            
        }
    }
}
