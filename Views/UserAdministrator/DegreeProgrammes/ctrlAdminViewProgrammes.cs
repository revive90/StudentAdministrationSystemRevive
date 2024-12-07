using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class ctrlAdminViewProgrammes : UserControl
    {
        //private DegreeProgrammeService services = new DegreeProgrammeService();

        public ctrlAdminViewProgrammes()
        {
            InitializeComponent();
        }

        private void ctrlAdminViewProgrammes_Load(object sender, EventArgs e)
        {
            try
            {
                DegreeProgrammeService degreeProgrammeService = new DegreeProgrammeService();

                var programmes = degreeProgrammeService.GetDegreeProgrammes();

                dgVPProgTable.DataSource = programmes;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree programs: {ex.Message}");
            }


        }
    }
}
