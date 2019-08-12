using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Classes
{
    public abstract class BaseMachine : IMachine
    {
        private string nameExeption = "Machine name cannot be null or empty.";
        private string pilotCannotBeNull = "Pilot cannot be null.";
        private string targetCannotBeNull = "Target cannot be null";
        private string name;
        private IPilot pilot;

        protected BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameExeption);
                }
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(pilotCannotBeNull);
                }
                this.pilot = value;
            }
        }
        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }


        public double DefensePoints { get; protected set; }

        public IList<string> Targets { get; private set; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException(targetCannotBeNull);
            }
            target.HealthPoints -= (this.AttackPoints - target.DefensePoints);
            if (target.DefensePoints < 0)
            {
                target.HealthPoints = 0;
                Targets.Add(target.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints:F2}");
            sb.AppendLine($" *Attack: {this.AttackPoints:F2}");
            sb.AppendLine($" *Defense: {this.DefensePoints:F2}");

            sb.Append($" *Targets: ");

            if (Targets.Count == 0)

            {
                sb.Append("None");

            }
            else
            {
                sb.AppendLine($"{string.Join(",", this.Targets)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
