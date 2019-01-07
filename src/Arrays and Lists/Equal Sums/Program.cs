using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {

                    //Determine if there exists an element in the array 
                    //such that the sum of the elements on its left is equal to the sum of the elements on its right
                    //Print the index of that element.

                    //1. Read the sequence and store it in the array
                    //Test data: 10 5 5 99 3 4 2 5 1 1 4

            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                    //2. Check if array contains only one element
            if (numArray.Length == 1)
            {
                Console.WriteLine("0"); return;
            }

            int leftSum = 0;
            int rightSum = 0;
            bool found = false;

            for (int pos = 0; pos < numArray.Length; pos++) //start searching
            {
                //sum LEFT numbers from current possition:
                for (int L = 0; L < pos; L++)
                {
                    leftSum += numArray[L];
                }
                //sum RIGHT numbers from current possition:
                for (int R = pos + 1; R < numArray.Length; R++)
                {
                    rightSum += numArray[R];
                }

                //check if sums are EQUAL:
                if (leftSum == rightSum)
                {
                    Console.WriteLine(pos);
                    found = true;
                }
                else //if not => reset sums:
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
