using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class DegreeProgramme
    {
        public string DegreeProgrammeID { get; set; } = string.Empty;
        public string ProgrammeTitle { get; set; } = string.Empty;
        public string ProgrammeDescription { get; set; } = string.Empty;
        public string ProgrammeDuration { get; set; } = string.Empty;

        public DegreeProgramme(string programmeID,string programmeTitle,string programmeDescription, string duration) 
        {
            if (string.IsNullOrEmpty(programmeID) || string.IsNullOrEmpty(programmeTitle) || string.IsNullOrEmpty(programmeDescription) || string.IsNullOrEmpty(duration))
            {
                MessageBox.Show("One of more fields are blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DegreeProgrammeID = programmeID;
                ProgrammeTitle = programmeTitle;
                ProgrammeDescription = programmeDescription;
                ProgrammeDuration = duration;
            }
        }
    }
}
