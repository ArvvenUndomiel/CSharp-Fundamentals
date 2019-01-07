using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04___Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sumArray = new int[Math.Max(array1.Length, array2.Length)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }
            foreach (int sum in sumArray)
            {
                Console.Write($"{sum} ");
            }

        }
    }
}
