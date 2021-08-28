using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp.Basics_Part2.Projects.WaterTracker
{
    public class UserSln
    {
        public UserSln(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            WaterEntries = new List<DaySln>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<DaySln> WaterEntries { get; set; }
        public int PercentOfTodaysGoal => WaterEntries.Where(x => x.Date == DateTime.Today).FirstOrDefault().TotalWater * 100 / WaterGoal;
        public int WaterGoal { get; set; }
        public int DaysAchieveWaterGoal { get; set; } // will be utilized in future when DB is added

        public void AddWaterEntry(DaySln day)
        {
            WaterEntries.Add(day);
        }
    }
}
