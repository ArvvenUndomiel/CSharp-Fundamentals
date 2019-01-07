using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(n);
            int count = CountZeroes(factorial);
            Console.WriteLine(count);
        }

        static BigInteger CalculateFactorial(int n)
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

        static int CountZeroes (BigInteger factorial)
        {
            int count = 0;

            while (factorial % 10 == 0)
            {
                factorial /= 10;
                count++;
            }

            return count;
        }
    }
}
        
    

