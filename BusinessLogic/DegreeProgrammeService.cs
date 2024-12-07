using StudentAdministrationSystemRevive.DataAccess;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class DegreeProgrammeService
    {
        private readonly ProgrammeRepository _repository;
        public DegreeProgrammeService()
        {
            _repository = new ProgrammeRepository();

        }

        // Adding a new programme
        public bool AddProgramme(DegreeProgramme programme)
        {
            if (programme == null)
            {
                MessageBox.Show("Programme is Null", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return _repository.InsertProgramme(programme);
            }


        }

        // Removing a programme
        public bool RemoveProgramme(string degreeProgrammeID)
        {
            return _repository.RemoveProgramme(degreeProgrammeID);
        }

        // Returning a list of programmes.
        public List<DegreeProgramme> GetProgrammeByTitle(string title)
        {
            return _repository.GetProgrammeByTitle(title);
        }

        // Filling the Data Grid view with programme information
        public List<DegreeProgramme> GetDegreeProgrammes()
        {
            return _repository.GetAllDegreeProgrammes();
        }





    }
}
