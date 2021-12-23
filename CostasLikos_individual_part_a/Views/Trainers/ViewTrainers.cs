using Costas_Part_A;
using CostasLikos_individual_part_a.Enums;
using CostasLikos_individual_part_a.Views.HELPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Views.Trainers
{
    class ViewTrainers
    {
        public static void PrintTrainers(List<Trainer>trainers)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("     All trainers");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"    {"Id",-10}{"Firstname",-30}{"Lastname",-30}{"Subject",-30}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var tr in trainers)
            {
                Console.WriteLine($"    {tr.Id,-10}{tr.firstName,-30}{tr.lastName,-30}{tr.subject,-30}");
            }
            Console.ResetColor();
        }

        public static void CreateTrainer(List<Trainer> trainers)
        {
            int Id = (trainers[trainers.Count - 1].Id) + 1;

            string firstname = Helper.InputText("Give Trainers's firstname");

            string lastname = Helper.InputText("Give Trainers's lastname");
            
            string subject = Helper.InputText("Give Trainers's subject");

            Trainer obj = new Trainer(Id, firstname, lastname, subject);

            trainers.Add(obj);
        }

    }
}
