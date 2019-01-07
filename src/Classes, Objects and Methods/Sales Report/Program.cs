using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16_Sales_Report
{
    [DebuggerDisplay("{Town} {Product} {Price} {Quantity}")]
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Revenue
        {
            get
            { return Price * Quantity; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }

            var salesByTown = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown.Add(sale.Town, sale.Revenue);
                }
                else
                {
                    salesByTown[sale.Town] += sale.Revenue;
                }
            }

            foreach (var kvp in salesByTown)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split(' ');

            return new Sale()
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }
    }
}
