using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
    
            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side*side,3));
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a*b,3));
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI*r*r,3));
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a*h/2,3));
            }
        }
    }
}
