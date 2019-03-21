namespace Ferrari
{
    public interface IFerrari
    {
        string CarМanufacturer { get; set; }

        string CarModel { get; set; }

        string Driver { get; set; }

        string Brakes();

        string PushTheGasPedal();
    }
}
