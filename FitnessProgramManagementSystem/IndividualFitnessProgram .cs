using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class IndividualFitnessProgram
    {

        public string SubscriptionType { get; set; }
        public string needPersonalTrainer { get; set; }

        public IndividualFitnessProgram(string subscriptionType, string needPersonalTrainer)
        {
            SubscriptionType = subscriptionType;
            this.needPersonalTrainer = needPersonalTrainer;
        }

        public override string ToString()
        {
            return base.ToString();
        }

       

        //public override string ToString(string subscriptionType, string needPersonalTrainer, string fitnessProgramId, string title, string duration, string price)
        //{ 
        //    return 
        //}


    }
}
