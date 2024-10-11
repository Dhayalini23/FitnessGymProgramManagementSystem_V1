using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        private static string option;

        static void Main(string[] args)
        {
            FitnessProgramManager manager1 = new FitnessProgramManager();

            bool exit=false;
            while (!exit) 
            {
                Console.Clear();
                Console.WriteLine("FitnessProgram Management System:");
                Console.WriteLine("1. Add a FitnessProgram");
                Console.WriteLine("2. View All FitnessPrograms");
                Console.WriteLine("3. Update a FitnessProgram");
                Console.WriteLine("4. Delete a FitnessProgram");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");
                string option= Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                    Console.WriteLine("Add a FitnessProgram");
                    CreateFitnessProgram(manager1);
                    break;
                case "2":
                    Console.WriteLine(" View All FitnessProgram");
                    manager1.ReadFitnessPrograms();
                    break;
                case "3":
                    Console.WriteLine("Update a FitnessProgram");
                    UpdateFitnessProgram(manager1);
                    break;
                case "4":
                    Console.WriteLine("Delete a FitnessProgram\"");
                    DeleteFitnessProgram(manager1);
                    break;
                case "5":
                    Console.WriteLine(" Exit");
                   exit = true;
                    break;
            }
            if(!exit){
                Console.WriteLine("Choose an option: 1");

            }

        }

        private static void CreateFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID");
            string ID = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Title");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Duration");
            string Duration = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Price");
            string Price = Console.ReadLine();

            Console.WriteLine("FitnessProgram added successfully.");
          
            //manager.CreateFitnessProgram(ID, Title, Duration, Price);
        }
        private static void UpdateFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID to update");
            string ID = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Title");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Duration");
            string Duration = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Price");
            string Price = Console.ReadLine();

            Console.WriteLine("FitnessProgram Updated successfully.");

            manager.UpdateFitnessProgram(ID, Title, Duration, Price);
        }

        private static void DeleteFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID to deleted");
            string ID = Console.ReadLine();

   

            Console.WriteLine("FitnessProgram deleted successfully.");

            manager.DeleteFitnessProgram(ID);
        }
    }
}
