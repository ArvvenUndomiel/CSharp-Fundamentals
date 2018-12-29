using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Write a program that reads an array of integers from the console 
                    //and set of commands and executes them over the array

                    //Commands:
                    //add <index> <element> – adds element at the specified index (elements right from this position inclusively are shifted to the right)
                    //addMany <index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index
                    //contains <element> – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found
                    //remove <index> – removes the element at the specified index
                    //shift <positions> – shifts every element of the array the number of positions to the left (with rotation)
                    //sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …)
                    //print – stop receiving more commands and print the last state of the array

                    //1. Store the sequence in a list
                    //2. Store the commands in string

            List<long> list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string command = Console.ReadLine();

                    //3.1 Keep executing commands until "print" command
                    //3.2 Split each command and store it in array
                    //3.3 Use a switch to go through the various scenarios
                    //3.4 "add" get the index and the elements and add them
                    //3.5 "addMany" get the index and the elements(skip command and index) and add them
                    //3.6 "contains" get the index of the element (if not found, IndexOf automatically returns -1)
                    //3.7 "remove" get the index and remove the element
                    //3.8 "shift" shift the elements with 1 (and so many times as indicated)
                    //3.9 "sumPairs" sum two elements and jump i with 2 (if number is odd, add the last element too)
                    //3.10 print the result of each command

            while (command != "print")
            {
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        long element = long.Parse(tokens[2]);
                        list.Insert(index, element);
                        break;
                    case "addMany":
                        int index2 = int.Parse(tokens[1]);
                        List<long> elementsToAdd = tokens.Skip(2).Select(long.Parse).ToList();
                        list.InsertRange(index2, elementsToAdd);
                        break;
                    case "contains":
                        long element2 = long.Parse(tokens[1]);
                        Console.WriteLine(list.IndexOf(element2));
                        break;
                    case "remove":
                        int index3 = int.Parse(tokens[1]);
                        list.RemoveAt(index3);
                        break;
                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            long lastElement = list[0];
                            for (int j = 0; j < list.Count - 1; j++)
                            {
                                list[j] = list[j + 1];
                            }
                            list[list.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        List<long> newList = new List<long>();
                        for (int i = 0; i < list.Count - 1; i += 2)
                        {
                            newList.Add(list[i] + list[i + 1]);
                        }
                        if (list.Count % 2 == 1)
                        {
                            newList.Add(list[list.Count - 1]);
                        }
                        list = newList;
                        break;
                }

                command = Console.ReadLine();
            }

                    //4.  Print the last state of the list

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }
}