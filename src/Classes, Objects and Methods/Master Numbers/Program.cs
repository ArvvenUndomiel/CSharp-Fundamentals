using System;
using System.Linq;

namespace Exercise_12_Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool palindrome = IsPalindrome(i.ToString());
                bool sumdiv7 = SumDivBy7(i);
                bool iseven = IsEvenDigit(i);

                if (sumdiv7)
                {
                    if (iseven)
                    {
                        if (palindrome)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        static bool IsPalindrome(string text)
        {
            for (byte i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static bool SumDivBy7(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsEvenDigit (int number)
        {
            while (number != 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    return true;
                }

                number = number / 10;
            }
            return false;
        }
    }
}


