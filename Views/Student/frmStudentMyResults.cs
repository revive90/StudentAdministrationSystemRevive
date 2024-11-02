using StudentAdministrationSystemRevive.Views.Student.MyResults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.Student
{
    public partial class frmStudentMyResults : Form
    {
        public frmStudentMyResults()
        {
            InitializeComponent();
        }

        private void btnRefreshMyResults_Click(object sender, EventArgs e)
        {
            ctrlModuleResult ctrlModuleResult = new ctrlModuleResult();
            flowMyResults.Controls.Add(ctrlModuleResult);
        }
    }
}
