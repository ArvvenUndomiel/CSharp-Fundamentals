using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01___Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int number = int.Parse(Console.ReadLine());

            if (number>0 && number<=7)
            {
                Console.WriteLine(days [number-1]);
            }
            else Console.WriteLine("Invalid day!");
        }
    }
}
