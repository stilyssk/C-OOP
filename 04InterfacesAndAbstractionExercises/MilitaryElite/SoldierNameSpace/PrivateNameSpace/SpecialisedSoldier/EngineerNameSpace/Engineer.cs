using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.SoldierNameSpace.PrivateNameSpace.SpecialisedSoldier.EngineerNameSpace
{
    public class Engineer : IRepair
    {
        private List<IRepair> repairs;
        private IRepair repair;

        private string partName;
        private int hoursWorked;

        public string PartName { get => this.partName; set { this.partName = value; } }

        public int HoursWorked { get => this.hoursWorked; set { this.hoursWorked = value; } }

        public IRepair Repair
        {
            get
            {
                return this.repair;
            }
            set
            {
                this.repair = value;
            }
        }
    }
}
