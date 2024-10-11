using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class GroupFitnessProgram
    {
        public string Schedule { get; set; }
        public string GroupCapacity { get; set; }

        public GroupFitnessProgram(string schedule, string groupCapacity)
        {
            Schedule = schedule;
            GroupCapacity = groupCapacity;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
