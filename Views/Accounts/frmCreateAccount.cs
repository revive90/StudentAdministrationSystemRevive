using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using Module = StudentAdministrationSystemRevive.BusinessLogic.Module;

namespace StudentAdministrationSystemRevive.Views.Accounts
{
    public partial class frmCreateAccount : Form
    {
        private readonly ProgrammeRepository _programmeRepository;
        private readonly StudentRepository _studentRepository;
        private readonly StudentModuleRepository _studentModuleRepository;
        private StudentModuleService _studentModuleService;
        private List<Module> modules; 
        private readonly ModuleService moduleService;
        private readonly UserService _userService;
        private readonly UserRepository _userRepository;


        public frmCreateAccount()
        {
            InitializeComponent();
            _programmeRepository = new ProgrammeRepository();
            _studentRepository = new StudentRepository();
            _studentModuleRepository = new StudentModuleRepository();
            _studentModuleService = new StudentModuleService(_studentModuleRepository);
            moduleService = new ModuleService();
            _userRepository = new UserRepository(); 
            _userService = new UserService(_userRepository);
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

        private void btnShowModules_Click(object sender, EventArgs e)
        {
            // Check if a degree programme is selected
            if (cmbProgrammes.SelectedValue == null)
            {
                MessageBox.Show("Please select a degree programme, start year, and programme length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected degree programme ID
            string selectedProgrammeID = cmbProgrammes.SelectedValue.ToString();

            // Fetch the modules for the selected programme
            modules = moduleService.GetModulesByProgrammeID(selectedProgrammeID);

            // Clear CheckedListBox
            chkListModulesFromProgramme.Items.Clear();

            // Populate the CheckedListBox with modules
            foreach (var module in modules)
            {
                var listItem = new ListViewItem(module.ModuleTitle)
                {
                    Tag = module // Store the Module object in the Tag property
                };
                chkListModulesFromProgramme.Items.Add(listItem);
            }
        }

        // Student Account created
        private void btnCreateStudentAccount_Click(object sender, EventArgs e)
        {
            createUserprofile();
            // Create Student ID
            Random id = new Random();
            int idint = id.Next(100000, 200000);
            string firstpart = cmbStartYear.SelectedItem.ToString();
            string studIDcomplete = firstpart + idint.ToString();

            // Collect Form Data
            string studentID = studIDcomplete;
            string firstname = txtCAFirstname.Text.Trim();
            string lastname = txtCALastName.Text.Trim();
            string email = txtCAEmailAddress.Text.Trim();
            string degreeProgID = cmbProgrammes.SelectedValue.ToString();
            string cohortYear = cmbStartYear.SelectedItem.ToString();
            string enrollmentStatus = "Not Yet Enrolled";
            string durationYears = cmbProgLength.SelectedItem.ToString();

            int degreeLength = 0;
            if (durationYears == "1 Year")
            {
                degreeLength = 1;
            }
            if (durationYears == "2 Years")
            {
                degreeLength = 2;
            }
            if (durationYears == "3 Years")
            {
                degreeLength = 3;
            }

            // Collect selected modules from the CheckedListBox
            var selectedModules = new List<Module>();
            foreach (var item in chkListModulesFromProgramme.CheckedItems)
            {
                if (item is ListViewItem listItem && listItem.Tag is Module module)
                {
                    selectedModules.Add(module);
                }
            }

            // Check if the number of selected modules matches the required count
            int requiredModuleCount = degreeLength * 6; // At 6 modules per year
            if (selectedModules.Count != requiredModuleCount)
            {
                MessageBox.Show($"Please select exactly {requiredModuleCount} modules for a {degreeLength}-year degree.");
                return;
            }

            // Create a new student record
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
            bool moduleEnrollmentSuccess = _studentModuleService.EnrollStudentInModules(studentID, selectedModules);

            if (moduleEnrollmentSuccess)
            {
                MessageBox.Show("Student enrolled and modules assigned successfully.", "Enrollment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error enrolling the student in the modules.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Creating a user for future login purposes
        private void createUserprofile() 
        {
            string email = txtCAEmailAddress.Text.Trim() ;
            string password = txtSetPassword.Text.Trim();
            
            if (String.IsNullOrEmpty(email)  || String.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Email Address and Password cannot be blank","Error creating account");
                return ;
            }
            else
            {
                bool userCreated = _userService.CreateUser(email, password);

                if (userCreated)
                {
                    MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Failed to create user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }
            }

            
        }

    }
}
