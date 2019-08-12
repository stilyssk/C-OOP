using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<IPlayer> listPlayers;

        public PlayerRepository()
        {
            this.listPlayers = new List<IPlayer>();
        }

        public int Count => this.listPlayers.Count;

        public IReadOnlyCollection<IPlayer> Players => listPlayers.AsReadOnly();

        public void Add(IPlayer player)
        {


            if (player==null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            if (listPlayers.Exists(x => x.Username == player.Username))
            {
                throw new ArgumentException($"Player {player.Username} already exists!");

            }
            listPlayers.Add(player);

        }

        public IPlayer Find(string username)
        {
            return listPlayers.Find(x => x.Username == username);
        }

        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            return listPlayers.Remove(player);
        }
    }
}
