using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_Personal_titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age >= 16)
            {
                if (gender == "m") Console.WriteLine("Mr.");
                else Console.WriteLine("Ms.");
            }
            else if (age < 16)
            {
                if (gender == "m") Console.WriteLine("Master");
                else Console.WriteLine("Miss");
            }        
        }
    }
}
