using FoodShortage.Interfaces.Child;

namespace FoodShortage.Classes
{

    public class Rebel : IPerson, IRebel, IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Group { get => group; set => group = value; }
        public int Food
        {
            get => food;
            set => food = value;
        }

        public void BuyFood()
        {
            Food+=5;
        }
    }
}
