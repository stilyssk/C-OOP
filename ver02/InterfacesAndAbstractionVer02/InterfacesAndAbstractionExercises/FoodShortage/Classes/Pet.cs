﻿using FoodShortage.Interfaces;
using FoodShortage.Interfaces.Child;

namespace FoodShortage.Classes
{
    public class Pet : IPet, IBirthdate
    {
        private string name;
        private string date;

        public Pet(string name, string date)
        {
            Name = name;
            Date = date;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Date
        {
            get => date;
            set => date = value;
        }
    }
}
