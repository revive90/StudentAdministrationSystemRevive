using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;
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
    public partial class ctrlAdminEditModules : UserControl
    {
        private ModuleRepository moduleRepository;
        private bool isUpdating = false;
        public ctrlAdminEditModules()
        {
            InitializeComponent();
            moduleRepository = new ModuleRepository();
        }

        private void btnEPFindProg_Click(object sender, EventArgs e)
        {
            string moduleTitle = txtEMModuleTitle.Text.ToString().Trim();

            ModuleService moduleService = new ModuleService();

            var modules = moduleService.FindModulesByTitle(moduleTitle);

            dgEMEditModuleTable.DataSource = modules;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            foreach (DataGridViewRow row in dgEMEditModuleTable.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var moduleID = row.Cells["ModuleID"].Value?.ToString();
                var moduleTitle = row.Cells["ModuleTitle"].Value?.ToString();
                var moduleDescription = row.Cells["ModuleDescription"].Value?.ToString();


                if (string.IsNullOrWhiteSpace(moduleID) || string.IsNullOrWhiteSpace(moduleTitle) || string.IsNullOrWhiteSpace(moduleDescription))
                {
                    continue;
                }


                moduleRepository.UpdateModule(moduleID, moduleTitle, moduleDescription);
            }


            isUpdating = false;

            MessageBox.Show("Changes saved successfully.");
        }
    }
}
