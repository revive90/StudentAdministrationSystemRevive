namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class Cohort
    {
        public string CohortID { get; set; }
        public string CohortStartYear { get; set; }
        public string CohortProgrammeCode { get; set; }

        // Module Constructor
        public Cohort(string moduleID, string moduleTitle, string moduleDescription)
        {
            CohortID = moduleID;
            CohortStartYear = moduleTitle;
            CohortProgrammeCode = moduleDescription;
        }
    }
}
