using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07_Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

                    // You are given a sequence of people and for every person what cards he draws from the deck.
                    //Input format: {personName}: {PT, PT, PT,… PT}
                    // P(2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T(S, H, D, C) is the type. 
                    //The input ends when a "JOKER" is drawn
                    //A single person cannot have more than one card with the same power and type
                    //Each card has a value that is calculated by the power multiplied by the type. 
                    //Powers 2 to 10 have the same value and J to A are 11 to 14
                    //Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1)
                    //Finally print out the total value each player has in his hand in the format: {personName}: {value}

                    //1. Store the value of the power and type in a dictionary

            var game = new Dictionary<string, int>()
            {
                {"2", 2 },
                {"3", 3 },
                {"4", 4 },
                {"5", 5 },
                {"6", 6 },
                {"7", 7 },
                {"8", 8 },
                {"9", 9 },
                {"10", 10 },
                {"J", 11 },
                {"Q", 12 },
                {"K", 13 },
                {"A", 14 },
                {"S", 4 },
                {"H", 3 },
                {"D", 2 },
                {"C", 1 },
            };

                    //2. Create two dictionaries to keep the result
            var result = new Dictionary<string, int>();
            var playerUniqueCards = new Dictionary<string, HashSet<string>>();

                    //3. Read the hands from the console and store them in a list
                    // Stop reading when you reach JOKER
                    //Test data: Pesho: 2C, 4H, 9H, AS, QS

            List<string> inputs = new List<string>();

            for (int i = 0; ; i++)
            {
                var entry = Console.ReadLine();

                if (entry == "JOKER")
                {
                    break;
                }

                inputs.Add(entry);
            }

                    //4.1 Split each segment in the list first to player and all the cards
                    //4.2 Then split and keep the cards separately
                    //4.3 k holds the player name
                    //4.4 Make a check if player is already added: if not add him to the dictionary as key and his cards as hashset
                    //4.5 If player exists - add the additional cards

            foreach (var input in inputs)
            {
                var playerCards = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                var cards = playerCards[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var k = playerCards[0];
                if (playerUniqueCards.ContainsKey(k))
                {
                    for (int i = 0; i < cards.Length; i++)
                    {
                        playerUniqueCards[k].Add(cards[i]);
                    }
                }
                else
                {
                    playerUniqueCards[k] = new HashSet<string>(cards);
                }
            }

                    //5.1 Calculate the value of the cards and sum them

            foreach (var kvp in playerUniqueCards)
            {
                var totalSum = 0;

                foreach (var element in kvp.Value)
                {
                    if (element.Length > 2)  //Normally length is 2, but when card is 10 - length is 3)
                    {
                        var cardColor = element[2];  //The color is the third element

                        totalSum += game["10"] * game[cardColor.ToString()];
                    }
                    else
                    {
                        var cardSign = element[0];  //The sign is the first element
                        var cardColor = element[1]; //The color is the second element

                        totalSum += game[cardSign.ToString()] * game[cardColor.ToString()];
                    }

                }

                        //6. Check if result already contains the player and add the sum

                if (result.ContainsKey(kvp.Key))
                {
                    result[kvp.Key] += totalSum;
                }
                else
                {
                    result[kvp.Key] = totalSum;
                }
            }

                    //7. Print the result

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Key}: {person.Value}");
            }
        }
    }
}
