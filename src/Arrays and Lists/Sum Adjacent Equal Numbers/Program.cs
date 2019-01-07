using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

                    //Write a program to sum all adjacent equal numbers in a list of decimal numbers, 
                    //..starting from left to right.

                    //1. Read the input string from the console, split it and populate the list with the numbers
                    //Test data: 8 2 2 4 8 16

            List<double> numbers = new List<double>();

            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();

            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(double.Parse(list[i]));
            }

                    //2. Go through the now populated list and check if adjacent numbers are equal
                    //3. If yes, assign the sum to the first element and remove the second
                    //4. Return the cycle to the initial element again

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

                    //5. Print the resulting list
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
