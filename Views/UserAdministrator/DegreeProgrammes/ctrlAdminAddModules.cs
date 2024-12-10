using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class ctrlAdminAddModules : UserControl
    {
        private readonly ModuleService _moduleService;

        public ctrlAdminAddModules()
        {
            InitializeComponent();
            _moduleService = new ModuleService();
        }

        private void btnAMCreateModule_Click(object sender, EventArgs e)
        {
            // Collect form data
            string moduleID = txtAMModCode.Text;
            string moduleTitle = txtAMModuleTitle.Text;
            string moduleDescription = txtAMModuleDescription.Text;
            string degreeProgrammeID = txtAMParentProgCode.Text;
            string isMandatory = cmbAMModuleCoreOptional.Text.ToString();

            // Create the module and degree programme module objects
            Module newModule = new Module(moduleID, moduleTitle, moduleDescription);
            DegreeProgrammeModule degreeProgrammeModule = new DegreeProgrammeModule(degreeProgrammeID, moduleID, isMandatory);

            // Call the service to insert the module and its relationship
            bool success = _moduleService.AddModule(newModule, degreeProgrammeModule);

            if (success)
            {
                MessageBox.Show("Module created and linked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error creating module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateModuleCode_Click(object sender, EventArgs e)
        {
            String ModCode = RandomString(5);
            txtAMModCode.Text = ModCode;
        }


        //Random 5 Digits
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
