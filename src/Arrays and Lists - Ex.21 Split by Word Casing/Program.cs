using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21_Lists_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read a text, split it into words and distribute them into 3 lists: lower-case, mixed and upper.
            //Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
            //Print the three lists

            //1. Split the input by an array of characters
            //Test data: Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.

            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }, 
                StringSplitOptions.RemoveEmptyEntries).ToList();

                    //2. Create the result lists

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

                    //3. Check the case of the characters in each word
            foreach (var word in words)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }

                }

                        //4. Based on the boolean variables assign the words to the correct lists

                if (isAllLowerCase)
                {
                    lowerCase.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

                    //5. Print the three lists
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
