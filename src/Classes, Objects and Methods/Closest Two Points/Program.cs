using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17_Closest_Two_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void PrintPoint()  // optimize with override tostring method 
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                points.Add(ReadPoints());
            }

            var minDistance = double.MaxValue;
            Point firstPoint = new Point();
            Point secondPoint = new Point();
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = CalcDistanceBetweenPoints(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPoint = points[i];
                        secondPoint = points[j];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            firstPoint.PrintPoint();
            secondPoint.PrintPoint();
        }

        static Point ReadPoints()
        {
            string[] input = Console.ReadLine().Split(' ');

            return new Point
            {
                X = int.Parse(input[0]),
                Y = int.Parse(input[1])
            };
        }

        static double CalcDistanceBetweenPoints(Point p1, Point p2)
        {
            int A = p1.X - p2.X;
            int B = p1.Y - p2.Y;

            return Math.Sqrt(A * A + B * B);
        }
    }
}
