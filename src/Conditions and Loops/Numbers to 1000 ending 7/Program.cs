using System;

namespace Exercise_20_Numbers_to_1000_ending_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i < 1000; i+=10)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
