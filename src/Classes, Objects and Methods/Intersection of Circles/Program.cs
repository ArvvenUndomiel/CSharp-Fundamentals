using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18_Intersection_of_Circles
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static Point Parse (string input)
        {
            int[] coordinates = input.Split(' ').Select(int.Parse).ToArray();
            Point result = new Point(coordinates[0], coordinates[1]);
            return result;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Circle
    {

        public Point Center {get; set; }
        public int Radius { get; set; }
        
        public static Circle Parse (string input)
        {
            var args = input.Split(' ').Select(int.Parse).ToList();
            Circle result = new Circle();
            result.Radius = args[2];

            // Option: 1 (no constructor)
            // Point centerPoint = new Point() { X = args[0], Y = args[1] };

            //Option: 2 (with constructor)
            Point centerPoint = new Point(args[0], args[1]);
            result.Center = centerPoint;

            return result;
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            Circle c1 = Circle.Parse(firstInput);
            Circle c2 = Circle.Parse(secondInput);

            var result = AreIntersecting(c1, c2);

            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool AreIntersecting(Circle A, Circle B)
        {
            var radiusSum = A.Radius + B.Radius;
            var centerDistance = CalcDistanceBetweenPoints(A.Center, B.Center);

            return radiusSum >= centerDistance;

        }

        static double CalcDistanceBetweenPoints(Point p1, Point p2)
        {
            int A = p1.X - p2.X;
            int B = p1.Y - p2.Y;

            return Math.Sqrt(A * A + B * B);
        }
    }
}
