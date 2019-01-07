using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_Triple_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool none = true;

            for (int a = 0; a < arr.Length-1; a++)
            {
                for (int b = a+1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            none = false;
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            break;
                        }
                    }
                }
            }

            if (none == true)
            {
                Console.WriteLine("No");
            }   
        }
    }
}
