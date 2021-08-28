using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp.Basics_Part2.Projects.RockClimbingRoutes
{
    public class RockClimbingSln
    {

        List<RockClimbingUserSln> users = new List<RockClimbingUserSln>();
        List<RouteSln> routes = new List<RouteSln>();

        public void Run()
        {
            Console.WriteLine("Welcome to the Vertical Ventures rock climbing scorekeeper!");

            SeedUsers();
            SeedRoutes();

            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            RockClimbingUserSln user = new RockClimbingUserSln
            {
                FirstName = name
            };

            users.Add(user);

            Console.WriteLine("Which route did you complete? Here are the choices, enter the #. Type stop to see leaderboard.");
            foreach (var route in routes)
            {
                Console.WriteLine($"Route {route.Id}, {route.Name}, {route.Points}");
            }

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int routeId)) break;
                RouteSln currRoute = routes.Where(x => x.Id == routeId).FirstOrDefault();
                user.Score += currRoute.Points;
                Console.WriteLine($"Your current score is now: {user.Score}");
            }

            PrintLeaderBoard();
        }

        private void SeedRoutes()
        {
            RouteSln route1 = new RouteSln
            {
                Id = 1,
                Grade = VGradeSln.V1,
                Points = 10,
                Name = "Beginner pink"
            };

            routes.Add(route1);

            RouteSln route2 = new RouteSln
            {
                Id = 2,
                Grade = VGradeSln.V4,
                Points = 45,
                Name = "On the way!"
            };

            routes.Add(route2);

            RouteSln route3 = new RouteSln
            {
                Id = 3,
                Grade = VGradeSln.V7,
                Points = 120,
                Name = "Send em high!"
            };

            routes.Add(route3);
        }

        private void SeedUsers()
        {
            RockClimbingUserSln user1 = new RockClimbingUserSln
            {
                FirstName = "Crystal",
                Score = 300
            };

            users.Add(user1);

            RockClimbingUserSln user2 = new RockClimbingUserSln
            {
                FirstName = "Viktor",
                Score = 150
            };

            users.Add(user2);

            RockClimbingUserSln user3 = new RockClimbingUserSln
            {
                FirstName = "Derek",
                Score = 200
            };

            users.Add(user3);

            RockClimbingUserSln user4 = new RockClimbingUserSln
            {
                FirstName = "Yogurt",
                Score = 0
            };

            users.Add(user4);
        }

        public void PrintLeaderBoard()
        {
            List<RockClimbingUserSln> orderedList = users.OrderByDescending(x => x.Score).ToList();

            int count = 1;

            Console.WriteLine("Current Leaderboard:");

            foreach (var user in orderedList)
            {
                Console.WriteLine($"{count++}. {user.FirstName} score is {user.Score}");
            }

            Console.WriteLine("Thanks for climbing!");
        }
    }
}
