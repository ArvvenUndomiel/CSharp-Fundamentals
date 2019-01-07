using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15_Distance_between_points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"{distance:f3}");
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        static double CalcDistance (Point p1, Point p2)
        {
            int A = p1.X - p2.X;
            int B = p1.Y - p2.Y;

            return Math.Sqrt(A * A + B * B);
        }
    }
}
