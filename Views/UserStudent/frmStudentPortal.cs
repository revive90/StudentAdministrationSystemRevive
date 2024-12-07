using StudentAdministrationSystemRevive.Views.Alerts;
using StudentAdministrationSystemRevive.Views.StudentPages;
using System.Runtime.InteropServices;

namespace StudentAdministrationSystemRevive.Views.Student
{
    public partial class frmStudentPortal : Form
    {
        public frmStudentPortal()
        {
            InitializeComponent();

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
            frmStudentHome frm = new frmStudentHome();
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hideIndicatorPanels();
        }



        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            frmStudentHome frm = new frmStudentHome();
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hideIndicatorPanels();
            pnlIndicatorHome.Visible = true;

        }

        private void btnMyModulesScreen_Click(object sender, EventArgs e)
        {
            hideIndicatorPanels();
            pnlIndicatorMyModules.Visible = true;

            frmStudentModules frm = new frmStudentModules();
            frm.TopLevel = false;
            pnlContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();


            // 

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
