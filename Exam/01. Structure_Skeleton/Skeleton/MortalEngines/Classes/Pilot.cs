using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Classes
{
    public class Pilot : BaseMachine, IPilot
    {
        private string pilotNameExeption = "Pilot name cannot be null or empty string.";
        const string AddMachineExeption = "Null machine cannot be added to the pilot.";
        private const double attackPointsPilot=0;
        private const double defensePointsPilot=0;
        private const double healthPointsPilot=0;
        private List<IMachine> machines;
        public Pilot(string name) : base(name, attackPointsPilot, defensePointsPilot, healthPointsPilot)
        {
            this.machines = new List<IMachine>();
        }
        public override string Name
        {
            protected  set
            {
                if (string.IsNullOrWhiteSpace(value) && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(pilotNameExeption);
                }
                base.Name = value;
            }
            get
            {
                return base.Name;
            }
        }
        private List<IMachine> Machines
        {
            get
            {
                return this.machines;
            }
            set
            {
                this.machines = value;
            }
        }
        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException(AddMachineExeption);
            }
            this.Machines.Add(machine);
        }

        public string Report()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {this.Machines.Count} machines");
            for (int i = 0; i < this.machines.Count; i++)
            {
                sb.AppendLine($"- {machines[i].Name}");
                sb.AppendLine($" *Type: {machines[i].GetType().Name}");
                sb.AppendLine($" *Health: {machines[i].HealthPoints}");
                sb.AppendLine($" *Attack: {machines[i].AttackPoints}");
                sb.AppendLine($" *Defense: {machines[i].DefensePoints}");
                foreach (var targetName in machines[i].Targets)
                {
                    sb.AppendLine($" *Targets: {targetName}");

                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
