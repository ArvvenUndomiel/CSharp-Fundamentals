using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class CommandProcessor
    {
        public string Process (Person person, Product product)
        {
            if (person.Money >= product.Price)
            {
                person.BuyProduct(product);
                return $"{person.Name} bought {product.ProductName}";
            }
            else
            {
                return $"{person.Name} can't afford {product.ProductName}";
            }
        }

        public string[] Parse (string fullcommand)
        {
            return fullcommand.Split(' ');
        }
    }
}
