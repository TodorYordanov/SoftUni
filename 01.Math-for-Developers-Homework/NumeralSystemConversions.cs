using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralSystemConversions
{
    class NumeralSystemConversions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number to convert it in binary and hexadecimal system:");
            int decNumber = int.Parse(Console.ReadLine());
            string hexValue = decNumber.ToString("X");
            Console.WriteLine("Your number in hecadecimal system is: {0}", hexValue);
            string binValue = Convert.ToString(decNumber, 2);
            Console.WriteLine("Your number in binary system is: {0}", binValue);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("Enter a binary number to convert it in decimal and hexadecimal system:");
            string binNumber = Console.ReadLine();
            int decValue = Convert.ToInt32(binNumber, 2);
            Console.WriteLine("Your number in decimal system is: {0}", decValue);
            string decToHex = decValue.ToString("X");
            Console.WriteLine("Your number in hexadecimal system is: {0}", decToHex);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("Enter a hexadecimal number to convert it in decimal and binary system:");
            string hexNumber = Console.ReadLine();
            int hexToDec = Convert.ToInt32(hexNumber, 16);
            Console.WriteLine("Your number is decimal system is: {0}", hexToDec);
            string hexToBin = Convert.ToString(hexToDec, 2);
            Console.WriteLine("Your number in binary system is: {0}", hexToBin);
        }
    }
}
