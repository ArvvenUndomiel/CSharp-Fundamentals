using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23_Left_and_Right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
               
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            if (Math.Abs(leftSum - rightSum) == 0)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }

            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
