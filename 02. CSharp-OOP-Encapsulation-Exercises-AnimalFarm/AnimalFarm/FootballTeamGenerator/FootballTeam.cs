using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class FootballTeam
    {
        private List<Player> listOfPlayers;
        private string name;
        private int rating;

        public FootballTeam(string name)
        {
            this.Name = name;
            this.listOfPlayers = new List<Player>();
        }

        private List<Player> ListOfPlayers
        {
            get => this.listOfPlayers;
            set => this.listOfPlayers = value;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        private int Rating
        {
            get => this.rating;
            set => this.rating = value;
        }

        private int CalculateRating()
        {
            double result = 0;

            foreach (var currentPlayer in this.ListOfPlayers)
            {
                result += currentPlayer.Stats.AverageStats;
            }
            if (result == 0)
            {
                this.rating = 0;
            }
            else
            {
                this.Rating = (int)Math.Round(result / this.ListOfPlayers.Count);

            }
            return this.Rating;
        }

        public void AddPlayer(Player newPlayer)
        {
            this.ListOfPlayers.Add(newPlayer);
        }

        public void RemovePlayer(string name)
        {
            try
            {
                int playerIndex = this.ListOfPlayers.FindIndex(x => x.Name == name);
                this.ListOfPlayers.RemoveAt(playerIndex);
            }
            catch (Exception)
            {

                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
            }
        }

        public string GetRating()
        {
            this.CalculateRating();
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Name} - {this.Rating}");
            return result.ToString().TrimEnd();
        }
    }
}
