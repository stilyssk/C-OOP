using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProduct;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProduct = new List<Product>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        private decimal Money
        {
            get => money; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        private List<Product> BagOfProduct { get => bagOfProduct; set => bagOfProduct = value; }

        public string AddProduct(Product newProduct)
        {
            if (newProduct.Cost>Money)
            {
                throw new ArgumentException($"{this.Name} can't afford {newProduct.Name}");
            }
            bagOfProduct.Add(newProduct);
            this.Money -= newProduct.Cost;
            return $"{this.Name} bought {newProduct.Name}";
        }
        public List<Product> getProductList()
        {
            return new List<Product>(bagOfProduct);
        }
    }
}
