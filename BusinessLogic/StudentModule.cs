using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentModule
    {
        public string StudentID { get; set; }
        public string ModuleID { get; set; }

        public StudentModule(string studentID, string moduleID)
        {
            StudentID = studentID;
            ModuleID = moduleID;
        }
    }
}
