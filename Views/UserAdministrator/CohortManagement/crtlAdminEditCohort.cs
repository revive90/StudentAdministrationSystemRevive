using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.CohortManagement
{
    public partial class crtlAdminEditCohort : UserControl
    {
        private CohortRepository cohortRepository;
        private bool isUpdating = false;
        public crtlAdminEditCohort()
        {
            InitializeComponent();
            cohortRepository = new CohortRepository();
        }

        private void crtlAdminEditCohort_Load(object sender, EventArgs e)
        {
            showCohorts();
        }

        private void showCohorts()
        {
            try
            {
                CohortServices cohortServices = new CohortServices();
                var cohorts = cohortServices.GetCohorts();
                dg_AD_CohortEdit.DataSource = cohorts;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree Cohorts: {ex.Message}");
            }
        }

        private void btnAD_CohortFindModule_Click(object sender, EventArgs e)
        {
            string progCode = txtAD_Cohort_Search_ModuleTitle.Text;

            CohortServices cohortServices = new CohortServices();
            var cohorts = cohortServices.FindCohortByProgCode(progCode);

            dg_AD_CohortEdit.DataSource = cohorts;
        }

        private void btnAD_CohortSave_Click(object sender, EventArgs e)
        {

        }
    }
}
