using FinalWork.DAL;
using FinalWork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork
{
    public class TeamsInterface
    {
        public static void Add(FWDbContext context)
        {
            var teams = new List<Team>() 
            {
                new Team()
                {
                    Name = "RealMadrid",
                    Wins = 10,
                    Defeats = 0,
                    Draws = 5,
                },
                new Team()
                {
                    Name = "Barcelona",
                    Wins = 15,
                    Defeats = 1,
                    Draws = 3,
                },
                new Team()
                {
                    Name = "Arcenal",
                    Wins = 5,
                    Defeats = 9,
                    Draws = 4,
                },
                new Team()
                {
                    Name = "MU",
                    Wins = 15,
                    Defeats = 1,
                    Draws = 3,
                },
                new Team()
                {
                    Name = "MC",
                    Wins = 20,
                    Defeats = 0,
                    Draws = 0,
                }
            };
            foreach (var team in teams)
            {
                context.Add(team);
            }
        }

        public static void Show(FWDbContext context)
        {
            var teams = context.Teams.ToList();
            int counter = 1;
            foreach (var team in teams)
            {
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~{counter}~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Name: {team.Name} ;\nWins:{team.Wins} ;\nDefeats:{team.Defeats} ;\nDraws: {team.Draws}");
                counter++;
            }
        }
    }
}
