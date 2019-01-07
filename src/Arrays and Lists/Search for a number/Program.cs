using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24_Search_for_a_number
{
    class Program
    {
        static void Main(string[] args)
        {

                        //First line: sequence of numbers 12 412 123 21 654 34 65 3 23
                        //Second line: array of 3 numbers 7 4 21
                                //First number of elements to take from the list
                                //Second number of elem to delete from the list you took
                                //Third is the number you search for in the remaining list

                        //1. Read the first sequence and store it in a list

                List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

                        //2. Read the array and store it in array

                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                        //3. Create another list to keep the result in

                List<int> newList = new List<int>();

                        //4. Run a cycle from 0 to first number and add the numbers from the initial into the result list
                for (int i = 0; i < numbers[0]; i++)
                {
                    newList.Add(inputList[i]);
                }

                        //5. From the result list remove as many numbers as the second number
                newList.RemoveRange(0, numbers[1]);

                        //6. Check if the result list contains the third number and print "Yes" or "No"

                if (newList.Contains(numbers[2]))
                {
                    Console.WriteLine("YES!");
                }
                else
                {
                    Console.WriteLine("NO!");
                }
        }
    }
 }

