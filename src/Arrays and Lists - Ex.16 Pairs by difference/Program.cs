using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16_Pairs_by_difference
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Count the number of pairs in given array which difference is equal to given number

                    //1. Store the sequence in an array
                    //Test data: 1 5 3 4 2
                    //           2 (the difference)

            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());
            var found = 0;

                    //2.1 Run two cycles through the initial array - one starting from the front and another one from the back
                    //2.2 Check if the difference equals the number and store the number of pairs

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = elements.Length - 1; j > i; j--)
                {
                    if (elements[i] - elements[j] == number || elements[j] - elements[i] == number)
                    {
                        found++;
                    }
                }
            }

                    //3. Print then number of pairs

            Console.WriteLine(found);
        }
    }
}
