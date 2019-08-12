using FoodShortage.Interfaces;

namespace FoodShortage.Classes
{
    public class Townsman : ITownsman
    {
        private string iD;

        public Townsman(string iD)
        {
            ID = iD;
        }

        public string ID
        {
            get => iD;
            set => iD = value;
        }
    }
}
