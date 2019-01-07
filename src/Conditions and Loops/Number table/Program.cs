using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_33_Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int r = 1; r <= n; r++)
                {
                    var num = i + r;

                    if (num > n)
                        num = 2 * n - num;
                    Console.Write(num + " ");
                }

                Console.WriteLine();

            }
        }
    }
}