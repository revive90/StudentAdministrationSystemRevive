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
    public class AssessmentRepository
    {


        // Inserting new Assessment
        public bool InsertAssessment(Assessment assessment)
        {
            string query = @"
            INSERT INTO Assessments (AssessmentID, AssessmentTitle, AssessmentDescription, MaximumPossibleMark, ModuleID) 
            VALUES (@AssessmentID, @AssessmentTitle, @AssessmentDescription, @MaximumPossibleMark, @ModuleID)";

            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AssessmentID", assessment.AssessmentID);
                    command.Parameters.AddWithValue("@AssessmentTitle", assessment.AssessmentTitle);
                    command.Parameters.AddWithValue("@AssessmentDescription", assessment.AssessmentDescription);
                    command.Parameters.AddWithValue("@MaximumPossibleMark", assessment.MaximumPossibleMark);
                    command.Parameters.AddWithValue("@ModuleID", assessment.ModuleID);

                    
                    return (command.ExecuteNonQuery()>0);
                }
            }
            
        }

        // Checking Maximum mark from the existing assessments
        public int GetTotalMaximumMarksForModule(string moduleId)
        {
            int totalMarks = 0;

            string query = @"
                            SELECT SUM(MaximumPossibleMark) 
                            FROM Assessments 
                            WHERE ModuleID = @ModuleID";

            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ModuleID", moduleId);

                connection.Open();
                var result = command.ExecuteScalar();

                // If there are no records, result will be DBNull
                totalMarks = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }

            return totalMarks;
        }


        // Getting all the assessments in the database
        public List<Assessment> GetAllAssessments() 
        {
            string query = "SELECT * FROM Assessments";
            List<Assessment> assessments = new List<Assessment>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maximumPossibleMark = reader["MaximumPossibleMark"] != DBNull.Value? Convert.ToInt32(reader["MaximumPossibleMark"]): 0;
                            var assessment = new Assessment(
                                reader["AssessmentID"].ToString(),
                                reader["AssessmentTitle"].ToString(),
                                reader["AssessmentDescription"].ToString(),
                                maximumPossibleMark,
                                reader["ModuleID"].ToString()
                            );
                            assessments.Add(assessment);
                        }
                    }
                }
            }
            return assessments;
        }


        // Getting assessments By Module Code 
        public List<Assessment> GetAssessmentsByModCode(string modCode)
        {
            var assessments = new List<Assessment>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand("SELECT * FROM Assessments WHERE ModuleID LIKE @ModuleID", connection);
                    cmd.Parameters.AddWithValue("@ModuleID", "%" + modCode + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maximumPossibleMark = reader["MaximumPossibleMark"] != DBNull.Value ? Convert.ToInt32(reader["MaximumPossibleMark"]) : 0;
                            var assessment = new Assessment
                            (
                                reader["AssessmentID"].ToString(),
                                reader["AssessmentTitle"].ToString(),
                                reader["AssessmentDescription"].ToString(),
                                maximumPossibleMark,
                                reader["ModuleID"].ToString()
                            );
                            assessments.Add(assessment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return assessments;
        }


        //Update Assessment Informarion
        public void UpdateAssessmentInfo(string assessmentID, string assessmentTitle, string assessmentDescription, int maximumPossibleMark, string moduleID)
        {
            string query = "UPDATE Assessments SET  AssessmentTitle = @AssessmentTitle, AssessmentDescription = @AssessmentDescription," +
                "MaximumPossibleMark = @MaximumPossibleMark, ModuleID = @ModuleID WHERE AssessmentID = @AssessmentID";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@AssessmentID", assessmentID);
                    command.Parameters.AddWithValue("@AssessmentTitle", assessmentTitle);
                    command.Parameters.AddWithValue("@AssessmentDescription", assessmentDescription);
                    command.Parameters.AddWithValue("@MaximumPossibleMark", maximumPossibleMark);
                    command.Parameters.AddWithValue("@ModuleID", moduleID);

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


        // Getting maximum possible mark for the assessment
        public int GetMaximumPossibleMark(string assessmentID)
        {
            string query = "SELECT MaximumPossibleMark FROM Assessments WHERE AssessmentID = @AssessmentID";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AssessmentID", assessmentID);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int maxMark))
                    {
                        return maxMark;
                    }

                    throw new InvalidOperationException();
                }
            }
        }

    }
}
