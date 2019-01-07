using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

                    //Create an array containing all letters from the alphabet (a-z). 
                    //Read a lowercase word from the console and print the index of each of its letters in the letters array.
            
                    //1. Create an array and populate it with the alphabet characters from ASCII table

            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);
            }

                    //2. Read the word from the console and store it in string (string is an array of chars)
                    //Test data: softuni

            string word = Console.ReadLine();

                    //3. Print the character and the index from the array

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(alphabet,word[i])}");
            }
        }
    }
}
