using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class StudentModuleRepository
    {



        // Insert a studentmodule relationship
        public bool InsertStudentModule(string studentID, string moduleID)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO studentModules (StudentID, ModuleID) VALUES (@StudentID, @ModuleID)";
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@ModuleID", moduleID);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if insertion was successful
                }
            }
        }

        // Getting modules for a specific student
        public List<string> GetModulesByStudentID(string studentID)
        {
            string query = "SELECT ModuleID FROM StudentModules WHERE StudentID = @StudentID";
            var moduleIDs = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            moduleIDs.Add(reader["ModuleID"].ToString());
                        }
                    }
                }
            }
            return moduleIDs;
        }
    }
}
