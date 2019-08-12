using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Classes
{
    public class Pilot : IPilot
    {
        private string pilotNameExeption = "Pilot name cannot be null or empty string.";
        const string AddMachineExeption = "Null machine cannot be added to the pilot.";

        private string name;
        private List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }
        public string Name
        {
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(pilotNameExeption);
                }
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }


        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException(AddMachineExeption);
            }
            this.machines.Add(machine);
        }

        public string Report()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {this.machines.Count} machines");
            for (int i = 0; i < this.machines.Count; i++)
            {

                sb.AppendLine(machines[i].ToString());


            }
            return sb.ToString().TrimEnd();
        }
    }
}
