using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_26_Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Read a sequence of numbers and special bomb number with a certain power
                    //Test data: 1 4 4 2 8 9 1
                    //           9 3
                    //Detonate every occurrence of the special bomb number
                    //And according to its power his neighbors from left and right 
                    //Print the sum of the remaining elements in the sequence

                    //1. Read each line and store it in a separate list
                    //2. Have two variables to store the special number and the power

            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var detonationData = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = detonationData[0];
            int blastPower = detonationData[1];

                    //3.1 Do the cycle until there is a bombnumber in the list
                    //3.2 Run through the list and do the detonation if you reach the bombnumber
                    //3.3 Store the index of the bombnumber separately
                    //3.4 Calculate where to start (front) and where to end(back) the detonation
                    //3.5 Remove from front to back

            while (listOfNumbers.Contains(bombNumber))
            {
              
                for (int number = 0; number < listOfNumbers.Count; number++)
                {
                    if (listOfNumbers[number] == bombNumber)
                    {
                        int bombIndex = number;

                        int front = bombIndex - blastPower;

                        if (front < 0)
                            front = 0;

                        int back = bombIndex + blastPower;

                        if (back >= listOfNumbers.Count)
                            back = listOfNumbers.Count - 1;

                        for (int i = front; i <= back; i++)
                            listOfNumbers.RemoveAt(front);
                    }
                }
            }

                    //4. Sum the remaining elements in the list

            var sum = 0;

            foreach (var numbers in listOfNumbers)
                sum += numbers;

            Console.WriteLine(sum);
        }
    }
}
