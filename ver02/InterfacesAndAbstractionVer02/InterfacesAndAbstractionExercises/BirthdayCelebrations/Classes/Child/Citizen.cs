using BirthdayCelebrations.Classes;
using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Interfaces.Child;

namespace BorderControl.Classes.Chird
{
    public class Citizen : Townsman, ICitizen,IBirthdate
    {
        private string name;
        private int age;
        private ITownsman townsmanData;
        private string date;
        public Citizen(string name, int age, ITownsman townsman,string date):base(townsman.ID)
        {
            Name = name;
            Age = age;
            TownsmanData = townsman;
            Date = date;
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
        public string Date { get => date; set => date = value; }
    }
}
