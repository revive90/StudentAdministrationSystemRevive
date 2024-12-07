using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;
using System.Data;

namespace StudentAdministrationSystemRevive.Views.Accounts
{
    public partial class frmCreateAccount : Form
    {
        private readonly ProgrammeRepository _programmeRepository;
        private readonly StudentRepository _studentRepository;
        public frmCreateAccount()
        {
            InitializeComponent();
            _programmeRepository = new ProgrammeRepository();
            _studentRepository = new StudentRepository();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.Show();
            this.Close();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            StudentConnect.initConnection();
            fetchProgrammes();
        }

        private void fetchProgrammes()
        {
            DataTable programmes = _programmeRepository.GetProgrammes();

            cmbProgrammes.DataSource = programmes;
            cmbProgrammes.DisplayMember = "ProgrammeTitle";
            cmbProgrammes.ValueMember = "DegreeProgrammeID";
        }

        private void btnCreateStudentAccount_Click(object sender, EventArgs e)
        {
            //Create Student ID
            Random id = new Random();
            int idint = id.Next(100000,200000);

            // Collect Form Data
            string studentID = idint.ToString();
            string firstname = txtCAFirstname.Text;
            string lastname = txtCALastName.Text;
            string email = txtCAEmailAddress.Text;
            string degreeProgID = cmbProgrammes.SelectedValue.ToString();
            string cohortYear = cmbStartYear.SelectedItem.ToString();
            string enrollmentStatus = "Not Yet Enrolled";
            string durationYears = cmbProgLength.SelectedItem.ToString();

            Students newStudent = new Students(studentID, firstname, lastname, email, degreeProgID, cohortYear, enrollmentStatus, durationYears);

            bool success = _studentRepository.InsertStudent(newStudent);
            if (success)
            {
                MessageBox.Show("Your details have been sent, you will be advised of your enrolment status!", "Details sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error sending your details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
