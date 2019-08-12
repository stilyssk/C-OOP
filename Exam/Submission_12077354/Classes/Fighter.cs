using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Classes
{
    public class Fighter : BaseMachine,IFighter
    {
        private const  double healthPoints=200;
        public Fighter(string name, double attackPoints, double defensePoints) : base(name, attackPoints+50, defensePoints-25, healthPoints)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode == true)
            {
                this.AggressiveMode = false;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;

            }
            else
            {
                this.AggressiveMode = true;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            var onOff = "";
            if (this.AggressiveMode)
            {
                onOff = "ON";
            }
            else
            {
                onOff = "OFF";
            }
            sb.AppendLine($" *Aggressive: {onOff}");
            return sb.ToString().TrimEnd();
        }
    }
}
