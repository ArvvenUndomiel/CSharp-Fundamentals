using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(side, height);
            Console.WriteLine(area);
        }

        static double CalculateTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
