using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9_Population_counter
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Data format: city|country|population
                    //For each country print its total population 
                    //and on separate lines, the data for each of its cities. 
                    //Countries should be ordered by their total population in descending order 
                    //and within each country, the cities should be ordered by the same criterion.

                    //1. Add each line into the list until "report"

            List<string> inputs = new List<string>();

            for (int i = 0; ; i++)
            {
                string entry = Console.ReadLine();

                if (entry == "report")
                {
                    break;
                }
                else
                {
                    inputs.Add(entry);
                }
            }

                    //2. Create a dictionary to keep the country(key) and (city(key) + population(value))

            var Dictionary = new Dictionary<string, Dictionary<string, long>>();

            foreach (var input in inputs)
            {
                    //3. Split the input line into separate elements

                var elements = input.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                string city = elements[0];
                string country = elements[1];
                int population = int.Parse(elements[2]);

                    //4.1 How to: Add elements to Population dictionary
                    //4.2 Check if key(country) does not exist, add it and city and pop. into value
                    //4.3 If country exists, add new city to existing cities

                if (!Dictionary.ContainsKey(country))
                {
                    var d = new Dictionary<string, long>();  //.net framework compatible syntax
                    d.Add(city, population);
                    Dictionary[country] = d;
                }
                else
                {
                    var currentCities = Dictionary[country];
                    currentCities.Add(city, population);
                    Dictionary[country] = currentCities;
                }
            }

                    //5 Order countries and cities in descending order by their population
            var sortedDict = Dictionary
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ToDictionary(
                    x => x.Key,
                    x => x.Value.OrderByDescending(y => y.Value).ToDictionary(y => y.Key, y => y.Value));

                    //6.1 Calculate the totalsum for each country and print the first row
                    //6.2 Print the second row for each city
            foreach (var kvp in sortedDict)
            {
                long countryPopulation = kvp.Value.Sum(x => x.Value);
                Console.WriteLine($"{kvp.Key} (total population: {countryPopulation})");

                foreach (var city in kvp.Value)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }


        }
    }
}
