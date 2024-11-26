using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class AdminConnect
    {
        public static void initConnection()
        {
            try 
            {
                var conn = new SQLiteConnection(ConnectSettingsDB.ConnectionString());
                conn.Open();
                MessageBox.Show("Successfully Connected", "DB Connection",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        private void formatData()
        {
            
        }
    }
}
