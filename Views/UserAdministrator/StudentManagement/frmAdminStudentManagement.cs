using StudentAdministrationSystemRevive.BusinessLogic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.Views.Administrator.StudentManagement
{
    public partial class frmAdminStudentManagement : Form
    {
        private bool isUpdating = false;
        private StudentRepository studentRepository;
        public frmAdminStudentManagement()
        {
            InitializeComponent();
            studentRepository = new StudentRepository();
        }

        private void frmAdminStudentManagement_Load(object sender, EventArgs e)
        {
            showStudents();
        }

        private void showStudents()
        {
            try
            {
                StudentServices studentServices = new StudentServices();
                var students = studentServices.GetAllStudents();
                dgVPProgTable.DataSource = students;
                dgVPProgTable.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading degree Cohorts: {ex.Message}");
            }
        }

        private void btnReloadStudentInfo_Click(object sender, EventArgs e)
        {
            showStudents();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            string studentCategory;
            string studentSearchText = txtStudentInfo.Text;

            if (cmbSearchByItem.SelectedIndex == -1 || string.IsNullOrEmpty(txtStudentInfo.Text) || string.IsNullOrWhiteSpace(txtStudentInfo.Text))
            {
                MessageBox.Show("Search category and search phrase are blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                studentCategory = cmbSearchByItem.SelectedItem.ToString();

                if (studentCategory == "Student Name")
                {
                    StudentServices studentServices = new StudentServices();
                    var students = studentServices.FindStudentsByStudentName(studentSearchText);
                    dgVPProgTable.DataSource = students;
                }
                if (studentCategory == "Student Number")
                {
                    StudentServices studentServices = new StudentServices();
                    var students = studentServices.FindStudentsByStudentID(studentSearchText);
                    dgVPProgTable.DataSource = students;
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            foreach (DataGridViewRow row in dgVPProgTable.Rows)
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


                studentRepository.UpdateStudentInfo(studentID, firstname, lastname, email, degreeProgrammeID, cohortYear, enrolmentStatus, durationYears);
            }


            isUpdating = false;

            MessageBox.Show("Changes saved successfully.");
        }
    }
}

