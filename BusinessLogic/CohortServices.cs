using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class CohortServices
    {
        private readonly CohortRepository _repository;
        public CohortServices()
        {
            _repository = new CohortRepository();
        }

        // Adding a new Cohort
        public bool AddCohort(Cohort cohort)
        {
            if (cohort == null)
            {
                MessageBox.Show("Cohort is Null", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return _repository.InsertCohort(cohort);
            }

        }

        public List<Cohort> GetCohorts()
        {
            return _repository.GetAllCohorts();
        }


        // Find Cohorts by Module Code
        public List<Cohort> FindCohortByProgCode(string progCode)
        {
            return _repository.GetCohortsByProgCode(progCode);
        }
    }
}
