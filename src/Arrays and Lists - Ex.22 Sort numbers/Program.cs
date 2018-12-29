using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_22_Sort_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Read a list of decimal numbers and sort them in increasing order.

                    //1. Read the sequence of numbers from the console in a list
                    //Test data: 8 2 7 3

            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

                    //2. Sort the list and print it

            numbers.Sort();

            Console.Write(string.Join(" <= ", numbers));

            Console.WriteLine();
        }
    }
}
