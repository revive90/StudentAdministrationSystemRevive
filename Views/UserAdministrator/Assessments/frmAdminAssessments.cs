namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    public partial class frmAdminAssessments : Form
    {
        public frmAdminAssessments()
        {
            InitializeComponent();
            clearControlsPanel();
            var ctrl = new ctrlAD_AssessmentAdd();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }
        private void clearControlsPanel()
        {
            pnlAdminAssessmentsContentPane.Controls.Clear();
        }


        private void newAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAD_AssessmentAdd();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }


        private void editExistingAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAD_AssessmentEdit();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }

        private void gradeAnAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAD_AssessmentGrade();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }

        private void removeAnAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAD_AssessmentRemove();
            pnlAdminAssessmentsContentPane.Controls.Add(ctrl);
        }
    }
}
