using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_31_Even_or_odd_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else oddSum += number;
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\nSum = {evenSum}");
            }
            else
            {
                  Console.WriteLine($"No\nDiff = {Math.Abs(evenSum-oddSum)}");
            }
        }   
    }
}
