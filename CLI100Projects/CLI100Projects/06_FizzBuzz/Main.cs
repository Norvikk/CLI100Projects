using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal static class FizzBuzz
    {
        public static void FizzTheBuzz()
        {
            // Write a program that prints the numbers from 1 to 100
            // and for multiples of ‘3’ print “Fizz”
            // instead of the number and for the multiples of ‘5’ print “Buzz”.

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
