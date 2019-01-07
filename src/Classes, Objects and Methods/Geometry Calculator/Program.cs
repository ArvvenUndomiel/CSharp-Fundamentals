using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0.0;

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = GetTriangleArea(side, height);
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = GetSquareArea(side);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = GetRectangleArea(width, height);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = GetCircleArea(radius);
            }

            PrintArea(area);
  
        }

        static double GetTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        static double GetSquareArea (double side)
        {
            return side * side;
        }

        static double GetRectangleArea (double width, double height)
        {
            return width * height;
        }

        static double GetCircleArea (double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static void PrintArea (double area)
        {
            Console.WriteLine($"{area:f2}");
        }
    }
}
