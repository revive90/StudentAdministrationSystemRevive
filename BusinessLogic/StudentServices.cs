using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentServices
    {
        private readonly StudentRepository _studentRepository;
        public StudentServices()
        {
            _studentRepository = new StudentRepository();
        }



        public bool AddStudent(Students student)
        {
            // Inserting the Student
            bool isStudentInserted = _studentRepository.InsertStudent(student);
            if (!isStudentInserted)
            {
                MessageBox.Show("Error inserting student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }


        // Return all students
        public List<Students> GetAllStudents() 
        {
            return _studentRepository.GetAllStudents();
        }

        // Return Students by Enrollment Status
        public List<Students> FindStudentsByEnrolmentStatus(string enrolmentStatus)
        {
            return _studentRepository.GetStudentsByEnrolmentStatus(enrolmentStatus);
        }

        // Return Students by Student Name
        public List<Students> FindStudentsByStudentName(string name)
        {
            return _studentRepository.GetStudentsByStudentName(name);
        }

        // Return Students by Student ID
        public List<Students> FindStudentsByStudentID(string ID)
        {
            return _studentRepository.GetStudentsByStudentID(ID);
        }
    }
}
