using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_35_Number_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int r = 0; r < i; r++)
                {
                    Console.Write(num++ + " ");
                    if (num > n)
                    {
                        return;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
