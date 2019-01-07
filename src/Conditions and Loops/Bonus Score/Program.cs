using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (number < 100)
            {
                bonus = 5;
            }
            else if (number >= 100 && number < 1000)
            {
                bonus = 20*number/100;
            }
            else if (number >= 1000)
            {
                bonus = 10*number/100;
            }

            if(number % 2 == 0)
            {
                bonus = bonus + 1;
            }
            if (number %5 == 0 && number % 10 !=0)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
