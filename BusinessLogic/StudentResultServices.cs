using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class StudentResultsService
    {
        private readonly string _connectionString;

        public StudentResultsService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<StudentResult> GetStudentResults()
        {
            var results = new List<StudentResult>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                            SELECT 
                                sm.StudentID,
                                s.FirstName,
                                s.LastName,
                                dp.DegreeProgrammeID AS ProgrammeCode,
                                dp.ProgrammeTitle AS ProgrammeName,
                                COUNT(DISTINCT m.ModuleID) AS ModulesAssessedCount,
                                ROUND(AVG(ModulePercentage), 2) AS ProgrammeMark,
                                CASE
                                    WHEN ROUND(AVG(ModulePercentage), 2) >= 70 THEN 'Distinction'
                                    WHEN ROUND(AVG(ModulePercentage), 2) >= 60 THEN 'Merit'
                                    WHEN ROUND(AVG(ModulePercentage), 2) >= 50 THEN 'Pass'
                                    ELSE 'Fail'
                                END AS Grade,
                                CASE
                                    WHEN ROUND(AVG(ModulePercentage), 2) >= 50 THEN 'Pass'
                                    ELSE 'Fail'
                                END AS Result
                            FROM 
                                StudentModules sm
                                INNER JOIN StudentInfo s ON sm.StudentID = s.StudentID
                                INNER JOIN Modules m ON sm.ModuleID = m.ModuleID
                                INNER JOIN DegreeProgrammes dp ON s.DegreeProgrammeID = dp.DegreeProgrammeID
                                LEFT JOIN (
                                    SELECT 
                                        sa.StudentID,
                                        a.ModuleID,
                                        SUM(sa.Mark) * 100.0 / SUM(a.MaximumPossibleMark) AS ModulePercentage
                                    FROM 
                                        StudentAssessments sa
                                        INNER JOIN Assessments a ON sa.AssessmentID = a.AssessmentID
                                    GROUP BY 
                                        sa.StudentID, a.ModuleID
                                ) AS ModuleScores ON sm.StudentID = ModuleScores.StudentID AND sm.ModuleID = ModuleScores.ModuleID
                            WHERE 
                                ModuleScores.ModulePercentage IS NOT NULL
                            GROUP BY 
                                sm.StudentID, s.FirstName, s.LastName, dp.DegreeProgrammeID, dp.ProgrammeTitle
                            HAVING 
                                COUNT(DISTINCT m.ModuleID) > 0;


                            ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new StudentResult
                        {
                            StudentID = reader["StudentID"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            ProgrammeCode = reader["ProgrammeCode"].ToString(),
                            ProgrammeName = reader["ProgrammeName"].ToString(),
                            ModulesAssessedCount = Convert.ToInt32(reader["ModulesAssessedCount"]),
                            ProgrammeMark = Convert.ToDouble(reader["ProgrammeMark"]),
                            Grade = reader["Grade"].ToString(),
                            Result = reader["Result"].ToString()
                        });
                    }
                }
            }

            return results;
        }
    }
}
