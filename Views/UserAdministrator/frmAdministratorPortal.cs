using StudentAdministrationSystemRevive.DataAccess;
using StudentAdministrationSystemRevive.Views.Administrator.CohortManagement;
using StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes;
using StudentAdministrationSystemRevive.Views.Administrator.Enrollment;
using StudentAdministrationSystemRevive.Views.Administrator.Overview;
using StudentAdministrationSystemRevive.Views.Administrator.Results;
using StudentAdministrationSystemRevive.Views.Administrator.StudentManagement;
using StudentAdministrationSystemRevive.Views.Administrator.TeachingStaff;
using StudentAdministrationSystemRevive.Views.Alerts;
using StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments;

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
            frmAdminOverview frm = new frmAdminOverview();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Display the exit form as a dialog window

            frmExitDialog frm = new frmExitDialog();
            frm.ShowDialog();
        }

        private void btnTeachingStaff_Click(object sender, EventArgs e)
        {
            frmAdminTeachingStaff frm = new frmAdminTeachingStaff();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            AdminConnect.initConnection();
        }

        private void btnDegreeProgrammes_Click(object sender, EventArgs e)
        {
            frmAdminDegreeProgrammes frm = new frmAdminDegreeProgrammes();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            hidepanels();
            pnlDegreeIndicator.Visible = true;
        }

        private void btnCohortManagement_Click(object sender, EventArgs e)
        {
            frmAdminCohortManagement frm = new frmAdminCohortManagement();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hidepanels();
            pnlCohortIndicator.Visible = true;
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            frmAdminEnrollment frm = new frmAdminEnrollment();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hidepanels();
            pnlEnrollmentIndicator.Visible = true;
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            frmAdminStudentManagement frm = new frmAdminStudentManagement();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hidepanels();
            pnlStudentsIndicator.Visible = true;
        }



        private void btnResults_Click(object sender, EventArgs e)
        {
            frmAdminResults frm = new frmAdminResults();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hidepanels();
            pnlResult.Visible = true;
        }

        private void frmAdministratorPortal_Load(object sender, EventArgs e)
        {
            hidepanels();
        }

        private void btnAssessments_Click(object sender, EventArgs e)
        {
            frmAdminAssessments frm = new frmAdminAssessments();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            hidepanels();
            pnlAssessments.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.Show();
            this.Close();
        }

        private void hidepanels()
        {
            pnlAssessments.Visible = false;
            pnlCohortIndicator.Visible = false;
            pnlDegreeIndicator.Visible = false;
            pnlEnrollmentIndicator.Visible = false;
            pnlStudentsIndicator.Visible = false;
            pnlResult.Visible = false;
        }
    }
}
