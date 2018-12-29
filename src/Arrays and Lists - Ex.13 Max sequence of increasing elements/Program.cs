using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13_Max_sequence_of_increasing_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int temporarySeqCount = 0;
            int longestSequenceCount = 0;
            int startingPosition = 0;
            int finalPosition = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var currentNumber = array[i];
                var nextNumber = array[i + 1];
                if (currentNumber + 1 == nextNumber)
                {
                    temporarySeqCount++;
                    startingPosition = (i+1) - temporarySeqCount;

                    if (temporarySeqCount > longestSequenceCount)
                    {
                        longestSequenceCount = temporarySeqCount;
                        finalPosition = startingPosition;
                    }

                }
                else
                {
                    temporarySeqCount = 0;
                }

            }
            //string result = null;

            for (int r = finalPosition; r <= finalPosition + longestSequenceCount; r++)
            {
                //result += array[r] + " ";
                Console.Write($"{array[r]} ");
            }
            Console.WriteLine();
            //Console.Write(result.Trim());
        }
    }
}
