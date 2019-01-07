using System;

namespace Exercise_07_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "banana" || input == "kiwi" || input == "apple" || input == "cherry" || input == "lemon" || input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else Console.WriteLine("unknown");
        }
    }
}
