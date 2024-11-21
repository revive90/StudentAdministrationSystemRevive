using StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes;
using StudentAdministrationSystemRevive.Views.UserAdministrator;
using StudentAdministrationSystemRevive.Views.UserAdministrator.CohortManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.Administrator.CohortManagement
{
    public partial class frmAdminCohortManagement : Form
    {
        public frmAdminCohortManagement()
        {
            InitializeComponent();
        }
        private void clearControlsPanel()
        {
            pnlAdminCohortContentPane.Controls.Clear();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
        }

        private void editCohortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new crtlAdminEditCohort();
            pnlAdminCohortContentPane.Controls.Add(ctrl);
        }

        private void createCohortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminAddCohort();
            pnlAdminCohortContentPane.Controls.Add(ctrl);
        }

        private void viewCohortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            clearControlsPanel();
            var ctrl = new ctrlAdminViewCohort();
            pnlAdminCohortContentPane.Controls.Add(ctrl);
        }

        private void frmAdminCohortManagement_Load(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminViewCohort();
            pnlAdminCohortContentPane.Controls.Add(ctrl);
        }
    }
}
