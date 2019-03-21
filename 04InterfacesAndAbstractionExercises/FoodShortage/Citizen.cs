namespace BorderControl
{
    using System;

    public class Citizen : ICitizens, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private DateTime birthdate;
        private int food;

        public Citizen( string name, int age, string id, DateTime birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                this.age = value;
            }
        }

        public string Id
        {
            get => this.id;
            set
            {
                this.id = value;
            }
        }

        public DateTime Birthdate
        {
            get => this.birthdate;
            set
            {
                this.birthdate = value;
            }
        }

        public int Food { get => this.food; set { this.food = value; } }

        public int BuyFood()
        {
            return 10;
        }
    }
}
