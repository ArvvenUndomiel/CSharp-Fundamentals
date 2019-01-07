using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06_Fix_emails
{
    class Program
    {
        static void Main(string[] args)
        {

                    //First string - name of a person
                    //Second string - email
                    //Collect their names and emails
                    //Remove emails whose domain ends with "us" or "uk" (case insensitive).

                    //Test data:Ivan
                    //          ivanivan @abv.bg
                    //          Petar Ivanov
                    //          petartudjarov@abv.bg
                    //          Mike Tyson
                    //          myke@gmail.us
                    //          stop

                    //1. Keep the results in a dictionary

            var emails = new Dictionary<string, string>();

            for (int i = 0; ; i++) //endless loop until "stop" is reached
            {
                    //2.1 Read the name

                var name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                    //2.2 Read the email
                string email = Console.ReadLine();

                    //2.3 Check if email does not contain us or uk and add it to the dictionary (compare by ignoring the case)
                if (!email.EndsWith(".uk", StringComparison.OrdinalIgnoreCase) && !email.EndsWith(".us", StringComparison.OrdinalIgnoreCase))
                {
                    emails.Add(name, email);
                }

            }

                    //3. Print the dictionary
            foreach (var kvp in emails)
            {
             Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

            }
        }
    }
}
