using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23_Square_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
                        //Read a list of integers and extract all square numbers from it 
                        //and print them in descending order.

                        //1. Read the sequence from the console and put it in a list
                        //Test data: 12 1 9 4 16 8 25 49 16

                List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
                    

                        //2. Create a list to keep the result
                List<long> result = new List<long>();


                        //3. Sort and reverse the order of the initial list
                nums.Sort();
                nums.Reverse();

                        //4. Go through the sorted initial list and check if each number is a square number
                        //Math.Sqrt gives the square root of the number
                        //Math.Truncate(Math.Sqrt()) calculates the square root and then gives the integral part
                        //e.g. we check if Math.Sqrt(12), which is 3.464 == 3

                for (int i = 0; i < nums.Count; i++)
                    {

                    if (Math.Sqrt(nums[i]) == Math.Truncate(Math.Sqrt(nums[i])))
                        result.Add(nums[i]);
                    }

                        //5. Print the result list with only the square numbers in reverse order
                Console.WriteLine(string.Join(" ", result));

        }
    }
}
