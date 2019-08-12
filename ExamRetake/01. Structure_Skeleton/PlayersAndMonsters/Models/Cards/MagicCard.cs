using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class MagicCard : Card
    {
        private const int damagePoints = 0;
        private const int healthPoints = 0;
        public MagicCard(string name) : base(name, damagePoints+5, healthPoints+80)
        {
        }
    }
}
