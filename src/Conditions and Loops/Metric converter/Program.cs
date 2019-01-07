using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09_Metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number  = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            decimal result = 0;
            
            // Step 1 convert input to meter

            switch (input)
            {
                case "mm":number = number / 1000; break;
                case "cm":number = number / 100; break;
                case "mi":number = number / 0.000621371192m; break;
                case "in":number = number / 39.3700787m; break;
                case "km":number = number / 0.001m; break;
                case "ft":number = number / 3.2808399m; break;
                case "yd": number = number / 1.0936133m; break;

                default:
                    break;
            }
                     
            // Step 2 ConvertedInputNumber in meters to chosen output

            switch (output)
            {
                case "mm": result = number * 1000; break;
                case "cm": result = number * 100; break;
                case "mi": result = number * 0.000621371192m; break;
                case "in": result = number * 39.3700787m; break;
                case "km": result = number * 0.001m; break;
                case "ft": result = number * 3.2808399m; break;
                case "yd": result = number * 1.0936133m; break;
                case "m": result = number; break;
              
                default:
                    break;
            }

            Console.WriteLine($"{result:f8}");
        }
    }
}
