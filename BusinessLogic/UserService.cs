using StudentAdministrationSystemRevive.DataAccess;
using System;
using System.Collections.Generic;
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
    }
}
