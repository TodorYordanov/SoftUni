using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHypotenuse
{
    class CalculateHypotenuse
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter first cathet length:");
                double cathetusA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second cathet length:");
                double cathetusB = double.Parse(Console.ReadLine());
                double hypotenuse = Math.Sqrt(cathetusA * cathetusA + cathetusB * cathetusB);
                Console.WriteLine("The hypotenuse of your right angled triangle is: {0: 0.00}", hypotenuse);
            }
        }
    }
}
