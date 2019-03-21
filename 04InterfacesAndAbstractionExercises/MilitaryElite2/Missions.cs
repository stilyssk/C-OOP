using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite2
{
    public class Missions : IMissions
    {
        private string codeName;
        private enum state { inProgress , Finished }
        private string states;

        public string CondeName
        {
            get;
            set;
        }

        public string States
        {
            get
            {
                return this.states;
            }
            set
            {
                if (value == nameof(state.Finished))
                {
                    this.states = value;
                }else if(value == nameof(state.Finished))
                {
                    this.states = value;
                }
                else
                {
                    throw new ArgumentException("test");
                }
            }
        }

        public bool CompleteMission()
        {
            return false;
        }
    }
}
