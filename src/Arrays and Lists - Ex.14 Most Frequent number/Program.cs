using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_Most_Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
                    // Write a program that finds the most frequent number in a given sequence of numbers
                    //1. Read the sequence and store it in array
                    //Test data: 4 1 1 4 2 3 4 4 1 2 4 9 3

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    //2. Create two variables to keep the number and  max number of occurrences
            int maxOccurrences = 0;
            int actualNumber = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                    //3.1 Take each number and search for it in the array
                    //3.2 If you find a duplicate, increase the current occurrences

                int currentOccurences = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentOccurences++;
                    }
                }

                     //4.1 if maxoccurrences is less than the current, then max becomes current
                     //4.2 and we save the actual number in a different variable
                if (maxOccurrences < currentOccurences)
                {
                    maxOccurrences = currentOccurences;
                    actualNumber = numbers[i];

                }
            }

                    //5. Finally we print the number which has the most occurrences
            Console.WriteLine(actualNumber);
        }
    }
}
