using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 1000 prime numbers:");

            int num = 2;
            int i = 0;
            while (i < 1000)
            {
                if (isPrime(num) == true)
                {
                    Console.WriteLine(num);
                    i++;
                }

                num++;
            }
        }

        public static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}    