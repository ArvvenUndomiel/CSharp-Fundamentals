using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Each line will contain materials and quantity
                    //Key materials: shards, fragments, motes (all else is junk)
                    //Count the resources, the first that reaches 250, wins the item
                    //Legendary items:
                    //Shadowmourne – requires 250 Shards
                    //Valanyr – requires 250 Fragments
                    //Dragonwrath – requires 250 Motes
                    //Finally print the remaining key materials ordered by quantity in descending order,
                    //...then by name in ascending order, each on a new line
                    //Print the collected junk items, in alphabetical order

                    //1. Store the key materials in a separate dictionary (start with quantity 0)

            var keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

                    //2. Junk materials are also in a separate sorted dictionary (to be printed alphabetically arranged)
                    //3. the boolean variable will check when the item is obtained

            var junk = new SortedDictionary<string, int>();
            bool notObtained = true;

            while (notObtained) //continue reading until the item is obtained
            {
                    //4. Read each line and store the elements in array
                string [] inputs = Console.ReadLine().ToLower().Split(' ').ToArray();

                    //5.1 Go through the array jumping 2 items
                    //5.2 Each first item is a quantity
                    //5.3 Each second item is a material
                for (int i = 0; i < inputs.Length; i+=2)
                {
                    int quantity = int.Parse(inputs[i]);
                    string material = inputs[i + 1];

                    if (keyMaterials.ContainsKey(material)) //If it is a key material, start adding to the quantity
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)  //If quantity passes 250:
                        {
                            keyMaterials[material] -= 250;  //Count the remaining quantity
                            string result = string.Empty;

                            switch(material)                //Check which is the material and choose the item
                            {
                                case "shards": result = "Shadowmourne"; break;
                                case "fragments": result = "Valanyr"; break;
                                case "motes": result = "Dragonwrath"; break;
                            }

                            Console.WriteLine($"{result} obtained!");  //Print the sentence 
                            notObtained = false;                       //Stop reading more lines
                            break;
                        }
                    }
                    else //If it is junk material, add it to the dictionary and start counting the quantity
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
            }
                    
                    //6.1 First Order the key materials by value (if value is equal, by alphab. key)
                    //6.2 Print the key materials
                    //6.3 Print the junk materials
            var resources = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
