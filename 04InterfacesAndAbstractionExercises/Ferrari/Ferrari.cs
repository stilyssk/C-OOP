namespace Ferrari
{
    public class Ferrari : IFerrari
    {
        private string carМanufacturer;
        private string carModel;
        private string driver;

        public Ferrari(string driver)
        {
            this.carModel = "488-Spider";
            this.Driver = driver;
        }

        public string CarМanufacturer { get => this.carМanufacturer; set { this.carМanufacturer = value; } }

        public string CarModel { get => this.carModel; set { this.carModel = value; } }

        public string Driver { get => this.driver; set { this.driver = value; } }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string PushTheGasPedal()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.CarModel}/{this.Brakes()}/{this.PushTheGasPedal()}/{this.Driver}";
        }
    }
}
