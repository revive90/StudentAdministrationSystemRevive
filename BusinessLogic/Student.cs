namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class Students
    {
        public string StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string DegreeProgrammeID { get; set; }
        public string CohortYear { get; set; }
        public string EnrolmentStatus { get; set; }
        public string DurationYears { get; set; }

        public Students(string studentID, string firstname, string lastname, string email, string degreeProgrammeID,
            string cohortYear, string enrolmentStatus, string durationYears)
        {
            StudentID = studentID;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            DegreeProgrammeID = degreeProgrammeID;
            CohortYear = cohortYear;
            EnrolmentStatus = enrolmentStatus;
            DurationYears = durationYears;
        }

    }
}
