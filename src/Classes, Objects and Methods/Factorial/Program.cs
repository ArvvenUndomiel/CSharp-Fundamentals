using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(n);
            Console.WriteLine(factorial);
        }

        static BigInteger CalculateFactorial (int n)
        {
            BigInteger factorial = 1;

            do
            {
                factorial = factorial * n;
                n--;
            }
            while (n > 1);

            return factorial;
        }
    }
}
