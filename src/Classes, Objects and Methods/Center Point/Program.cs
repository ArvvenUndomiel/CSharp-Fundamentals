using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            CalcDistancefromCenter(X1, Y1, X2, Y2);
        }

        static void CalcDistancefromCenter(double x1, double y1, double x2, double y2)
        {

            double distance1 = Math.Sqrt((Math.Pow(x1, 2) + Math.Pow(y1, 2)));
            double distance2 = Math.Sqrt((Math.Pow(x2, 2) + Math.Pow(y2, 2)));

            if (distance1 > distance2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
