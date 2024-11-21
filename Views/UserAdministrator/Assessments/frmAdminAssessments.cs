using StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    public partial class frmAdminAssessments : Form
    {
        public frmAdminAssessments()
        {
            InitializeComponent();
            clearControlsPanel();
            var ctrl = new ctrlAdminAddAssessments();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }

        private void newAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminAddAssessments();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }
        private void clearControlsPanel()
        {
            pnlAdminAssessmentsContentPane.Controls.Clear();
        }

      
    }
}
