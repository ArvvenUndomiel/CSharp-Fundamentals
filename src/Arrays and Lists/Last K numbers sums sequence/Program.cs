using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07_Last_K_numbers_sums_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] result = new long[n];
            result[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int iterations = Math.Min(k, i);

                for (int j = 1; j <= iterations; j++)
                {
                    result[i] += result[i - j];
                }
            }
            Console.WriteLine(string.Join (" ",result));
        }
    }
}
