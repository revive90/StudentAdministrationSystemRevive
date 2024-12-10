using StudentAdministrationSystemRevive.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CreateUser(string email, string password)
        {
            User newUser = new User
            {
                UserID = GenerateRandomUserID(),
                Email = email,
                PasswordHash = password, 
                AccessLevel = "Student" 
            };

            return _userRepository.InsertUser(newUser);
        }

        private string GenerateRandomUserID()
        {
            // Generating a random 10-character user ID
            return Guid.NewGuid().ToString("N").Substring(0, 10);
        }

        // Get the user by email
        public bool Login(string email, string password)
        {
            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
            {
                return false; // User not found
            }

            // Compare the provided password with the stored password (no hashing)
            return user.PasswordHash == password;
        }

        // Get student info 
        public (string ProgrammeID, string ProgrammeTitle, int StartYear, string Duration) GetProgrammeDetails(string email)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand(@"
                    SELECT dp.DegreeProgrammeID, dp.ProgrammeTitle, si.CohortYear, dp.DurationYears
                    FROM Users u
                    JOIN StudentInfo si ON u.Email = si.Email
                    JOIN DegreeProgrammes dp ON si.DegreeProgrammeID = dp.DegreeProgrammeID
                    WHERE u.Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                ProgrammeID: reader["DegreeProgrammeID"].ToString(),
                                ProgrammeTitle: reader["ProgrammeTitle"].ToString(),
                                StartYear: Convert.ToInt32(reader["CohortYear"]),
                                Duration: reader["DurationYears"].ToString()
                            );
                        }
                        else
                        {
                            throw new Exception("No programme details found for the given email.");
                        }
                    }
                }
            }
        }



        //Get student Modules
        // Get student ID using email
        public string GetStudentIDByEmail(string email)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand(@"
            SELECT s.StudentID
            FROM Users u
            INNER JOIN StudentInfo s ON u.Email = s.Email
            WHERE u.Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["StudentID"].ToString();
                        }
                        else
                        {
                            throw new Exception("Student ID not found for the given email.");
                        }
                    }
                }
            }
        }


        public List<(string ModuleID, string ModuleTitle)> GetStudentModules(string studentID)
        {
            var modules = new List<(string ModuleID, string ModuleTitle)>();

            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand(@"
                    SELECT m.ModuleID, m.ModuleTitle
                    FROM StudentModules sm
                    JOIN Modules m ON sm.ModuleID = m.ModuleID
                    WHERE sm.StudentID = @StudentID", connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modules.Add((
                                ModuleID: reader["ModuleID"].ToString(),
                                ModuleTitle: reader["ModuleTitle"].ToString()
                            ));
                        }
                    }
                }
            }

            return modules;
        }





    }
}
