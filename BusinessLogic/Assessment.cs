using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class Assessment
    {
        public string AssessmentID { get; set; }
        public string AssessmentTitle { get; set; }
        public string AssessmentDescription { get; set; }
        public int MaximumPossibleMark { get; set; }
        public string ModuleID { get; set; }
        

        public Assessment(string assessmentID, string assessmentTitle, string assessmentDescription, int maxPossibleMark, string moduleID) 
        {
            AssessmentID = assessmentID;
            AssessmentTitle = assessmentTitle;
            AssessmentDescription = assessmentDescription;
            MaximumPossibleMark = maxPossibleMark;
            ModuleID = moduleID;
        }
    }
}
