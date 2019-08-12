namespace Ferrari
{
    public interface IFerrari
    {
        string CarModel { get; set; }
        string CarName { get; set; }
        string DriverName { get; set; }

        string Break();
        string GasPedal();
        string ToString();
    }
}