using System;

namespace MathForDevelopers
{
    class SomePrimes
    {
        static void Main()
        {
                Console.WriteLine("Enter a number to check if it's prime:");
                int prime = int.Parse(Console.ReadLine());
                if (prime <= 1)
                {
                    Console.WriteLine("Your number is NOT prime.");
                }
                else if (prime == 2)
                {
                    Console.WriteLine("Your number is prime.");
                }
                else if (prime % 2 == 0)
                {
                    Console.WriteLine("Your number is NOT prime.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= prime - 1; i++)
                    {
                        if (prime % i == 0)
                        {
                            isPrime = false;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine("Your number is prime.");
                    }
                    else
                    {
                        Console.WriteLine("Your number is NOT prime.");
                    }
                }
            }
        }
    
}
