using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        //public Product()
        //{

        //}

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Cost
        {
            get
            {
                return this.cost;
            }
            set
            {

                this.cost = value;
            }
        }


    }
}
