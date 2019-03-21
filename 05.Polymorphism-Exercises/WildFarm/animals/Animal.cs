using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals
{
    public abstract class Animal 
    {
        private string name;
        private double weight;
        private int foodEaten;

        public Animal(string name, double weight, int foodEaten)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }

        public int FoodEaten { get => foodEaten; set => foodEaten = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Name { get => name; set => name = value; }
    }
}
