using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_Max_sequence_of_equal_elements
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Write a program that finds the longest sequence of equal elements in an array of integers
                    //1. Read the numbers, split them and store them in array

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                    //2. Create the variables to calculate the sequence
            int repeat = 0;
            int longestSequence = 0;
            int number = 0;
                
                    //3.1 Go through the array
            for (int i = 0; i < array.Length-1; i++)
            {
                    //3.2 Check if each second number is equal to the previous number
                    //3.3 If yes, increase repeat and store the max repeat in another variable + the number itself
                if (array[i+1] == array[i])
                {
                    repeat++;

                    if (repeat > longestSequence)
                    {
                        longestSequence = repeat;
                        number = array[i];
                    }
                }
                else  //3.4 If not, return to initial count of repeat
                {
                    repeat = 0;
                }
            }
                    //4. Print the number as many times, as the longest sequence
            for (int r = 0; r <= longestSequence; r++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            
            
        }
    }
}
