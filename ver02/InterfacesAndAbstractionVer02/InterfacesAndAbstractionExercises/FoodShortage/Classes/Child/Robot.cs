using FoodShortage.Interfaces;
using FoodShortage.Interfaces.Child;

namespace FoodShortage.Classes.Child
{
    public class Robot : ITownsman, IRobot
    {
        private string model;
        private string iD;

        public Robot(string model, string iD)
        {
            Model = model;
            ID = iD;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }
        public string ID
        {
            get => iD;
            set => iD = value;
        }
    }
}
