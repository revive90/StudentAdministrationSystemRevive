using StudentAdministrationSystemRevive.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class AssessmentServices
    {
        private AssessmentRepository assessmentRepository;
        public AssessmentServices()
        {
            assessmentRepository = new AssessmentRepository();
        }


        public bool addAssessment(Assessment assessment)
        {
            if (assessment != null) 
            {
                // Validation: Ensure max marks do not exceed 100
                var currentMarks = assessmentRepository.GetTotalMaximumMarksForModule(assessment.ModuleID);
                if (currentMarks + assessment.MaximumPossibleMark > 100)
                {
                    throw new Exception("Total maximum marks for the module cannot exceed 100.");
                }

                return assessmentRepository.InsertAssessment(assessment);
            }
            else 
            {
                return false;
            }
            
        }

        // Get all the assessments
        public List<Assessment> GetAssessments()
        {
            return assessmentRepository.GetAllAssessments();
        }


        // Get assessment by module codde
        public List<Assessment> FindAssessmentByProgCode(string modCode) 
        {
            return assessmentRepository.GetAssessmentsByModCode(modCode);
        }
    }
}
