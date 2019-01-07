using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string biggerWord = GetMax(a, b);
                Console.WriteLine(biggerWord);
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char biggerChar = GetMax(a, b);
                Console.WriteLine(biggerChar);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }  
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
