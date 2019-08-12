using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Contracts
{
    public class Animal : IAnimal
    {
        private string name;
        private int happiness = 0;
        private int energy = 0;
        private int procedureTime = 0;
        private string owner;
        private bool isAdopt;
        private bool isChipped;
        private bool isVaccinated;

        public Animal()
        {
        }

        public Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = "Centre";
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }
        public int Happiness
        {
            get => this.happiness;
            set
            {
                int newHappiness = this.happiness + value;
                if (newHappiness > 100 || (newHappiness < 0))
                {
                    throw new ArgumentException("Invalid happiness");
                }
                this.happiness = newHappiness;
            }
        }
        public int Energy
        {
            get => this.energy;
            set
            {
                int newEnergy = this.energy + value;
                if ((newEnergy) > 100 || (newEnergy < 0))
                {
                    throw new ArgumentException("Invalid energy");
                }
                this.energy = newEnergy;
            }
        }
        public int ProcedureTime
        {
            get => this.procedureTime;
            set
            {
                if (this.procedureTime <value)
                {
                    throw new ArgumentException($"Animal doesn't have enough procedure time");
                }
                this.procedureTime += value;
            }
        }
        public string Owner
        {
            get => this.owner;
            set => this.owner = value;
        }
        public bool IsAdopt
        {
            get => this.isAdopt;
            set => this.isAdopt = value;
        }
        public bool IsChipped
        {
            get => this.isChipped;
            set => this.isChipped = value;
        }
        public bool IsVaccinated
        {
            get => this.isVaccinated;
            set => this.isVaccinated = value;
        }


    }
}
