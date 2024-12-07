namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class frmAdminDegreeProgrammes : Form
    {
        public frmAdminDegreeProgrammes()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminDegreeProgrammes_Load(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminViewProgrammes();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }

        private void viewProgrammesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminViewProgrammes();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }


        //--------------------------------------------------------------------
        private void clearControlsPanel()
        {
            pnlAdminDegreeProgrammesContentPane.Controls.Clear();
        }

        private void editProgrammesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminEditProgrammes();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }

        private void createProgrammesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminCreateProgramme();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }

        private void deleteProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminDeleteProgramme();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }

        private void addModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminAddModules();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }

        private void removeModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminRemoveModules();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }

        private void editModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControlsPanel();
            var ctrl = new ctrlAdminEditModules();
            pnlAdminDegreeProgrammesContentPane.Controls.Add(ctrl);
        }
    }
}
