using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public class User
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; private set; }
        private string _password;

        public User(string fullname, string email, string password)
        {
            Id = ++_idCounter;
            Fullname = fullname;
            Email = email;

            if (PasswordChecker(password))
            {
                _password = password;
            }
        }
        public bool PasswordChecker(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            if (password.Length < 8)
                return false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                if (hasUpperCase && hasLowerCase && hasDigit)
                    return true;
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}
