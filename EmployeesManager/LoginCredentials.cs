using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManager
{
    public static class LoginCredentials
    {
        private static string correctUsername = "asd";
        private static string correctPassword = "asd";

        public static bool CheckLogin(string username, string password)
        {
            return correctUsername == username && correctPassword == password;
        }
    }
}
