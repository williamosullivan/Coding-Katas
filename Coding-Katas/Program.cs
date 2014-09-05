using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
            Welcome("Jane Austen", true, false);
            Welcome("George Orwell", false, false);
            Welcome("Isaac Newton", false, true);
            
        }

        private static void Welcome(string name, bool isWoman, bool isSir)
        {
            string lastName = name.Split(' ').Last();
            if ( isWoman == true)
            {
                Console.WriteLine("Welcome Ms. " + lastName);
            }
            if ( isSir == true )
            {
                Console.WriteLine("Welcome Sir " + lastName);
            }
            if ( isSir == false && isWoman == false)
            {
                Console.WriteLine("Welcome Mr. " + lastName);
            }
            Console.ReadLine();
        }

        private static void FizzBuzz()
        {
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                        Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
