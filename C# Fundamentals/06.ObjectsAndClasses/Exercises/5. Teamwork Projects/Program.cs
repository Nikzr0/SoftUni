﻿using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    public string CreatorOfTeam { get; set; } // Team Creator
    public string NameOfTeam { get; set; } // The name of the team!
    public List<string> Members { get; set; } // All members of the team
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());// HOW MANY TEAMS
        List<Team> teams = new List<Team>();// LIST OF ALL TEAMS  Creator name + Team name + All members
        List<string> exeptions = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("-");
            string creator = input[0];// CREATOR
            string teamName = input[1];// THE NAME OF THE TEAM

            if (teams.Any(x => x.NameOfTeam == teamName))
            {
                exeptions.Add($"Team {teamName} was already created!");
            }
            else if (teams.Any(x => x.CreatorOfTeam == creator))
            {
                exeptions.Add($"{creator} cannot create another team!");
            }
            else
            {
                Team t = new Team();
                t.NameOfTeam = teamName;
                t.CreatorOfTeam = creator;
                t.Members = new List<string>();
                teams.Add(t);
                exeptions.Add($"Team {teamName} has been created by {creator}!");
            }
        }

        string inputInfo = Console.ReadLine();
        while (inputInfo != "end of assignment")
        {
            string[] commands = inputInfo.Split("->");
            string user = commands[0];
            string teamToJoin = commands[1];

            if (!teams.Any(x => x.NameOfTeam == teamToJoin))
            {
                exeptions.Add($"Team {teamToJoin} does not exist!");
            }
            else if (teams.Any(x => x.Members.Contains(user)) || teams.Any(x => x.CreatorOfTeam == user))
            {
                exeptions.Add($"Member {user} cannot join team {teamToJoin}!");
            }
            else
            {
                Team currentTeam = teams.First(x => x.NameOfTeam == teamToJoin);
                currentTeam.Members.Add(user);
            }

            inputInfo = Console.ReadLine(); // To prevent a loop in the progra!!
        }

        var finalTeams = teams.Where(x => x.Members.Count > 0);
        var disbandedTeams = teams.Where(x => x.Members.Count == 0);

        // FINAL TEAMS
        Console.WriteLine();
        Console.WriteLine();
        foreach (var item in exeptions)
        {
            Console.WriteLine(item);
        }

        foreach (Team item in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.NameOfTeam))
        {
            if (item.Members.Count > 0)
            {
                Console.WriteLine($"{item.NameOfTeam}");
                Console.WriteLine($"- {item.CreatorOfTeam}"); // CREATOR

                foreach (string member in item.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}"); // ALL MEMBERS
                }
            }
        }

        Console.WriteLine("Teams to disband:");
        if (disbandedTeams != null)
        {
            foreach (Team item in disbandedTeams.OrderBy(x => x.NameOfTeam))
            {
                Console.WriteLine($"{item.NameOfTeam}");
            }
        }
    }
}