
namespace Ferrari
{
    public class Ferrari : IFerrari
    {
        private string carName;
        private string carModel;
        private string driverName;
        public Ferrari(string driverName)
        {
            CarModel = "488-Spider";
            CarName = "Ferrari";
            DriverName = driverName;
        }

        public string CarName
        {
            get => carName;
            set => carName = value;
        }
        public string CarModel
        {
            get => carModel;
            set => carModel = value;
        }
        public string DriverName
        {
            get => driverName;
            set => driverName = value;
        }

        public string Break()
        {
            return "Brakes!";
        }
        public string GasPedal()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{CarModel}/{Break()}/{GasPedal()}/{DriverName}";
        }
    }
}
