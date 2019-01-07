using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04_Phonebook_upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Add functionality to the phonebook from the previous task:
                    //Print all contacts ordered lexicographically when you receive the command “ListAll”.
                    
                    //1. Create a sorted dictionary to keep the entries sorted

            var phonebook = new SortedDictionary<string, string>();

                    //2. Same loop as in previous task
            for (int i = 0; ; i++)
            {
                var entry = Console.ReadLine().Split(' ');

                if (entry.Contains("END"))
                {
                    break;
                }

                if (entry[0] == "A")
                {

                    phonebook[entry[1]] = entry[2];

                }
                else if (entry[0] == "S")
                {
                    if (!phonebook.ContainsKey(entry[1]))
                    {
                        Console.WriteLine($"Contact {entry[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{entry[1]} -> {phonebook[entry[1]]}");
                    }
                }

                else if (entry[0] == "ListAll") //Additional command for printing all entries
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
            }

        }
    }
}
