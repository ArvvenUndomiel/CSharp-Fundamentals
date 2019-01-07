using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercsie_Fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
                  //Read an array of 4*k integers, fold it in two
                  //Print the sum of the upper and lower two rows

                  //1. Create an array to store the input sequence
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                  //2. The three arrays will keep the results
            int[] leftFold = new int[inputArray.Length / 4];
            int[] rightFold = new int[inputArray.Length / 4];
            int[] resultArray = new int[inputArray.Length / 2];

                //3. Fold left and right side
            for (int i = 0; i < (inputArray.Length / 4); i++)
            {
                leftFold[i] = inputArray[(inputArray.Length / 4) - 1 - i];
                rightFold[i] = inputArray[inputArray.Length - 1 - i];
            }

                //4. Sum
            for (int i = 0; i < (inputArray.Length / 4); i++)
            {
                resultArray[i] = leftFold[i] + inputArray[inputArray.Length / 4 + i];
                resultArray[inputArray.Length / 4 + i] = rightFold[i] + inputArray[inputArray.Length / 2 + i];
            }

                //5. Print the result array
            Console.WriteLine(string.Join(" ", resultArray));

        }
    }
}
