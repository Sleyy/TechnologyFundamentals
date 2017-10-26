using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            string inputString = Console.ReadLine();
            List<string> teamsToDisband = new List<string>();
            int counter = 0;

            while (inputString != "end of assignment")
            {
                Team currentTeam = new Team();
                currentTeam.Members = new List<string>();
                currentTeam.Name = String.Empty;
                currentTeam.Creator = String.Empty;
                bool hasReadAllTeams = false;
                counter++;
                if (counter > numberOfTeams)
                {
                    hasReadAllTeams = true;

                }

                if (!inputString.Contains(">") && hasReadAllTeams == false)
                {
                    
                    var input = inputString
                        .Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    if (!teams.Any(x => x.Name == input[1]) && !teams.Any(y => y.Creator == input[0]))
                    {

                        currentTeam.Name = input[1];
                        currentTeam.Creator = input[0];
                        teams.Add(currentTeam);
                        Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
                    }
                    else if (teams.Any(x => x.Name == input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} was already created!");
                    }
                    else if (teams.Any(y => y.Creator == input[0]))
                    {
                        Console.WriteLine($"{input[0]} cannot create another team!");
                    }
                }
                else if (inputString.Contains(">"))
                {
                        var input = inputString
                        .Split(new string[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    if (teams.Any(x => x.Name == input[1]) && !teams.Any(x => x.Members.Contains(input[0])) && !teams.Any(x => x.Creator == input[0]))
                    {

                        currentTeam.Members.Add(input[0]);
                        foreach (var team in teams)
                        {
                            if (team.Name.Equals(input[1]))
                            {
                                team.Members.Add(input[0]);
                            }
                        }

                    }
                    else if (!teams.Any(x => x.Name == input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} does not exist!");
                    }
                    else if (teams.Any(x => x.Members.Contains(input[0])) || teams.Any(x => x.Creator == input[0]))
                    {
                        Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                    }
                }
                inputString = Console.ReadLine();
            }
            var filterdteams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (var team in filterdteams)
            {

                if (team.Members.Count != 0)
                {
                    Console.WriteLine($"{team.Name}\r\n- {team.Creator}\r\n-- {string.Join("\r\n-- ", team.Members.OrderBy(x => x))}");
                }
                else
                {

                    teamsToDisband.Add(team.Name);
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine($"{team}");
            }
        }
    }
}

