using StudentAdministrationSystemRevive.BusinessLogic;
using StudentAdministrationSystemRevive.DataAccess;
using StudentAdministrationSystemRevive.Views.Student;
using StudentAdministrationSystemRevive.Views.Student.Assessments;
using StudentAdministrationSystemRevive.Views.Student.Modules_Preview;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentAdministrationSystemRevive.Views.StudentPages
{
    public partial class frmStudentModules : Form
    {
        
        private readonly UserService _userService;
        public static string _email;
        public frmStudentModules(string studentID, UserService userService)
        {
            InitializeComponent();
            _userService = new UserService(new UserRepository());
        }

        private void frmStudentModules_Load(object sender, EventArgs e)
        {
            
            LoadStudentModules(GlobalUserInfo.StudentID);
        }

        private void LoadStudentModules(string studentID)
        {
            var modules = _userService.GetStudentModules(studentID);

            foreach (var module in modules)
            {
                ctrlModulePreview modulePreview = new ctrlModulePreview();
                flModules.Controls.Add(modulePreview);
                modulePreview.ModText = module.ModuleTitle;
                modulePreview.ModTitle = module.ModuleID;

            }

            if (modules.Count == 0)
            {
                MessageBox.Show("No modules found for this student.");
            }
        }

        private void btnMyModulesRefresh_Click(object sender, EventArgs e)
        {
            flModules.Controls.Clear();
            LoadStudentModules(GlobalUserInfo.StudentID);
        }
    }
}
