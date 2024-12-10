using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.Views.Administrator.Results
{
    public partial class frmAdminResults : Form
    {
        private StudentResultsService _studentResultsService;
        public frmAdminResults()
        {
            InitializeComponent();
            _studentResultsService = new StudentResultsService(ConnectSettingsDB.ConnectionString());
        }

        private void frmAdminResults_Load(object sender, EventArgs e)
        {
            LoadResults();
        }


        // Method to load current results into result datagrid view
        private void LoadResults()
        {
            var results = _studentResultsService.GetStudentResults();
            dg_AD_Student_Results.DataSource = results;

            //Adjusting column headers for better readability
            dg_AD_Student_Results.Columns["StudentID"].HeaderText = "Student ID";
            dg_AD_Student_Results.Columns["FirstName"].HeaderText = "First Name";
            dg_AD_Student_Results.Columns["LastName"].HeaderText = "Last Name";
            dg_AD_Student_Results.Columns["ProgrammeCode"].HeaderText = "Programme Code";
            dg_AD_Student_Results.Columns["ProgrammeName"].HeaderText = "Programme Name";
            dg_AD_Student_Results.Columns["ModulesAssessedCount"].HeaderText = "Modules Assessed";
            dg_AD_Student_Results.Columns["ProgrammeMark"].HeaderText = "Programme Mark (%)";
            dg_AD_Student_Results.Columns["Grade"].HeaderText = "Grade";
            dg_AD_Student_Results.Columns["Result"].HeaderText = "Pass/Fail";
        }
    }
}
