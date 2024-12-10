using StudentAdministrationSystemRevive.Views.Alerts;
using StudentAdministrationSystemRevive.Views.StudentPages;
using System.Runtime.InteropServices;
using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;


namespace StudentAdministrationSystemRevive.Views.Student
{
    public partial class frmStudentPortal : Form
    {
        private User _currentUser;
        public static string _email;
        private UserService _userService;

        public frmStudentPortal(string email)
        {
            InitializeComponent();
            _email = email;
            _userService = new UserService(new UserRepository());
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);





        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void frmStudentPortal_Load(object sender, EventArgs e)
        {
            frmStudentHome frm = new frmStudentHome(_userService);
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            try
            {
                GlobalUserInfo.Email = _email; // Store the email globally
                GlobalUserInfo.StudentID = _userService.GetStudentIDByEmail(_email);

                lblStudentID.Text = GlobalUserInfo.StudentID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing portal: {ex.Message}");
            }

            hideIndicatorPanels();
            lblAccountEmail.Text = _email;
        }



        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            frmStudentHome frm = new frmStudentHome(_userService);
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hideIndicatorPanels();
            pnlIndicatorHome.Visible = true;

        }

        private void btnMyModulesScreen_Click(object sender, EventArgs e)
        {
            string studentID = _userService.GetStudentIDByEmail(_email);
            frmStudentModules frm = new frmStudentModules(studentID,_userService);
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnMyResultsScreen_Click(object sender, EventArgs e)
        {
            frmStudentMyResults frm = new frmStudentMyResults();
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hideIndicatorPanels();
            pnlIndicatorResults.Visible = true;
        }

        private void btnMyDetails_Click(object sender, EventArgs e)
        {
            frmStudentMyDetails frm = new frmStudentMyDetails();
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hideIndicatorPanels();
            pnlIndicatorMyDetails.Visible = true;
        }

        private void btnHelpSupportScreen_Click(object sender, EventArgs e)
        {
            frmStudentSupport frm = new frmStudentSupport();
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hideIndicatorPanels();
            pnlIndicatorSupport.Visible = true;
        }

        private void btnHomeScreen_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }


        //Method to hide the small nav item indicators
        //these indicators show when one of the nav menus is clicked
        private void hideIndicatorPanels()
        {
            pnlIndicatorHome.Visible = false;
            pnlIndicatorMyDetails.Visible = false;
            pnlIndicatorMyModules.Visible = false;
            pnlIndicatorResults.Visible = false;
            pnlIndicatorSupport.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {


            frmExitDialog frm = new frmExitDialog();
            frm.ShowDialog();
        }

        private void pnlContentPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
