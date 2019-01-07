using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06_Extract_middle_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = array.Length;

            if (length == 1)
            {
                Console.WriteLine("{ " + array[0] + " }");
            }
            else if (length % 2 == 0)
            {
                Console.WriteLine("{ " + array[length/2-1] + ", " + array[length/2] + " }");
            }
            else if (length % 2 != 0)
            {
                Console.WriteLine("{ " + array[length/2-1] + ", " + array[length/2] + ", " + array[length/2 +1] + " }");

            }
        
            

        }
    }
}
