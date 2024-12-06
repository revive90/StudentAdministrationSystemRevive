using StudentAdministrationSystemRevive.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class CohortRepository
    {
        string query = "INSERT OR IGNORE INTO Cohorts (CohortID, DegreeProgrammeID, CohortYear)" +
                    "VALUES (@CohortID, @DegreeProgrammeID, @CohortYear)";
        public bool InsertCohort(Cohort cohort)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();


                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CohortID", cohort.CohortID);
                    command.Parameters.AddWithValue("@DegreeProgrammeID", cohort.CohortProgrammeCode);
                    command.Parameters.AddWithValue("@CohortYear", cohort.CohortStartYear);

                    //command.ExecuteNonQuery();
                    Console.WriteLine("Executing query for ProgrammeID: " + cohort.CohortProgrammeCode);
                    return (command.ExecuteNonQuery() > 0);
                }
            }
        }

        // Fill up Data Grid View
        public List<Cohort> GetAllCohorts()
        {
            string query = "SELECT * FROM Cohorts";
            List<Cohort> cohorts = new List<Cohort>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cohort = new Cohort(
                                reader["CohortID"].ToString(),
                                reader["DegreeProgrammeID"].ToString(),
                                reader["CohortYear"].ToString()
                            );
                            cohorts.Add(cohort);
                        }
                    }
                }
            }

            return cohorts;
        }

        // Get Cohorts by ProgrammeCode
        public List<Cohort> GetCohortsByProgCode(string progCode)
        {
            var cohorts = new List<Cohort>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand("SELECT CohortID, DegreeProgrammeID, CohortYear FROM Cohorts WHERE DegreeProgrammeID LIKE @ProgCode", connection);
                    cmd.Parameters.AddWithValue("@ProgCode", "%" + progCode + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cohort = new Cohort
                            (
                                reader["CohortID"].ToString(),
                                reader["DegreeProgrammeID"].ToString(),
                                reader["CohortYear"].ToString()
                            );
                            cohorts.Add(cohort);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cohorts;
        }

    }
}
