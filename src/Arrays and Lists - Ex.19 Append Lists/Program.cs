using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19_Lists_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Write a program to append several lists of numbers.
                    //Lists are separated by ‘|’.
                    //Values are separated by spaces(‘ ’, one or several)
                    //Order the lists from the last to the first, and their values from left to right.

                    //1. Fill the list with the values from the console(split by |) and reverse their order
                    //Test data: 7 | 4  5|1 0| 2 5 |3

            List<string> items = Console.ReadLine().Split('|').ToList();

            items.Reverse();

                    //2. Create a list to keep the result
            var result = new List<string>();

                    //3. Go through the initial list and split the items by space(this will create empty items
                    //therefore keep all non-empty items in the result list

            foreach (var item in items)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }

                    //4. Print the result list
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
