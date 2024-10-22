using System.Security.Cryptography.X509Certificates;
using Task1.Interfaces;

namespace Task1
{
    internal class Program
    {
        static User user = null; // User dəyişəni
        static void Main(string[] args)
        {
            string choice;
            bool condition = false;
            do
            {
                Console.WriteLine("\n1. Yeni user yarat");
                Console.WriteLine("2. User Info");
                Console.WriteLine("3. Close");
                Console.Write("Zehmet olmasa secim edin: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateUser();
                        break;
                    case "2":
                        ShowUserInfo();
                        break;
                    case "3":
                        Console.WriteLine("Proqramdan cixis edilir...");
                        condition = true;
                        break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        break;
                }
            } while (!condition);
        }

        static void CreateUser()
        {
            Console.Write("Fullname daxil edin: ");
            string fullname = Console.ReadLine();

            Console.Write("Email daxil edin: ");
            string email = Console.ReadLine();

            string password;

            Console.Write("Password daxil edin: ");
            bool condition1 = false;
            do
            {
                password = Console.ReadLine();

                if (user.PasswordChecker(password))
                {
                    user = new User(fullname, email, password);
                    Console.WriteLine("User yaradildi");
                    condition1 = true;
                }
                else
                {
                    Console.WriteLine("Sifre telebleri odenmir.Yeniden cehd edin.(min 8 character,min 1 reqem,1 boyuk herf,1 kicik herf.");
                }
            } while (!condition1);
        }

        static void ShowUserInfo()
        {
            if (user == null)
            {
                Console.WriteLine("Zehmet olmasa user yaradin.");
            }
            else
            {
                user.ShowInfo();
            }
        }
    }

}
