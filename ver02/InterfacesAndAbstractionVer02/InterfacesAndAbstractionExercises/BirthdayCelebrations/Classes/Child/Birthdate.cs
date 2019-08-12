using BirthdayCelebrations.Interfaces.Child;

namespace BirthdayCelebrations.Classes.Child
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
