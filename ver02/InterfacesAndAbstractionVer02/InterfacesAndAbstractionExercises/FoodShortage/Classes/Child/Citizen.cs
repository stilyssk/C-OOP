using FoodShortage.Interfaces;
using FoodShortage.Interfaces.Child;

namespace FoodShortage.Classes.Child
{
    public class Citizen : ITownsman, ICitizen, IBirthdate, IPerson, IBuyer
    {
        private string name;
        private int age;
        private string date;
        private string iD;
        private int food;
        public Citizen(string name, int age, string iD, string date)
        {
            Name = name;
            Age = age;
            ID = iD;
            Date = date;
            Food = 0;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public string ID { get => iD; set => iD = value; }
        public int Food
        {
            get => food;
            set => food=value;
        }

        public void BuyFood()
        {
            Food+=10;
        }
    }
}
