using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every odd line is a resource (e.g.Gold, Silver, Copper)
            //Every even – quantity
            //Collect the resources and print them each on a new line.
            //Test data: Gold
            //           155
            //           Silver
            //           10
            //           Copper
            //           17
            //           stop


            //1. Create a dictionary to keep the resources

            var resources = new Dictionary<string, int>();
            bool isStopped = false;

            for (int i = 1; isStopped == false; i++)
            {
                var material = Console.ReadLine();  //Read the material

                if (material == "stop")  //Stop reading when "stop" is reached
                {
                    isStopped = true;
                    break;
                }

                int quantity = int.Parse(Console.ReadLine()); //Read the quantity

                if (!resources.ContainsKey(material))  //Add the materials to the dictionary
                {
                    resources.Add(material, 0);
                }

                resources[material] += quantity;  //Add the quantity of each material
  
            }

            foreach (var kvp in resources)  //Print the resources
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }  

        }
    }
}