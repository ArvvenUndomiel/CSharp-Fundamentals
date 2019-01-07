using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double total = 0;

            if (type == "Premiere")
            {
                total = 12 * r * c;
                Console.WriteLine($"{total:f2}");
            }
            else if (type == "Normal")
            {
                total = 7.50 * r * c;
                Console.WriteLine($"{total:f2}");
            }
            else if (type == "Discount")
            {
                total = 5 * r * c;
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}
