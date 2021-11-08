using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cijferLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a ch");
            int charCode = Console.Read();
            char realChar = Convert.ToChar(charCode);
            int counter = 0;
            if (char.IsLetter(realChar))
            {
                Console.WriteLine("char is letter");
            }
            else if (char.IsDigit(realChar))
            {
                counter++;
                Console.WriteLine();
            }
            Console.WriteLine($"you had this many numbers in the ");
        }
    }
}
