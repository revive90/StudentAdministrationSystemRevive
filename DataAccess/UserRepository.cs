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

    }
}
