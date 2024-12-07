using StudentAdministrationSystemRevive.BusinessLogic;
using System.Data;
using System.Data.SQLite;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class ProgrammeRepository
    {
        string query = "INSERT OR IGNORE INTO DegreeProgrammes(DegreeProgrammeID, ProgrammeTitle, DurationYears, ProgrammeDescription)" +
                    "VALUES (@ProgrammeID, @Title, @DurationYears, @ProgrammeDescription)";
        public bool InsertProgramme(DegreeProgramme programme)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();


                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProgrammeID", programme.DegreeProgrammeID);
                    command.Parameters.AddWithValue("@Title", programme.ProgrammeTitle);
                    command.Parameters.AddWithValue("@DurationYears", programme.ProgrammeDuration);
                    command.Parameters.AddWithValue("@ProgrammeDescription", programme.ProgrammeDescription);

                    //command.ExecuteNonQuery();
                    Console.WriteLine("Executing query for ProgrammeID: " + programme.DegreeProgrammeID);
                    return (command.ExecuteNonQuery() > 0);
                }
            }
        }


        public DegreeProgramme? GetProgrammeByID(string programmeID)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM DegreeProgrammes WHERE DegreeProgrammeID = @ProgrammeID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProgrammeID", programmeID);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DegreeProgramme(
                                reader["ProgrammeID"].ToString(),
                                reader["Title"].ToString(),
                                reader["DurationYears"].ToString(),
                                reader["ProgrammeDescription"].ToString()
                                );
                        }
                        else
                        {
                            return null;
                        }
                    }

                }

            }

        }



        // Get Programme by Title
        public List<DegreeProgramme> GetProgrammeByTitle(string title)
        {
            var programmes = new List<DegreeProgramme>();
            string query = "SELECT DegreeProgrammeID, ProgrammeTitle, DurationYears, ProgrammeDescription FROM DegreeProgrammes WHERE ProgrammeTitle LIKE @Title";

            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var programme = new DegreeProgramme(
                                reader["DegreeProgrammeID"].ToString(),
                                reader["ProgrammeTitle"].ToString(),
                                reader["DurationYears"].ToString(),
                                reader["ProgrammeDescription"].ToString()
                            );
                            programmes.Add(programme);
                        }
                    }
                }
            }
            return programmes;
        }

        // Fill up Data Grid View

        public List<DegreeProgramme> GetAllDegreeProgrammes()
        {
            string query = "SELECT * FROM DegreeProgrammes";
            List<DegreeProgramme> programmes = new List<DegreeProgramme>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var programme = new DegreeProgramme(
                                reader["DegreeProgrammeID"].ToString(),
                                reader["ProgrammeTitle"].ToString(),
                                reader["DurationYears"].ToString(),
                                reader["ProgrammeDescription"].ToString()
                            );
                            programmes.Add(programme);
                        }
                    }
                }
            }

            return programmes;
        }


        // Remove Programme
        public bool RemoveProgramme(string degreeProgrammeID)
        {
            string query = "DELETE FROM DegreeProgrammes WHERE DegreeProgrammeID = @DegreeProgrammeID";
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DegreeProgrammeID", degreeProgrammeID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;  // Returns true if deletion was successful
                }
            }
        }

        //Updating a programme
        public void UpdateDegreeProgramme(string degreeProgrammeID, string programmeTitle, string programmeDescription, string programmeDuration)
        {
            string query = "UPDATE DegreeProgrammes SET ProgrammeTitle = @ProgrammeTitle, ProgrammeDescription = @ProgrammeDescription, DurationYears = @DurationYears WHERE DegreeProgrammeID = @DegreeProgrammeID";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DegreeProgrammeID", degreeProgrammeID);
                    command.Parameters.AddWithValue("@ProgrammeTitle", programmeTitle);
                    command.Parameters.AddWithValue("@ProgrammeDescription", programmeDescription);
                    command.Parameters.AddWithValue("@DurationYears", programmeDuration);

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


        // Fetch all programmes for Student RegistrationWindow
        public DataTable GetProgrammes()
        {
            DataTable programmes = new DataTable();
            string query = "SELECT DegreeProgrammeID, ProgrammeTitle FROM DegreeProgrammes";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    adapter.Fill(programmes);
                }
            }
            return programmes;
        }




    }
}
