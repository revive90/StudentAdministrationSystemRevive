using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class User
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string AccessLevel { get; set; }
    }
}
