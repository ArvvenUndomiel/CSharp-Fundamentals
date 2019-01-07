using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_28_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var number = 1;

            do
            {
                number = number*n;
                n--;
            }
            while (n > 1);

            Console.WriteLine(number);
      
        }
    }
}
