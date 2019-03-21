using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite2
{
    public class Repair : IRepair
    {
        private string partName;
        private int hoursWorked;

        public string PartName
        {
            get
            {
                return this.partName;
            }
            set
            {
                this.partName = value;
            }
        }

        public int HoursWorked
        {
            get
            {
                return this.hoursWorked;
            }
            set
            {
                this.hoursWorked = value;
            }
        }


    }
}
