using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(n);

            if (isPrime)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static bool IsPrime(long n)
        {
            bool prime = true;

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (n < 2)
            {
                prime = false;
            }

            return prime;
        }
    }
}
