﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class DegreeProgrammeModule
    {
        public string DegreeProgrammeID { get; set; }
        public string ModuleID { get; set; }
        public string IsMandatory { get; set; }

        // DegreeProgrammeModule Constructor
        public DegreeProgrammeModule(string degreeProgrammeID, string moduleID, string isMandatory)
        {
            DegreeProgrammeID = degreeProgrammeID;
            ModuleID = moduleID;
            IsMandatory = isMandatory;
        }
    }
}