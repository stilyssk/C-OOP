using BorderControl.Interfaces;
using BorderControl.Interfaces.Child;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Classes.Chird
{
    public class Citizen : Townsman, ICitizen
    {
        private string name;
        private int age;
        private ITownsman townsmanData;

        public Citizen(string name, int age, ITownsman townsman):base(townsman.ID)
        {
            Name = name;
            Age = age;
            TownsmanData = townsman;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public ITownsman TownsmanData
        {
            get => townsmanData;
            set => townsmanData = value;
        }
        public string Name { get => name; set => name = value; }
    }
}
