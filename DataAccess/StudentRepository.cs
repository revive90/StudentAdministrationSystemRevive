using StudentAdministrationSystemRevive.BusinessLogic;
using System.Data.SQLite;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class StudentRepository
    {

        // Insert New Student
        public bool InsertStudent(Students student)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO StudentInfo (StudentID, Firstname, Lastname, Email, DegreeProgrammeID, CohortYear, EnrolmentStatus, DurationYears) " +
                    "VALUES (@StudentID, @Firstname, @Lastname, @Email, @DegreeProgrammeID, @CohortYear, @EnrolmentStatus, @DurationYears)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", student.StudentID);
                    command.Parameters.AddWithValue("@Firstname", student.Firstname);
                    command.Parameters.AddWithValue("@Lastname", student.Lastname);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@DegreeProgrammeID", student.DegreeProgrammeID);
                    command.Parameters.AddWithValue("@CohortYear", student.CohortYear);
                    command.Parameters.AddWithValue("@EnrolmentStatus", student.EnrolmentStatus);
                    command.Parameters.AddWithValue("@DurationYears", student.DurationYears);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        // Fill up data grid View
        public List<Students> GetAllStudents()
        {
            string query = "SELECT * FROM StudentInfo";
            List<Students> students = new List<Students>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Students(
                                reader["StudentID"].ToString(),
                                reader["Firstname"].ToString(),
                                reader["Lastname"].ToString(),
                                reader["Email"].ToString(),
                                reader["DegreeProgrammeID"].ToString(),
                                reader["CohortYear"].ToString(),
                                reader["EnrolmentStatus"].ToString(),
                                reader["DurationYears"].ToString()
                            );
                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }


        // Get Students by enrolment Status
        public List<Students> GetStudentsByEnrolmentStatus(string enrolmentStatus)
        {
            var students = new List<Students>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
                {
                    connection.Open();
                    var cmd = new SQLiteCommand("SELECT *  FROM StudentInfo WHERE EnrolmentStatus LIKE @EnrolmentStatus", connection);
                    cmd.Parameters.AddWithValue("@EnrolmentStatus", enrolmentStatus);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Students
                            (
                                reader["StudentID"].ToString(),
                                reader["Firstname"].ToString(),
                                reader["Lastname"].ToString(),
                                reader["Email"].ToString(),
                                reader["DegreeProgrammeID"].ToString(),
                                reader["CohortYear"].ToString(),
                                reader["EnrolmentStatus"].ToString(),
                                reader["DurationYears"].ToString()
                            );
                            students.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return students;
        }


        // Update Student Info - Enrolment or Non Enrolment
        public void UpdateStudentInfo(string studentID, string firstname, string lastname, 
            string email, string degreeProgrammeID, string cohortYear, string enrolmentStatus, string durationYears)
        {
            string query = "UPDATE StudentInfo SET Firstname = @Firstname, Lastname = @Lastname, Email = @Email," +
                "DegreeProgrammeID = @DegreeProgrammeID, CohortYear = @CohortYear, EnrolmentStatus = @EnrolmentStatus, DurationYears = @DurationYears " +
                "WHERE StudentID = @StudentID";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Firstname", firstname);
                    command.Parameters.AddWithValue("@Lastname", lastname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DegreeProgrammeID", degreeProgrammeID);
                    command.Parameters.AddWithValue("@CohortYear", cohortYear);
                    command.Parameters.AddWithValue("@EnrolmentStatus", enrolmentStatus);
                    command.Parameters.AddWithValue("@DurationYears", durationYears);

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
    }
}
