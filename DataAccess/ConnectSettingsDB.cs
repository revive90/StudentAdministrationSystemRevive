using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace StudentAdministrationSystemRevive.DataAccess
{
    public class ConnectSettingsDB
    {
        


        public static string ConnectionString()
        {
            string ConnString = "Data Source=StudentAdminDb.db";

            return ConnString;
        }
    }
}
