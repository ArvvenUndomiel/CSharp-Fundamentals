using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18_Lists_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Read a list of integers,
                    //remove all negative numbers from it
                    //print the remaining elements in reversed order. 
                    //In case of no elements left in the list, print “empty”

                    //1. Fill the list with the values from the console(split by space)
                    //Test data: 10 -5 7 9 -33 50
            Console.WriteLine("Enter list of numbers separated by space");

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                    //2. Create a new list to keep the result 
                    //and populate it with all non-negative numbers from the first list

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }

                    //3. Reverse the result array

            result.Reverse();

                    //4. Print the result array if not empty
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",result));

            }
        }
    }
}
