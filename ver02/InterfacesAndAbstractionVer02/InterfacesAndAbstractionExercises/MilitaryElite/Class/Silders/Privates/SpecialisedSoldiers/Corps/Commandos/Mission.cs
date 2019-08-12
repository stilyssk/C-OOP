using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Commandos;
using System;
using System.Text;

namespace MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers.Commandos
{
    public class Mission : IMission
    {
        private string codeName;
        private string stateName;

        public Mission(string codeName, string stateName)
        {
            CodeName = codeName;
            StateName = stateName;
        }

        public string CodeName
        {
            get => codeName;
            set
            {

                codeName = value;
            }
        }

        public string StateName
        {
            get => stateName;
            set
            {
                var flagExist = Enum.TryParse(typeof(state), value, out object result);
                if (!flagExist)
                {
                    throw new ArgumentException("invalid mission state");
                }
                stateName = value;
            }
        }

        private enum state
        {
            inProgress,
            Finished
        }

        public void CompleteMission()
        {
            StateName = "Finished";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

                result.AppendLine("  " + $"Code Name: {CodeName} State: {StateName}");

            

            return result.ToString().TrimEnd();
        }
    }
}
