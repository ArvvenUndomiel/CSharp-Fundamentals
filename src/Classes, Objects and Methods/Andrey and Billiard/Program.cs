using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22_Andrey_and_Billiard
{
    class ShopItem
    {
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        public static ShopItem StockinShop (string input)
        {
            var args = input.Split('-').ToList();
            var item = args[0];
            var price = decimal.Parse(args[1]);

            ShopItem Item = new ShopItem
            {
                ItemName = item,
                Price = price
            };
            return Item;
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Orders { get; set; }
        public decimal Bill { get; set; }

        public static Customer GetOrders (string input)
        {
            var args = input.Split(new[] {"-",","}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var name = args[0];
            var item = args[1];
            var quantity = int.Parse(args[2]);
            var orders = new Dictionary<string, int>();
            orders[item] = quantity;
        
            Customer customer = new Customer
            {
                Name = name,
                Orders = orders
            };
            return customer; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var customerList = new List<Customer>();
            var shop = new Dictionary<string, decimal>();

            //Stock items into shop

            for (int i = 0; i < num; i++)
            {
                ShopItem item = ShopItem.StockinShop(Console.ReadLine());

                if (!shop.ContainsKey(item.ItemName))
                {
                    shop.Add(item.ItemName, item.Price);
                }
                else
                {
                    shop[item.ItemName] = item.Price;
                }
            }

            //Get orders from customers

            string input = Console.ReadLine();
            
            while (input != "end of clients")
            {
                Customer customer = Customer.GetOrders(input);
                var OrdersItem = customer.Orders.Select(x => x.Key).First();
                var OrdersQuantity = customer.Orders.Select(x => x.Value).First();

                if (shop.ContainsKey(OrdersItem))
                {
                    if (!customerList.Any(c => c.Name.Equals(customer.Name)))
                    {
                        customer.Bill = OrdersQuantity*shop[OrdersItem];
                        customerList.Add(customer);
                    }
                    else
                    {
                        Customer existingCustomer = customerList.First(c => c.Name.Equals(customer.Name));
                        if (!existingCustomer.Orders.ContainsKey(OrdersItem))
                        {
                            existingCustomer.Orders[OrdersItem] = OrdersQuantity;
                            existingCustomer.Bill += OrdersQuantity * shop[OrdersItem];
                        }
                        else
                        {
                            existingCustomer.Orders[OrdersItem] += OrdersQuantity;
                            existingCustomer.Bill += OrdersQuantity * shop[OrdersItem];
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var orderedList = customerList.OrderBy(c => c.Name);
            foreach (var customer in orderedList)
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var item in customer.Orders)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}"); 
            }

            var totalBill = orderedList.Sum(c => c.Bill);
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }       
    }
}