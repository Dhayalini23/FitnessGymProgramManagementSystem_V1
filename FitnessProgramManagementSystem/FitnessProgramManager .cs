using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {

        public List<FitnessProgram> FitnessPrograms;

        public FitnessProgramManager()
        {
            FitnessPrograms = new List<FitnessProgram>();
        }

        public void CreateFitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            FitnessProgram program = new FitnessProgram(fitnessProgramId, title, duration, price);
            FitnessPrograms.Add(program);
            Console.WriteLine("Program Created Successfully");
        }

        public void ReadFitnessPrograms()
        {
            if (FitnessPrograms.Count == 0)
            {
                Console.WriteLine("No programs available");
            }
            else
            {
                Console.WriteLine("Programs lists: ");
                foreach (var program in FitnessPrograms)
                {
                    Console.WriteLine(program.ToString());
                }
            }
        }

        public void UpdateFitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            var findedFitnessProgram = FitnessPrograms.Find(p => p.FitnessProgramId == fitnessProgramId);
            if (findedFitnessProgram == null)
            {
                findedFitnessProgram.title = title;
                findedFitnessProgram.duration = duration;
                findedFitnessProgram.price = price;

                Console.WriteLine("Program Update Successfully");
            }
            else
            {
                Console.WriteLine("No program Found");
            }
        }


        public void DeleteFitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            var findedFitnessProgram = FitnessPrograms.Find(p => p.FitnessProgramId == fitnessProgramId);
            if (findedFitnessProgram == null)
            {

                FitnessPrograms.Remove(findedFitnessProgram);
                Console.WriteLine("Program Update Successfully");
            }
            else
            {
                Console.WriteLine("No program Found");
            }
        }

        internal void DeleteFitnessProgram(string iD)
        {
            throw new NotImplementedException();
        }

        public void ValidateFitnessProgramPrice()
        {
            string price;
            while (true)
            {
               Console.WriteLine(price = Console.ReadLine());
                if(price == null)
            {
                    price = Console.ReadLine();
                }
            }
        }
    }
}
