﻿namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class Module
    {
        public string ModuleID { get; set; }
        public string ModuleTitle { get; set; }
        public string ModuleDescription { get; set; }

        // Module Constructor
        public Module(string moduleID, string moduleTitle, string moduleDescription)
        {
            ModuleID = moduleID;
            ModuleTitle = moduleTitle;
            ModuleDescription = moduleDescription;
        }
    }


}
