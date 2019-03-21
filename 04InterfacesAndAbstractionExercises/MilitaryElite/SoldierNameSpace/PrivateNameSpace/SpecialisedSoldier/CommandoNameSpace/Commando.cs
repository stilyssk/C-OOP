using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.SoldierNameSpace.PrivateNameSpace.SpecialisedSoldier.CommandoNameSpace
{
    public class Commando 
    {
        private string codeName;
        private string state;
        private enum states  { inProgress , Finished };

        public string CodeName { get => this.codeName; set { this.codeName = value; } }
        public string State
        { 
            set
            {
                
                if (value==nameof(states.inProgress))
                {
                    this.state = value;

                }
                else if (value == nameof(states.Finished))
                {
                    this.state = value;

                }
                else
                {
                    throw new ArgumentException("Incorect Corps");
                }
            }
        }

        public bool CompleteMission()
        {
            throw new NotImplementedException();
        }
    }
}
