using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeFactorials
{
    class SomeFactorials
    {
        static void Main()
        {
            {
                ulong i, number, fact;
                Console.WriteLine("Enter a number to find the factorials");
                number = ulong.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                    
                }
                Console.WriteLine("Factorial of the given number is: {0}", fact);
            }
        }
    }
}
