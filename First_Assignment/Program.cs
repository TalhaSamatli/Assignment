using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kullancı adı ve şifre değeri alıncak bir değişkenin içerisine atanacak 2 değişken burda
            //Ondan sonra aynı kullanıcı adı ve şifre değerlerini birdaha isteyeceğiz 2 değişkende burda
            //Sonra karşılaştırma operatörleriyle kullanıcı adı ve şifreyi karşılaştıracağız ve bunuda yazdıracağız

            // Without using if statement

            Console.WriteLine("Please enter your username: ");
            string username0 = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password0 = Console.ReadLine();

            Console.WriteLine("Please enter your username: ");
            string username1 = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password1 = Console.ReadLine();

            bool result = (username0 == username1);
            Console.WriteLine(result);
            bool result1 = (password0 == password1);
            Console.WriteLine(result);


            // With using if statement
            Console.WriteLine("Please enter your username: ");
            string username2 = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password2 = Console.ReadLine();

            Console.WriteLine("Please enter your username: ");
            string username3 = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password3 = Console.ReadLine();

            if (username2 == username3 && password2 == password3) 
            {
                Console.WriteLine("Username is correct.");
                Console.WriteLine("You're password is correct. Logging in to your account...");

            }
            
        }
    }
}
