using StudentAdministrationSystemRevive.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentModuleService
    {
        private readonly StudentModuleRepository studentModuleRepository;

        public StudentModuleService(StudentModuleRepository repository)
        {
            studentModuleRepository = repository;
        }

        public void EnrollStudentInModule(string studentID, string moduleID)
        {
            studentModuleRepository.InsertStudentModule(studentID, moduleID);
        }

        public bool EnrollStudentInModules(string studentID, List<Module> selectedModules)
        {
            foreach (var module in selectedModules)
            {
                bool success = studentModuleRepository.InsertStudentModule(studentID, module.ModuleID);
                if (!success)
                {
                    return false; // Return false if any insert fails
                }
            }
            return true; // Return true if all inserts succeed
        }

        public List<string> GetStudentModules(string studentID)
        {
            return studentModuleRepository.GetModulesByStudentID(studentID);
        }
    }
}
