using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09_Primes_in_a_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var primeNumbers = new List<int>(GetPrimesinRange(startNum, endNum));
            if (primeNumbers.Count == 0)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                Console.WriteLine(string.Join(", ", primeNumbers));
            }
        }

        static List<int> GetPrimesinRange(int startNum, int endNum)
        {
            
            var numbers = new List<int>(); //Add all numbers in the range
            var primeNumbers = new List<int>();
            bool isPrime = true;

            if (startNum > endNum)
            {
                return primeNumbers;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 2)
                {
                    continue;
                }
                for (int j = 2; j <= Math.Sqrt(numbers[i]); j++)
                {

                    if (numbers[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(numbers[i]);
                }
            }

            return primeNumbers;
        }
    }
}
