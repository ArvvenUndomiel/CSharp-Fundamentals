using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_26_Numbers_from_2pow0_to_2_pown
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i <= power; i++)
            {
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
