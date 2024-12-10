using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentResult
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProgrammeCode { get; set; }
        public string ProgrammeName { get; set; }
        public int ModulesAssessedCount { get; set; }
        public double ProgrammeMark { get; set; }
        public string Grade { get; set; }
        public string Result { get; set; }
    }
}
