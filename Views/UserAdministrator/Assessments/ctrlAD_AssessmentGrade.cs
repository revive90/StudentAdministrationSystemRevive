using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    public partial class ctrlAD_AssessmentGrade : UserControl
    {
        public ctrlAD_AssessmentGrade()
        {
            InitializeComponent();
        }

        private void btnAD_AssessmentSaveChanges_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_AD_AssessmentGrade.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var studentID = row.Cells["StudentID"].Value?.ToString();
                var assessmentID = row.Cells["AssessmentID"].Value?.ToString();
                var markString = row.Cells["Mark"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(markString))
                    continue;

                if (int.TryParse(markString, out int mark))
                {
                    try
                    {
                        StudentAssessmentServices studentAssessmentServices = new StudentAssessmentServices();
                        studentAssessmentServices.GradeAssessment(studentID, assessmentID, mark);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error grading student {studentID}: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid mark for student {studentID}. Please enter a valid number.");
                }
            }

            MessageBox.Show("Grades submitted successfully.");
        }

        private void ctrlAD_AssessmentGrade_Load(object sender, EventArgs e)
        {
            showStudentAssessments();
        }

        private void showStudentAssessments()
        {
            dg_AD_AssessmentGrade.AllowUserToAddRows = true;
            try
            {
                StudentAssessmentServices studentAssessmentServices = new StudentAssessmentServices();
                var assessmentStuds = studentAssessmentServices.GetAllStudentAssessments();
                dg_AD_AssessmentGrade.DataSource = assessmentStuds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student assessments: {ex.Message}");
            }
        }
    }
}
