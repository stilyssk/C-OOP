namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string iD;
        private string birthdate;
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Citizen(string name, int age, string iD, string birthdate) : this(name, age)
        {
            Id = iD;
            Birthdate = birthdate;
        }

        public string Name
        {

            get => name;
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }

        public string Id
        {
            get => iD;
            set => iD = value;
        }
        public string Birthdate
        {
            get => birthdate;
            set => birthdate = value;
        }
    }
}
