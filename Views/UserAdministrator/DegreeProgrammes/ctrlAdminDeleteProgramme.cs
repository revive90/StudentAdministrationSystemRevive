using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class ctrlAdminDeleteProgramme : UserControl
    {
        public ctrlAdminDeleteProgramme()
        {
            InitializeComponent();
        }

        private void btnRemoveProg_Click(object sender, EventArgs e)
        {
            string programmeCode = txtRPProgCode.Text.ToString().Trim();

            DegreeProgrammeService _degreeProgrammeService = new DegreeProgrammeService();

            bool success = _degreeProgrammeService.RemoveProgramme(programmeCode);

            if (success)
            {
                MessageBox.Show("Degree Programme successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to remove Degree Programme.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFindProg_Click(object sender, EventArgs e)
        {
            string programmeTitle = txtRPProgTitle.Text.ToString().Trim();

            DegreeProgrammeService degreeProgrammeService = new DegreeProgrammeService();

            var programmes = degreeProgrammeService.GetProgrammeByTitle(programmeTitle);

            dgRemoveProgTable.DataSource = programmes;
        }
    }
}
