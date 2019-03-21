using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts;
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return  this.name;
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new Exception("Name cannot be an empty string");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        private double Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be a negative number");
                }
                else
                {
                    this.money = value;
                }
            }
        }

        public void ByeProduct(Product product)
        {
            var index = bagOfProducts.FindIndex(x=>x == product);
            var price = bagOfProducts[index].Cost;
            var productName = bagOfProducts[index].Name;
            if (price > this.Money)
            {
                throw new ArgumentException($"{this.Money} can't afford {productName}");
            }
            else
            {
                bagOfProducts.Add(product);
            }
        }

    }
}
