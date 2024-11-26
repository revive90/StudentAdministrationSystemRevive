using StudentAdministrationSystemRevive.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return (command.ExecuteNonQuery()>0);
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
                            return new DegreeProgramme (
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
    }
}
