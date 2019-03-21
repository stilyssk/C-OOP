namespace BorderControl
{

    public class Citizen : ICitizens, IRobots
    {
        private string name;
        private int age;
        private string id;
        private string model;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public Citizen(string model, string id)
        {
            this.Model = model;
            this.Id = id;
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

        public string Model
        {
            get => this.model;
            set
            {
                this.model = value;
            }
        }

    }
}
