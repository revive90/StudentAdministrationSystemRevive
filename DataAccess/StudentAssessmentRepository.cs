using StudentAdministrationSystemRevive.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class StudentAssessmentRepository
    {

        // Insert Or Update Grade
        public bool InsertOrUpdateGrade(string studentID, string assessmentID, int mark)
        {
            string query = @"
                            INSERT INTO StudentAssessments (StudentID, AssessmentID, Mark)
                            VALUES (@StudentID, @AssessmentID, @Mark)
                            ON CONFLICT(StudentID, AssessmentID)
                            DO UPDATE SET Mark = @Mark";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@AssessmentID", assessmentID);
                    command.Parameters.AddWithValue("@Mark", mark);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Returns the number of rows affected

                    return rowsAffected > 0; // Return true if at least one row was affected
                }
            }
        }


        //
        public List<StudentAssessment> GetAllStudentAssessments()
        {
            string query = "SELECT * FROM StudentAssessments";
            List<StudentAssessment> studentsAssessments = new List<StudentAssessment>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int mark = reader["Mark"] != DBNull.Value ? Convert.ToInt32(reader["Mark"]) : 0;
                            var studentsAssessment = new StudentAssessment(
                                reader["StudentID"].ToString(),
                                reader["AssessmentID"].ToString(),
                                mark
                            );
                            studentsAssessments.Add(studentsAssessment);
                        }
                    }
                }
            }

            return studentsAssessments;
        }
    }
}
