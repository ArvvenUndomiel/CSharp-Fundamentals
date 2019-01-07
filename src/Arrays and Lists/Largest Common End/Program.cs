using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            int counter = 0;
            int shorterArray = Math.Min(array1.Length, array2.Length);

            if (array1[0] == array2[0])

                for (int i = 0; i < shorterArray; i++)
                {
                    if (array1[i].Equals(array2[i]))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }                    
                }

            else if (array1[array1.Length - 1] == array2[array2.Length - 1])
            {
                string[] reversedarray1 = array1.Reverse().ToArray();
                string[] reversedarray2 = array2.Reverse().ToArray();

                for (int i = 0; i < shorterArray; i++)
                {
                    if (reversedarray1[i].Equals(reversedarray2[i]))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }  
                }
            }
            Console.WriteLine(counter);
        }
    }
}
