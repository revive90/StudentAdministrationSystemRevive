using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.Views.Student;

namespace StudentAdministrationSystemRevive.Views.StudentPages
{
    public partial class frmStudentHome : Form
    {
        private readonly UserService _userService;

        public frmStudentHome(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void frmStudentHome_Load(object sender, EventArgs e)
        {
            LoadHomeData();
        }

        private void btnRefreshHome_Click(object sender, EventArgs e)
        {
            LoadHomeData();
        }

        private void LoadHomeData()
        {
            try
            {
                var userDetails = _userService.GetProgrammeDetails(frmStudentPortal._email);

                lblProgrammeID.Text = userDetails.ProgrammeID;
                lblProgrammeName.Text = userDetails.ProgrammeTitle;
                lblStartYear.Text = userDetails.StartYear.ToString();
                lblDurationYears.Text = userDetails.Duration;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading programme details: {ex.Message}");
            }
        }
    }
}
