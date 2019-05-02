using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string peopleInput = Console.ReadLine();
                string productsInput = Console.ReadLine();

                var people = ParsePeople(peopleInput);
                var products = ParseProducts(productsInput);

                CommandProcessor processor = new CommandProcessor();

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] argz = processor.Parse(command);
                    var person = people.Find(p => p.Name == argz[0]);
                    var product = products.Find(p => p.ProductName == argz[1]);

                    Console.WriteLine(processor.Process(person, product));

                    command = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    var personProducts = person.GetProducts();
                    if (personProducts.Count > 0)
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", personProducts)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }


        }

        static List<Person> ParsePeople (string peopleInput)
        {
            List<Person> result = new List<Person>();
            string[] inputs = peopleInput.Split(';');

            foreach (var input in inputs)
            {
                Person currentPerson = ParsePerson(input);
                result.Add(currentPerson);
            }

            return result;

        }

        static Person ParsePerson (string input)
        {
            var arguments = input.Split('=');
            var name = arguments[0];
            var money = decimal.Parse(arguments[1]);

            return new Person(name, money);
        }

        static List<Product> ParseProducts (string productsInput)
        {
            List<Product> result = new List<Product>();
            string[] inputs = productsInput.Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var input in inputs)
            {
                Product currentProduct = ParseProduct(input);
                result.Add(currentProduct);

            }

            return result;
        }

        static Product ParseProduct(string input)
        {
            var arguments = input.Split('=');
            var name = arguments[0];
            var price = decimal.Parse(arguments[1]);

            return new Product(name, price);
        }
    }
}
