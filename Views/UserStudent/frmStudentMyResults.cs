using StudentAdministrationSystemRevive.Views.Student.MyResults;

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
