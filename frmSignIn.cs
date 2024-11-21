using StudentAdministrationSystemRevive.Accounts;
using StudentAdministrationSystemRevive.Views.Accounts;
using StudentAdministrationSystemRevive.Views.Alerts;
using StudentAdministrationSystemRevive.Views.Student;
using System.Runtime.InteropServices;

namespace StudentAdministrationSystemRevive
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void frmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExitDialog frmExitDialog = new frmExitDialog();
            frmExitDialog.ShowDialog();

        }

        private void btnStaffSignInPage_Click(object sender, EventArgs e)
        {
            frmStaffSignIn frmStaffSignIn = new frmStaffSignIn();
            frmStaffSignIn.Show();
            this.Hide();
        }

        private void btnStudentSignIn_Click(object sender, EventArgs e)
        {
            frmStudentPortal frmStudentPortal = new frmStudentPortal();
            frmStudentPortal.Show();
            this.Hide();
        }

        

        private void frmSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
