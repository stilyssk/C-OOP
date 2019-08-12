using BirthdayCelebrations.Classes;
using BirthdayCelebrations.Interfaces;
using BorderControl.Interfaces.Child;

namespace BorderControl.Classes.Chird
{
    public class Robot : Townsman, IRobot
    {
        private string model;
        private ITownsman townsman;

        public Robot(string model, ITownsman townsman) : base(townsman.ID)
        {
            Model = model;
            Townsman = townsman;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }
        public ITownsman Townsman
        {
            get => townsman;
            set => townsman = value;
        }
    }
}
