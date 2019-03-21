namespace BorderControl
{
    using System;

    public class Citizen : ICitizens, IRobots, IPet
    {
        private string typeSubject;
        private string name;
        private int age;
        private string id;
        private string model;
        private DateTime birthdate;

        public Citizen(string typeSubject, string name, int age, string id, DateTime birthdate)
        {
            this.TypeSubject = typeSubject;
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public Citizen(string typeSubject, string model, string id)
        {
            this.TypeSubject = typeSubject;
            this.Model = model;
            this.Id = id;
        }

        public Citizen(string typeSubject, string name, DateTime birthdate)
        {
            this.TypeSubject = typeSubject;
            this.Name = name;
            this.Birthdate = birthdate;
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

        public DateTime Birthdate
        {
            get => this.birthdate;
            set
            {
                this.birthdate = value;
            }
        }

        public string TypeSubject
        {
            get => this.typeSubject;
            set
            {
                this.typeSubject = value;
            }
        }

        public string CheckId()
        {
            throw new NotImplementedException();
        }
    }
}
