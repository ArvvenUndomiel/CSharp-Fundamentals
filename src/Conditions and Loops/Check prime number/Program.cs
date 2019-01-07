﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_34_Check_prime_number
{
    class Program
    {
        static void Main(string[] args)
        { 
            var n = int.Parse(Console.ReadLine());
            var prime = true;

            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (n < 2) prime = false;
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
