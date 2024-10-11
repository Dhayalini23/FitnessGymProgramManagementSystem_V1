using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram 
    {
        internal string FitnessProgramId;
        internal string price;
        internal string title;

        public string TotalPrice { get; set; } 
        private string fitnessProgramId { get; set; }
        private string Title { get; set; }
        private string Duration { get; set; }
        private string Price { get; set; }
        public string duration { get; internal set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.Title = title;
            this.Duration = duration;
            this.Price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }

      
    }
}
