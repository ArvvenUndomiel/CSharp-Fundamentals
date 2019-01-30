using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.price = value;
            }
        }
    }
}
