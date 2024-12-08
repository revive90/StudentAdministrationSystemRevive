using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    public partial class ctrlAD_AssessmentAdd : UserControl
    {
        private readonly AssessmentServices _assessmentServices;
        public ctrlAD_AssessmentAdd()
        {
            InitializeComponent();
            _assessmentServices = new AssessmentServices();
        }

        public bool TopLevel { get; internal set; }

        private void btnAD_AssessmentCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string moduleId = txtAD_Assessment_ModuleCode.Text.Trim();
                string assessmentTitle = txtAD_Assessment_Title.Text.Trim();
                string assessmentDescription = txtAD_Assessment_Description.Text.Trim();
                int maxMarkText = Convert.ToInt32(txtAD_Assessment_MaxMark.Text.Trim());
                string assessmentID = 32.ToString();

                if (string.IsNullOrWhiteSpace(moduleId) ||
                    string.IsNullOrWhiteSpace(assessmentTitle) ||
                    string.IsNullOrWhiteSpace(assessmentDescription))
                {
                    MessageBox.Show("All fields must be filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                Assessment newAssessment = new Assessment(assessmentID,assessmentTitle,assessmentDescription,maxMarkText,moduleId);

                bool success = _assessmentServices.addAssessment(newAssessment);

                MessageBox.Show("Assessment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally clear the input fields
                txtAD_Assessment_ModuleCode.Text = string.Empty;
                txtAD_Assessment_Title.Text = string.Empty;
                txtAD_Assessment_Description.Text = string.Empty;
                txtAD_Assessment_MaxMark.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding assessment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

