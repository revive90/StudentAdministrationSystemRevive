using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator
{
    public partial class ctrlAdminAddCohort : UserControl
    {
        private readonly CohortServices _cohortService;
        public ctrlAdminAddCohort()
        {
            InitializeComponent();
            _cohortService = new CohortServices();
        }

        private void btnCreateCohort_Click(object sender, EventArgs e)
        {
            // Create Cohort ID
            Random rnd = new Random();
            int cohID = rnd.Next(1, 34000);

            // Collect form data
            string cohortID = cohID.ToString();
            string programmeID = txtAD_Cohort_ProgCode.Text;
            string cohortStart = txtAD_Cohort_Start_Year.Text;



            // Create the module and degree programme module objects
            Cohort newCohort = new Cohort(cohortID, programmeID, cohortStart);

            // Call the service to insert the module and its relationship
            bool success = _cohortService.AddCohort(newCohort);

            if (success)
            {
                MessageBox.Show("Module created and linked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error creating module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Refresh Cohort TABLE
            showCohorts();
        }

        private void ctrlAdminAddCohort_Load(object sender, EventArgs e)
        {
            showCohorts();
        }

        // Load all cohorts into the datagrid view
        private void showCohorts()
        {
            try
            {
                CohortServices cohortServices = new CohortServices();
                var cohorts = cohortServices.GetCohorts();
                dg_AD_CohortAdd.DataSource = cohorts;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree Cohorts: {ex.Message}");
            }
        }
    }
}
