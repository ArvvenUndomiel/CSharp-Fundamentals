using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

                    //Extract from a given sequence of words all elements 
                    //...that are present in it odd number of times(case-insensitive)
                    //Test data: Java C# PHP PHP JAVA C java

                    //1. Read the sequence and store it in array
                    //2. Create a dictionary to keep the intermediate result

            var input = Console.ReadLine().Split(' ').ToArray();
            var myDictionary = new Dictionary<string, int>();

                    //3.1 Convert each word to lowercase
                    //3.2 Check if word is contained in the dictionary
                    //..if not, add it
                    //..if yes, increase the count

            foreach (var word in input)
            {
                var lowerWord = word.ToLower();
                if (!myDictionary.ContainsKey(lowerWord))
                {
                    
                    myDictionary.Add(lowerWord, 1);
                }
                else
                {
                    myDictionary[lowerWord]++;
                }
            }
                    //4. Check the number of occurrences (the values in the dictionary) and
                    //...if odd - add the keys to the result list

            List<string> result = new List<string>();
            foreach (var wordKeyValue in myDictionary)
            {
                if (wordKeyValue.Value % 2 !=0)
                {
                    result.Add(wordKeyValue.Key);
                }
            }

                    //5. Finally print the result list

            Console.WriteLine(string.Join(", ", result));
        }


    }
}
