using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            this.products.Add(product);
            this.Money -= product.Price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                var val = value.Trim();
                if (string.IsNullOrEmpty(val))
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }
        
        public List<string> GetProducts()
        {
            var result = new List<string>();
            foreach (var product in products)
            {
                result.Add(product.ProductName);
            }
            return result;
        }
    }
}
