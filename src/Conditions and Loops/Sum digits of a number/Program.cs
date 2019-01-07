using System;


namespace Exercise_29_Sum_digits_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            do
            {
                sum = sum + (num % 10);
                num = num / 10;
            }
            while (num > 0);
            
            Console.WriteLine(sum);

            //19 % 10 = 9 (sum)
            //19 = 19/10 = 1 (num)
            //sum = 1+9 = 10
        }
    }
}
