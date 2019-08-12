namespace FoodShortage.Interfaces.Child
{
    public interface ICitizen : ITownsman
    {
        string Name { get; set; }
        int Age { get; set; }
    }

}