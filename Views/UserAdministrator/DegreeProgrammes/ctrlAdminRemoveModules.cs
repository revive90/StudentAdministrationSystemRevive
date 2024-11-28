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
    public partial class ctrlAdminRemoveModules : UserControl
    {
        private readonly ModuleService _moduleService;
        public ctrlAdminRemoveModules()
        {
            InitializeComponent();
            _moduleService = new ModuleService();
        }

        private void btnRMRemoveModule_Click(object sender, EventArgs e)
        {
            // Get the module code entered in the confirmation textbox
            string moduleCode = txtRMModuleCode.Text.Trim();

            // Validate the input
            if (string.IsNullOrWhiteSpace(moduleCode))
            {
                MessageBox.Show("Please enter the module code to confirm removal.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to remove the module
            try
            {
                bool success = _moduleService.RemoveModule(moduleCode); // Call the service to remove the module

                if (success)
                {
                    MessageBox.Show("Module removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form or refresh the DataGridView if needed
                    txtRMModuleCode.Clear();
                    dgRMRemoveModuleTable.DataSource = null; // Clear DataGridView
                }
                else
                {
                    MessageBox.Show("Module removal failed. Please check the module code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the module: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnRMFindModule_Click(object sender, EventArgs e)
        {
            string title = txtRMModuleTitle.Text;

            // Fetch matching modules
            var modules = _moduleService.FindModulesByTitle(title);

            // Display in the DataGridView
            dgRMRemoveModuleTable.DataSource = modules;
        }
    }
}
