using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp.Basics_Part2.Projects.WaterTracker
{
    public class DaySln
    {
        public DaySln()
        {
            Date = DateTime.Today;
            WaterEntries = new List<int>();
        }

        public DateTime Date { get; set; }
        public int TotalWater => WaterEntries.Sum();
        public List<int> WaterEntries { get; set; }

        public void AddWaterEntry(int waterEntry)
        {
            WaterEntries.Add(waterEntry);
        }
    }
}
