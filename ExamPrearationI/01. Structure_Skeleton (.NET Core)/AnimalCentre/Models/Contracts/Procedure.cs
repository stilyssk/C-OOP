namespace AnimalCentre.Models.Contracts
{
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    public abstract class Procedure : IProcedure
    {

        protected ICollection<IAnimal> ProcedureHistory;

        public Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>();
        }

        public abstract void DoService(IAnimal animal, int procedureTime);

        public string History()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.GetType().Name}");

            foreach (var procedure in ProcedureHistory)
            {
                result.AppendLine($"    - {procedure.Name} - Happiness: {procedure.Happiness} - Energy: {procedure.Energy}");
            }
            return result.ToString();
        }

    }
}
