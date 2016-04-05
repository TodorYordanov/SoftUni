using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeFibonacciPrimes
{
    class SomeFibonacciPrimes
    {
        static void Main()
        {
            int first = 0;
            int second = 1;
            int third = 1;
            List<int> fibnoList = new List<int>();
            fibnoList.Add(first);
            fibnoList.Add(second);
            fibnoList.Add(third);
            for (int i = 0; i < 50; i++)
            {

                third = second;
                second = first + second;
                first = third;
                Console.WriteLine(first);
                fibnoList.Add(first);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number to find if it's in Fibonacci range:");
                int number = int.Parse(Console.ReadLine());
                if (fibnoList.Contains(number))
                {
                    Console.WriteLine("Your number is within the Fibonacci range.");
                }
                else
                {
                    Console.WriteLine("Your number is NOT within the Fibonacci range");
                }
            }
        }
    }
}
