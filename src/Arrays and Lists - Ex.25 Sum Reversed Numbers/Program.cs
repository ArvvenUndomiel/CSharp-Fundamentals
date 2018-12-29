using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_25_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

                    //Write a program that reads sequence of numbers, reverses their digits, and prints their sum

                    //1. Store the sequence from the console in a list
                    //Test data: 12 12 34 84 66 12
                    //2. Create a new list to keep the results in

            var numbers = Console.ReadLine().Split(' ').ToList();

            List<int> reversedNumbers = new List<int>();

                    //3.1 Run the initial list through the cycle
                    //3.2 Store in a string each number one by one
                    //3.3 Break down the number into two chars and put them in array
                    //3.4 Reverse the order of the two chars
                    //3.5 Add the reversed numbers to the result list by converting them from char to int

            for (int i = 0; i < numbers.Count; i++)
            {
                string eachElement = numbers[i];
                char[] element = eachElement.ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                reversedNumbers.Add(int.Parse(string.Join("", reversed)));
            }

                    //4. Sum all elements by using the method .sum (from System.Linq)

            Console.WriteLine(reversedNumbers.Sum());

        }
    }
}
