using StudentAdministrationSystemRevive.Views.Administrator.CohortManagement;
using StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes;
using StudentAdministrationSystemRevive.Views.Administrator.Enrollment;
using StudentAdministrationSystemRevive.Views.Administrator.Overview;
using StudentAdministrationSystemRevive.Views.Administrator.Results;
using StudentAdministrationSystemRevive.Views.Administrator.StudentManagement;
using StudentAdministrationSystemRevive.Views.Administrator.TeachingStaff;
using StudentAdministrationSystemRevive.Views.Alerts;
using StudentAdministrationSystemRevive.Views.StudentPages;
using StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments;
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
        }

        private void btnDegreeProgrammes_Click(object sender, EventArgs e)
        {
            frmAdminDegreeProgrammes frm = new frmAdminDegreeProgrammes();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnCohortManagement_Click(object sender, EventArgs e)
        {
            frmAdminCohortManagement frm = new frmAdminCohortManagement();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            frmAdminEnrollment frm = new frmAdminEnrollment();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            frmAdminStudentManagement frm = new frmAdminStudentManagement();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }



        private void btnResults_Click(object sender, EventArgs e)
        {
            frmAdminResults frm = new frmAdminResults();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmAdministratorPortal_Load(object sender, EventArgs e)
        {

        }

        private void btnAssessments_Click(object sender, EventArgs e)
        {
            frmAdminAssessments frm = new frmAdminAssessments();
            frm.TopLevel = false;
            pnlAdminContentPane.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
