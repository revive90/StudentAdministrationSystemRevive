using System.Data.SQLite;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class StudentConnect
    {
        public static void initConnection()
        {
            try
            {
                var conn = new SQLiteConnection(ConnectSettingsDB.ConnectionString());
                conn.Open();
                MessageBox.Show("Successfully Connected", "DB Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}
