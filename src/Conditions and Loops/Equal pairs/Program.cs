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
            var n = int.Parse(Console.ReadLine());
            var previousSum = 0;
            var maxDiff = 0;
            var isdifferent = false;

            for (int i = 0; i < n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var currentSum = num1 + num2;

                if (i == 0)
                {
                    previousSum = currentSum;
                }
                else
                {

                    var difference = Math.Abs(previousSum - currentSum);
                    if (difference != 0)
                    {
                        if (difference > maxDiff) maxDiff = difference;
                        isdifferent = true;
                        previousSum = currentSum;
                    }
                }
            }

            if (isdifferent == false)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
