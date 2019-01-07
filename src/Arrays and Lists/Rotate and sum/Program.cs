using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09_Rotate_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Write a program to read an array of n integers and an integer k
                    //Rotate the array right k times
                    //Sum the obtained arrays after each rotation
                    //Test data: 3 2 4 -1

                    //1. Read the sequence and store it in a list
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

                    //2. Keep the sum in array
            int[] sum = new int[input.Count];

            int k = int.Parse(Console.ReadLine());

                     
            for (int i = 0; i < k; i++)
            {
                    //3.Place the last element on first position and remove it
                input.Insert(0, input[input.Count - 1]);
                input.RemoveAt(input.Count - 1);
                    
                    //4. In the sum array, keep the previous array and sum the result input array
                for (int j = 0; j < input.Count; j++)
                {
                    sum[j] = sum[j] + input[j];
                }

            }
                    //5. Print the final sum array
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
