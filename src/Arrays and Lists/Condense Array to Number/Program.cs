using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05___Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var length = nums.Length;

           while (length > 1)
           {
               for (int i = 0; i < length-1; i++)
               {
                   nums[i] = nums[i] + nums[i + 1];
               }
               length--;

           }
            Console.WriteLine(nums[0]);
        }
    }
}
