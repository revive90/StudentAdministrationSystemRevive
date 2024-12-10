using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class ModuleService
    {
        private readonly ModuleRepository _moduleRepository;
        private readonly DegreeProgrammeModuleRepository _degreeProgrammeModuleRepository;
        private readonly ModuleRepository _repository;

        public ModuleService()
        {
            _moduleRepository = new ModuleRepository();
            _degreeProgrammeModuleRepository = new DegreeProgrammeModuleRepository(ConnectSettingsDB.ConnectionString());
            _repository = new ModuleRepository();
        }

        public bool AddModule(Module module, DegreeProgrammeModule degreeProgrammeModule)
        {
            // Inserting the module 
            bool isModuleInserted = _moduleRepository.InsertModule(module);
            if (!isModuleInserted)
            {
                MessageBox.Show("Error inserting module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Insert the degree programme module relationship
            bool isDegreeProgrammeModuleInserted = _degreeProgrammeModuleRepository.InsertDegreeProgrammeModule(degreeProgrammeModule);
            if (!isDegreeProgrammeModuleInserted)
            {
                MessageBox.Show("Error linking module to degree programme", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;  // Both insertions succeeded
        }

        public List<Module> FindModulesByTitle(string title)
        {
            return _repository.GetModulesByTitle(title);
        }



        public bool RemoveModule(string moduleID)
        {
            if (string.IsNullOrEmpty(moduleID))
            {
                MessageBox.Show("Module ID is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return _repository.RemoveModule(moduleID);
            }


        }

        // Get module by programme code
        public List<Module> GetModulesByProgrammeID(string degreeProgrammeID)
        {
            if (string.IsNullOrWhiteSpace(degreeProgrammeID))
                throw new ArgumentException("Degree Programme ID cannot be null or empty.");

            return _moduleRepository.GetModulesByProgrammeID(degreeProgrammeID);
        }

    }
}
