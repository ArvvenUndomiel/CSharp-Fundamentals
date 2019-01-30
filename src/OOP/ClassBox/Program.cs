using System;

namespace ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box myBox = new Box(length, width, height);

            var volume = myBox.Volume();
            var surfaceArea = myBox.SurfaceArea();
            var lateralArea = myBox.LateralSurfaceArea();

            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralArea:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
