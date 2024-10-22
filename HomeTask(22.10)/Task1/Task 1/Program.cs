using System.Security.Cryptography.X509Certificates;
using Task1.Interfaces;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Xaqan","xaqan2005","xaqaN1");
            user.ShowInfo();
        }

    }
}