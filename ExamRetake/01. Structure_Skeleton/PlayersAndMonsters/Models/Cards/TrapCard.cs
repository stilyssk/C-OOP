using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        private const int damagePoints = 0;
        private const int healthPoints = 0;
        public TrapCard(string name) : base(name, damagePoints+120, healthPoints+5)
        {
        }
    }
}
