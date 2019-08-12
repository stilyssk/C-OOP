using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, FootballTeam> footballTeams = new Dictionary<string, FootballTeam>();
            while (true)
            {
                var playerName = string.Empty;
                var teamName = string.Empty;
                var inputCommand = Console.ReadLine()
                    .Split(new[] { ';' })
                    .ToList();
                if (inputCommand[0] == "END")
                {
                    break;
                }
                try
                {
                    teamName = inputCommand[1];

                    switch (inputCommand[0])
                    {
                        case "Team":
                            FootballTeam footballTeam = new FootballTeam(teamName);
                            footballTeams.Add(teamName, footballTeam);
                            break;
                        case "Add":
                            var endurance = int.Parse(inputCommand[3]);
                            var sprint = int.Parse(inputCommand[4]);
                            var dribble = int.Parse(inputCommand[5]);
                            var passing = int.Parse(inputCommand[6]);
                            var shooting = int.Parse(inputCommand[7]);
                            playerName = inputCommand[2];
                            Stats playerStats = new Stats(endurance, sprint, dribble, passing, shooting);
                            Player newPlayer = new Player(playerName, playerStats);
                            teamName = inputCommand[1];
                            if (footballTeams.ContainsKey(teamName))
                            {
                            footballTeams[teamName].AddPlayer(newPlayer);
                            }
                            else
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }
                            break;
                        case "Remove":
                            teamName = inputCommand[1];
                            playerName = inputCommand[2];
                            footballTeams[teamName].RemovePlayer(playerName);
                            break;
                        case "Rating":
                            teamName = inputCommand[1];
                            if (footballTeams.ContainsKey(teamName))
                            {
                                Console.WriteLine(footballTeams[teamName].GetRating());
                            }
                            else
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }
                            
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
