using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class ctrlAdminEditProgrammes : UserControl
    {
        private ProgrammeRepository programmeRepository;
        private bool isUpdating = false;
        public ctrlAdminEditProgrammes()
        {
            InitializeComponent();
            programmeRepository = new ProgrammeRepository();
        }

        private void btnEPFindProg_Click(object sender, EventArgs e)
        {
            string programmeTitle = txtEPProgTitle.Text.ToString().Trim();

            DegreeProgrammeService degreeProgrammeService = new DegreeProgrammeService();

            var programmes = degreeProgrammeService.GetProgrammeByTitle(programmeTitle);

            dgEPEditProgTable.DataSource = programmes;
        }



        private void btnEPSaveChanges_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            foreach (DataGridViewRow row in dgEPEditProgTable.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var degreeProgrammeID = row.Cells["DegreeProgrammeID"].Value?.ToString();
                var programmeTitle = row.Cells["ProgrammeTitle"].Value?.ToString();
                var programmeDescription = row.Cells["ProgrammeDescription"].Value?.ToString();
                var programmeDuration = row.Cells["ProgrammeDuration"].Value?.ToString();


                if (string.IsNullOrWhiteSpace(degreeProgrammeID) ||
                    string.IsNullOrWhiteSpace(programmeTitle) ||
                    string.IsNullOrWhiteSpace(programmeDescription) ||
                    string.IsNullOrWhiteSpace(programmeDuration))
                {
                    continue;
                }


                programmeRepository.UpdateDegreeProgramme(degreeProgrammeID, programmeTitle, programmeDescription, programmeDuration);
            }


            isUpdating = false;

            MessageBox.Show("Changes saved successfully.");
        }
    }
}
