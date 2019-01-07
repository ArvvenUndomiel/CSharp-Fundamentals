using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01_Count_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Read a list of real numbers
                    //print them in ascending order along with their number of occurrences
                    //Test data: 1.5 5 1.5 3

                    //1. Read the sequence and store it in array

            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                    //2. Check each number and add it to the dictionary if found for the first time
                    // on the second time, increase the count

            var myDictionary = new SortedDictionary<double, int>();

            foreach (double number in input)
            {

                if (!myDictionary.ContainsKey(number))
                {
                    myDictionary.Add(number, 1);
                }
                else
                {
                    myDictionary[number]++;
                }

            }
                    //3. Sort the dictionary and print it

             var sorted = myDictionary.OrderBy(kvp => kvp.Key);

             foreach (var kvp in sorted)
            {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
