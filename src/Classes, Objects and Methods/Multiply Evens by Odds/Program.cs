using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetProductofEvensandOdds(number);
            Console.WriteLine(result);
        }

        static int GetProductofEvensandOdds(int number)
        {
            int numberAbs = Math.Abs(number);
            int[] digits = numberAbs.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int product = GetSumofEvenDigits(digits) * GetSumofOddDigits(digits);
            return product;
        }

        static int GetSumofEvenDigits(int[] digits)
        {
            int evenSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    evenSum += digits[i];
                }
            }
            return evenSum;
        }

        static int GetSumofOddDigits(int[] digits)
        {
            int oddSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 != 0)
                {
                    oddSum += digits[i];
                }
            }
            return oddSum;
        }
    }
}
