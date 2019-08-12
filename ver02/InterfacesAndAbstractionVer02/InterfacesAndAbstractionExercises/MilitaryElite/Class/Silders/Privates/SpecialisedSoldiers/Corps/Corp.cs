using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers;
using System;

namespace MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers
{
    public class Corp : ICorp
    {
        private string corpName;

        public Corp(string corpName)
        {
            CorpName = corpName;
        }

        private enum corp
        {
            Airforces, Marines
        }
        public string CorpName
        {
            get => corpName;
            set
            {
                var flagExist = Enum.TryParse(typeof(corp), value, out object result);
                if (!flagExist)
                {
                    throw new ArgumentException("Uncorrect Corps");
                }
                corpName = value;
            }
        }

    }
}
