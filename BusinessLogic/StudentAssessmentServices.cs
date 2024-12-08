using StudentAdministrationSystemRevive.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentAssessmentServices
    {
        private readonly StudentAssessmentRepository studentAssessmentRepository;
        public StudentAssessmentServices()
        {
            studentAssessmentRepository = new StudentAssessmentRepository();
        }

        public void GradeAssessment(string studentID, string assessmentID, int mark)
        {
            if (mark < 0 || mark > 100) 
                throw new ArgumentException("Mark must be between 0 and the maximum possible mark.");

            studentAssessmentRepository.InsertOrUpdateGrade(studentID, assessmentID, mark);
        }


        // Get all in student Assessments
        public List<StudentAssessment> GetAllStudentAssessments() 
        {
            return studentAssessmentRepository.GetAllStudentAssessments();
        }
    }
}
