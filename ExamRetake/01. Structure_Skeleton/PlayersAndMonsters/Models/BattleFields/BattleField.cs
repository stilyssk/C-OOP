using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }
            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += 40;
                var temp = attackPlayer.CardRepository.Cards.ToList();
                for (int i = 0; i < temp.Count; i++)
                {
                    temp[i].DamagePoints += 30;
                }

                //•	If the player is a beginner, increase his health with 40 points and increase all damage points of all cards for the user with 30.

            }
            //•	Before the fight, both players get bonus health points from their deck.


            //•	Attacker attacks first and after that the enemy attacks.If one of the players is dead you should stop the fight.
            enemyPlayer.TakeDamage()
        }
    }
}
