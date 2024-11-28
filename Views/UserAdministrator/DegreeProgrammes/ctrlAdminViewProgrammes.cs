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
    public partial class ctrlAdminViewProgrammes : UserControl
    {
        //private DegreeProgrammeService services = new DegreeProgrammeService();

        public ctrlAdminViewProgrammes()
        {
            InitializeComponent();
        }

        private void ctrlAdminViewProgrammes_Load(object sender, EventArgs e)
        {
            try
            {
                DegreeProgrammeService degreeProgrammeService = new DegreeProgrammeService();

                var programmes = degreeProgrammeService.GetDegreeProgrammes();

                dgVPProgTable.DataSource = programmes;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree programs: {ex.Message}");
            }

            
        }
    }
}
