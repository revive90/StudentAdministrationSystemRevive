using StudentAdministrationSystemRevive.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class ctrlAdminAddModules : UserControl
    {
        private readonly ModuleService _moduleService;
   
        public ctrlAdminAddModules()
        {
            InitializeComponent();
            _moduleService = new ModuleService();
        }

        private void btnAMCreateModule_Click(object sender, EventArgs e)
        {
            // Collect form data
            string moduleID = txtAMModCode.Text;
            string moduleTitle = txtAMModuleTitle.Text;
            string moduleDescription = txtAMModuleDescription.Text;
            string degreeProgrammeID = txtAMParentProgCode.Text;
            string isMandatory = cmbAMModuleCoreOptional.Text.ToString();

            // Create the module and degree programme module objects
            Module newModule = new Module(moduleID, moduleTitle, moduleDescription);
            DegreeProgrammeModule degreeProgrammeModule = new DegreeProgrammeModule(degreeProgrammeID, moduleID, isMandatory);

            // Call the service to insert the module and its relationship
            bool success = _moduleService.AddModule(newModule, degreeProgrammeModule);

            if (success)
            {
                MessageBox.Show("Module created and linked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error creating module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
