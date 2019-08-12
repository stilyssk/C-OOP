using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Engineers;
using System.Text;

namespace MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers.Engineers
{
    public class Repair: IRepair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get => partName; set => partName = value; }
        public int HoursWorked { get => hoursWorked; set => hoursWorked = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("  " + $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}");

            return result.ToString();
        }
    }
}
