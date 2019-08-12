using FoodShortage.Interfaces.Child;

namespace FoodShortage.Classes.Child
{
    public class Birthdate : IBirthdate
    {
        private string date;

        public Birthdate(string date)
        {
            Date = date;
        }

        public string Date { get => date; set => date = value; }

    }
}
