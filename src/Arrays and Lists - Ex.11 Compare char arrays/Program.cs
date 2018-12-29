using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11_Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Compare two char arrays lexicographically (letter by letter).
                    //Print the them in alphabetical order, each on separate line.

                    //1. Read the two lines of chars and store them in separate arrays

            char[] lettersA = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] lettersB = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                    
                    //2. Check which is the smaller array
            int smallerWord = Math.Min(lettersA.Length, lettersB.Length);
            int result = 0;

                    //3.1 Go through the smaller length and check the order of the corresponding letters
            for (int i = 0; i < smallerWord; i++)
            {       
                    //3.2 If the letter of A comes before the letter of B, set the result to -1
                if (lettersA[i] < lettersB[i])
                {
                    result = -1;
                    break;
                }  //3.3 If the letter of A comes after the letter of B, set the result to 1
                else if (lettersA[i] > lettersB[i])
                {
                    result = 1;
                    break;
                }
            }
                    //4.1 If result is 1, then first print the second array
            if (result == 1)
            {
                Console.WriteLine(string.Join("",lettersB));
                Console.WriteLine(string.Join("",lettersA));
            }
                    //4.2 If result is -1, then first print the first array
            else if (result == -1)
            {
                Console.WriteLine(string.Join("", lettersA));
                Console.WriteLine(string.Join("", lettersB));
            }
                    //4.3 If result remains 0, then print first the smaller array
            else
            {
                if (lettersA.Length > lettersB.Length)
                {
                Console.WriteLine(string.Join("", lettersB));
                Console.WriteLine(string.Join("", lettersA));
                }
                else
                {
                    Console.WriteLine(string.Join("", lettersA));
                    Console.WriteLine(string.Join("", lettersB));
                }
            }

        }
    }
}
