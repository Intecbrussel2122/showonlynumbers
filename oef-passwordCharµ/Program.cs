using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_passwordCharµ
{
    class Program
    {
        static int counter = 0;
        static bool upper = false;
        static bool digit = false;
        static bool lower = false;
        static int length = 15;
        static void Main(string[] args)
        {
            Console.WriteLine("give a password");
            Console.WriteLine($"the password needs to have at least {length} chars");
            string password = Console.ReadLine();

            CheckPassword(password, length);
            if (counter < length)
            {
                Console.WriteLine("the password needs to be longer");
            }
            else if (!upper)
            {
                Console.WriteLine("there needs to be 1 capital letter in your password");
            }
            else if (!digit)
            {
                Console.WriteLine("there needs to be 1 number in your password");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("this is a valid password");
                Console.WriteLine($"your new pasword is {password}");
            }
        }

        private static void CheckPassword(string password, int length)
        {
            for (int i = 0; i < password.Length; i++)
            {
                counter++;
                char newchar = Convert.ToChar(password[i]);
                if (char.IsUpper(newchar) || char.IsDigit(newchar) || char.IsLower(newchar))
                {
                    //upper = true;
                    upper = upper || char.IsUpper(newchar);
                    digit = digit || char.IsDigit(newchar);
                    lower = lower || char.IsLower(newchar);
                }
                //if (char.IsDigit(newchar))
                //{
                //    digit = true;
                //}
            }
        }
    }
}
