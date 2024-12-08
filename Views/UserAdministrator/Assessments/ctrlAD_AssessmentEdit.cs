using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    public partial class ctrlAD_AssessmentEdit : UserControl
    {
        private bool isUpdating = false;
        private AssessmentRepository assessmentsRepository;

        public ctrlAD_AssessmentEdit()
        {
            InitializeComponent();
            assessmentsRepository = new AssessmentRepository();
        }
        private void ctrlAD_AssessmentEdit_Load(object sender, EventArgs e)
        {
            showAssessments();
        }

        private void showAssessments()
        {
            try
            {
                AssessmentServices assessmentServices = new AssessmentServices();
                var assessments = assessmentServices.GetAssessments();
                dg_AD_AssessmentEdit.DataSource = assessments;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Assessments: {ex.Message}");
            }
        }

        private void btnAD_AssessmentFind_Click(object sender, EventArgs e)
        {
            string modCode = txtAD_Assessment_Search_ModuleCode.Text;

            AssessmentServices assessmentServices = new AssessmentServices();
            var assessments = assessmentServices.FindAssessmentByProgCode(modCode);

            dg_AD_AssessmentEdit.DataSource = assessments;
        }

        private void btnAD_AssessmentSaveChanges_Click(object sender, EventArgs e)
        {
            isUpdating = true;

            foreach (DataGridViewRow row in dg_AD_AssessmentEdit.Rows)
            {
                if (row.IsNewRow)
                    continue;

                var assessmentID = row.Cells["AssessmentID"].Value?.ToString();
                var assessmentTitle = row.Cells["AssessmentTitle"].Value?.ToString();
                var assessmentDescription = row.Cells["AssessmentDescription"].Value?.ToString();
                var maximumPossibleMarkString = row.Cells["MaximumPossibleMark"].Value?.ToString();
                var moduleID = row.Cells["ModuleID"].Value?.ToString();


                if (string.IsNullOrWhiteSpace(assessmentID) || string.IsNullOrWhiteSpace(assessmentTitle) || string.IsNullOrWhiteSpace(assessmentDescription)
                    || string.IsNullOrWhiteSpace(moduleID))
                {
                    continue;
                }


                if (int.TryParse(maximumPossibleMarkString, out int maximumPossibleMark))
                {
                    assessmentsRepository.UpdateAssessmentInfo(assessmentID, assessmentTitle, assessmentDescription, maximumPossibleMark, moduleID);
                }
                else
                {
                    MessageBox.Show($"Invalid input for Maximum Possible Mark at row {row.Index}. Please enter a valid number.");
                }
            }


            isUpdating = false;

            MessageBox.Show("Changes saved successfully.");
        }

        private void btnShowAllAssessments_Click(object sender, EventArgs e)
        {
            showAssessments();
        }
    }
}
