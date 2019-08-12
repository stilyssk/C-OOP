using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Classes
{
    public class Tank : BaseMachine, ITank
    {
        private const double healthPoints = 100;


        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints-40, defensePoints+30, healthPoints)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            else
            {
                this.DefenseMode = true;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            var onOff = "";
            if (this.DefenseMode)
            {
                onOff = "ON";
            }
            else
            {
                onOff = "OFF";
            }
            sb.AppendLine($" *Defense: {onOff}");
            return sb.ToString();
        }
    }
}
