namespace FoodShortage.Interfaces.Child
{
    public interface IRobot : ITownsman
    {
        string Model { get; set; }
    }
}