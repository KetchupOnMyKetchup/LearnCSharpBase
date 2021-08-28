using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part2.Projects.RockClimbingRoutes
{
    class RouteSln
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public VGradeSln Grade { get; set; }

        public int Points { get; set; }
    }
}
