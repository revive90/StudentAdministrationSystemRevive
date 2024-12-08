using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentAssessment
    {
        public string StudentID { get; set; }
        public string AssessmentID { get; set; }
        public int? Mark { get; set; }

        public StudentAssessment(string studentID, string assessmentID, int mark) 
        {
            StudentID = studentID;
            AssessmentID = assessmentID;
            Mark = mark;
        }
    }
}
