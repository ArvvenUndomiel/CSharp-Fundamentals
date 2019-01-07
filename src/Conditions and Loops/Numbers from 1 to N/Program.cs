using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_25_Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1 ; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
