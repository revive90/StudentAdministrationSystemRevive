using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAdministrationSystemRevive.BusinessLogic;


namespace StudentAdministrationSystemRevive.DataAccess
{
    public class UserRepository
    {
        public bool InsertUser(User user)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        INSERT INTO Users (UserID, Email, PasswordHash, AccessLevel)
                        VALUES (@UserID, @Email, @PasswordHash, @AccessLevel)";
                    command.Parameters.AddWithValue("@UserID", user.UserID);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@AccessLevel", user.AccessLevel);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        // Getting the user by email
        public User GetUserByEmail(string email)
        {
            using (var connection = new SQLiteConnection(ConnectSettingsDB.ConnectionString()))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Users WHERE Email = @Email";
                    command.Parameters.AddWithValue("@Email", email);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader["UserID"].ToString(),
                                Email = reader["Email"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString(),
                                AccessLevel = reader["AccessLevel"].ToString()
                            };
                        }
                    }
                }
            }

            return null; // User not found
        }

    }
}
