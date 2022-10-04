using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace Ex05.FootballTeamGenerator
{
    public class Team
    {
        private int numberOfPlayers;
        private string teamName;
        private double teamRating; // avarage skill level of the players

        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set
            {
                numberOfPlayers = value;
            }
        }

        public string TeamName
        {
            get { return teamName; }
            set
            {
                teamName = value;
            }
        }
        public double TeamRating
        {
            get { return teamRating; }
            set
            {
                teamRating = value;
            }
        }
        public List<Player> Players { get; set; }
        public Team(string teamName)
        {
            TeamName = teamName;
            Players = new List<Player>();
        }
        public Team(int numberOfPlayers, string teamName, string teamRating)
        {
            NumberOfPlayers = numberOfPlayers;
            TeamName = teamName;
            TeamRating = GetTeamRating(Players);
            Players = new List<Player>();
        }

        public double GetTeamRating(List<Player> players)
        {
            double result = 0;
            foreach (var player in players)
            {
                result += player.PlayerSkillLevel(player.Endurance, player.Sprint, player.Dribble, player.Passing, player.Shooting);
            }
            result /= players.Count;

            return result;
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }
    }

    public class Player
    {
        private string playerName;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("A name should not be empty.");
                }
                playerName = value;
            }
        }
        public int Endurance
        {
            get => endurance;
            set
            {
                if (value > 100)
                {
                    throw new Exception($"Endurance should be between 0 and 100.");
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            set
            {
                if (value > 100)
                {
                    throw new Exception($"Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble;
            set
            {
                if (value > 100)
                {
                    throw new Exception($"Dribble should be between 0 and 100.");
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get => passing;
            set
            {
                if (value > 100)
                {
                    throw new Exception($"Passing should be between 0 and 100.");
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting;
            set
            {
                if (value > 100)
                {
                    throw new Exception($"Shooting should be between 0 and 100.");
                }
                shooting = value;
            }
        }
        public Player(string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            PlayerName = playerName;

            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int PlayerSkillLevel(int endurance, int sprint, int dribble, int passing, int shooting)
            => (int)Math.Ceiling((double)(endurance + sprint + dribble + passing + shooting) / 5);
    }
    public class Program
    {
        static void Main()
        {
            string teamName = Console.ReadLine().Split(";")[1];
            Team team = new Team(teamName);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split(";");
                switch (command[0])
                {
                    case "Add":
                        try
                        {
                            team.AddPlayer(new Player(command[2], int.Parse(command[3]), int.Parse(command[4]), int.Parse(command[5]), int.Parse(command[6]), int.Parse(command[7])));

                            if (team.TeamName != command[1])
                            {
                                Console.WriteLine($"Team {command[1]} does not exist.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "Remove":
                        if (team.Players.Select(x => x.PlayerName).Contains(command[2]))
                        {
                            team.RemovePlayer(team.Players.Where(x => x.PlayerName == command[2]).FirstOrDefault());
                        }
                        else
                        {
                            Console.WriteLine($"Player {command[2]} is not in  {teamName} team.");
                        }
                        break;

                    case "Rating":
                        if (team.Players.Count == 0)
                        {
                            Console.WriteLine($"{command[1]} - 0");

                            if (team.TeamName != command[1])
                            {
                                Console.WriteLine($"Team {command[1]} does not exist.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} - {team.GetTeamRating(team.Players)}");
                        }
                        break;
                }
            }
        }
    }
}