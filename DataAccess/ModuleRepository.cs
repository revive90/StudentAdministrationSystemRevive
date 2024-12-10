using StudentAdministrationSystemRevive.BusinessLogic;
using System.Data.SQLite;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class ModuleRepository
    {

        // Method to insert a module
        public bool InsertModule(Module module)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO Modules (ModuleID, ModuleTitle, ModuleDescription) VALUES (@ModuleID, @ModuleTitle, @ModuleDescription)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ModuleID", module.ModuleID);
                    command.Parameters.AddWithValue("@ModuleTitle", module.ModuleTitle);
                    command.Parameters.AddWithValue("@ModuleDescription", module.ModuleDescription);

                    try
                    {
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Failed to create module, Module code may be in use.","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                        return false;
                    }
                    
                }
            }
        }


        // Method to fetch modules by title
        public List<Module> GetModulesByTitle(string title)
        {
            var modules = new List<Module>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand("SELECT ModuleID, ModuleTitle, ModuleDescription FROM Modules WHERE ModuleTitle LIKE @Title", connection);
                    cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var module = new Module
                            (
                                reader["ModuleID"].ToString(),
                                reader["ModuleTitle"].ToString(),
                                reader["ModuleDescription"].ToString()
                            );
                            modules.Add(module);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return modules;
        }

        // Remove Module
        public bool RemoveModule(string moduleID)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();


                    using (var transaction = connection.BeginTransaction())
                    {
                        // Delete from DegreeProgrammeModules table
                        var cmd1 = new SQLiteCommand("DELETE FROM DegreeProgrammeModules WHERE ModuleID = @ModuleID", connection);
                        cmd1.Parameters.AddWithValue("@ModuleID", moduleID);
                        cmd1.ExecuteNonQuery();

                        // Delete from Modules table
                        var cmd2 = new SQLiteCommand("DELETE FROM Modules WHERE ModuleID = @ModuleID", connection);
                        cmd2.Parameters.AddWithValue("@ModuleID", moduleID);
                        cmd2.ExecuteNonQuery();

                        int rowsAffected = cmd2.ExecuteNonQuery();

                        transaction.Commit();

                        return rowsAffected > 0;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        // Update Module

        public void UpdateModule(string moduleID, string moduleTitle, string moduleDescription)
        {
            string query = "UPDATE Modules SET ModuleTitle = @ModuleTitle, ModuleDescription = @ModuleDescription WHERE ModuleID = @ModuleID";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ModuleID", moduleID);
                    command.Parameters.AddWithValue("@ModuleTitle", moduleTitle);
                    command.Parameters.AddWithValue("@ModuleDescription", moduleDescription);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No changes made or invalid data.");
                    }

                }
            }
        }


        // Get Modules by programme ID
        public List<Module> GetModulesByProgrammeID(string degreeProgrammeID)
        {
            string query = @"
                    SELECT m.ModuleID, m.ModuleTitle, m.ModuleDescription
                    FROM Modules m
                    INNER JOIN DegreeProgrammeModules dpm ON m.ModuleID = dpm.ModuleID
                    WHERE dpm.DegreeProgrammeID = @DegreeProgrammeID";

            List<Module> modules = new List<Module>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DegreeProgrammeID", degreeProgrammeID);

                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modules.Add(new Module
                            (
                                reader["ModuleID"].ToString(),
                                reader["ModuleTitle"].ToString(),
                                reader["ModuleDescription"].ToString()
                            ));
                        }
                    }
                }
            }

            return modules;
        }



    }
}
