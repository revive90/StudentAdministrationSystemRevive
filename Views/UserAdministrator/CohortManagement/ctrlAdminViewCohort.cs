using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.CohortManagement
{
    public partial class ctrlAdminViewCohort : UserControl
    {

        public ctrlAdminViewCohort()
        {
            InitializeComponent();

        }

        private void ctrlAdminViewCohort_Load(object sender, EventArgs e)
        {
            showCohorts();
        }

        private void showCohorts()
        {
            try
            {
                CohortServices cohortServices = new CohortServices();
                var cohorts = cohortServices.GetCohorts();
                dg_AD_CohortsViewAll.DataSource = cohorts;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree Cohorts: {ex.Message}");
            }
        }

        private void btnAllCohort_Click(object sender, EventArgs e)
        {
            showCohorts();
        }
    }
}
