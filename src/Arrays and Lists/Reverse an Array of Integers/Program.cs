using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02___Reverse_and_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] myArray = new int[n];
            int[] reversedArray = new int[myArray.Length];
            int index = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray [i] = int.Parse(Console.ReadLine());
            }

            for (int i = myArray.Length-1; i >=0; i--)
            {
                reversedArray[index] = myArray[i];
                index++;
            }

            Console.WriteLine(string.Join(" ",reversedArray));
 
        }
    }
}
