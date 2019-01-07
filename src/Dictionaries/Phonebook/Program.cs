using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
                    //You will receive a command on each line:
                    //A {name} {phone} – adds entry to the phonebook.
                    //S {name} – searches for a contact by given name and prints it in format "{name} -> {number}"
                    //END – stop receiving more commands.
                    //Test data:A Nakov 0888080808
                    //          S Mariika
                    //          S Nakov
                    //          END

                    // 1.1 Create the phonebook dictionary

            var phonebook = new Dictionary<string, string>();

            for (int i = 0; ;i++)  //endless loop until "END" command is reached
            {
                var entry = Console.ReadLine().Split(' ');

                if (entry.Contains("END"))
                {
                    break;
                }

                if (entry[0] == "A") //Set the number to the person
                {

                    phonebook[entry[1]] = entry[2];
                        
                }
                else if (entry[0] == "S") //Print the number
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
            }  
        }
    }
}
