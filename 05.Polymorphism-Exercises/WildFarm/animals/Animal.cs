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
        private double weightIncrease;

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public int FoodEaten { get => foodEaten; set => foodEaten = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Name { get => name; set => name = value; }
        public virtual double WeightIncrease { get => weightIncrease; set => weightIncrease = value; }

        public abstract string Speak();

        public abstract string AddFood(string food, int count);
        //{
        //    this.FoodEaten += count;
        //    this.Weight += count * this.WeightIncrease;
        //    this.ToString(); 
            
        //}
  
    }
}
