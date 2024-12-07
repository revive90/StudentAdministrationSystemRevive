using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.Views.Administrator.Enrollment
{
    public partial class frmAdminEnrollment : Form
    {
        private bool isUpdating = false;
        private StudentRepository studentRepository;
        public frmAdminEnrollment()
        {
            InitializeComponent();
            studentRepository = new StudentRepository();    
        }

        private void btn_AD_FindUnenrolled_Click(object sender, EventArgs e)
        {
            string enrolmentStatus;

            if (cmbEnrollmentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select 'Enrolled of Not yet enrolled' to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                enrolmentStatus = cmbEnrollmentStatus.SelectedItem.ToString();

                StudentServices studentServices = new StudentServices();
                var students = studentServices.FindStudentsByEnrolmentStatus(enrolmentStatus);
                dg_AD_StudentEnrollment.DataSource = students;

            }
        }

        private void frmAdminEnrollment_Load(object sender, EventArgs e)
        {
            showStudents();
        }

        private void showStudents()
        {
            try
            {
                StudentServices studentServices = new StudentServices();
                var students = studentServices.GetAllStudents();
                dg_AD_StudentEnrollment.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree Cohorts: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            foreach (DataGridViewRow row in dg_AD_StudentEnrollment.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var studentID = row.Cells["StudentID"].Value?.ToString();
                var firstname = row.Cells["Firstname"].Value?.ToString();
                var lastname = row.Cells["Lastname"].Value?.ToString();
                var email = row.Cells["Email"].Value?.ToString();
                var degreeProgrammeID = row.Cells["DegreeProgrammeID"].Value?.ToString();
                var cohortYear = row.Cells["CohortYear"].Value?.ToString();
                var enrolmentStatus = row.Cells["EnrolmentStatus"].Value?.ToString();
                var durationYears = row.Cells["DurationYears"].Value?.ToString();


                if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname)
                    || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(degreeProgrammeID) || string.IsNullOrWhiteSpace(cohortYear)
                    || string.IsNullOrWhiteSpace(enrolmentStatus) || string.IsNullOrWhiteSpace(durationYears))
                {
                    continue;
                }


                studentRepository.UpdateStudentInfo(studentID, firstname, lastname, email, degreeProgrammeID, cohortYear, enrolmentStatus,durationYears);
            }


            isUpdating = false;

            MessageBox.Show("Changes saved successfully.");
        }
    }
}
