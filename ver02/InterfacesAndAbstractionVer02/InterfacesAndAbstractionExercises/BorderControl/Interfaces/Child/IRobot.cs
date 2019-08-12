using BorderControl.Classes;

namespace BorderControl.Interfaces.Child
{
    public interface IRobot : ITownsman
    {
        string Model { get; set; }
        ITownsman Townsman { get; set; }
    }
}