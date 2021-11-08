using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showonlynumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input string with number and/or spesial ch ,and show only letters");
            string word = Console.ReadLine();
            LoopMet(word);
        }

        static void LoopMet(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char newchar = Convert.ToChar(word[i]);
                if (char.IsUpper(newchar))
                {
                    counter++;
                    Console.Write(newchar);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"you had this many high charicters in the string {counter}");
        }
    }
}
