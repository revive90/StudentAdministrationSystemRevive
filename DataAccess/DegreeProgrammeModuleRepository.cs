using StudentAdministrationSystemRevive.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class DegreeProgrammeModuleRepository
    {
        private readonly string _connectionString;

        public DegreeProgrammeModuleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public bool InsertDegreeProgrammeModule(DegreeProgrammeModule degreeProgrammeModule)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO DegreeProgrammeModules (DegreeProgrammeID, ModuleID, IsMandatory) VALUES (@DegreeProgrammeID, @ModuleID, @IsMandatory)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DegreeProgrammeID", degreeProgrammeModule.DegreeProgrammeID);
                    command.Parameters.AddWithValue("@ModuleID", degreeProgrammeModule.ModuleID);
                    command.Parameters.AddWithValue("@IsMandatory", degreeProgrammeModule.IsMandatory);

                    return command.ExecuteNonQuery() > 0;
                }
            } 
        }
    }
}
