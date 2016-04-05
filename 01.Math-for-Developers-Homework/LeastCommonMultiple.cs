using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    class LeastCommonMultiple
    {
        static void Main()
        {
            int num1, num2, x, y, lcm;
            Console.Write("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine()); // въвеждаме 4
            Console.Write("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine()); // въвеждаме 12
            x = num1; // x = 4
            y = num2; // y = 12
            while (num1 != num2)
            {
                if (num1 > num2) // 4 > 12
                {
                    num1 = num1 - num2; // кода прескача 
                }
                else
                {
                    num2 = num2 - num1; // 12 = 12 - 4 и 12 вече става 8
                }
            }
            lcm = (x * y) / num1; // Първо мислех, че тук y вече е равно на 8 и (4*8) / 4, но тъй като y е извън циклите всъщност си е 12 или (4*12)/12 = 12. Тогава защо са нужни проверките до момента?!
            Console.Write("Least Common Multiple is : " + lcm);
            Console.Read();
        }
    }
}
