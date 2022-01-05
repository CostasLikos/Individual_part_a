using Costas_Part_A;
using CostasLikos_individual_part_a.DataBase;
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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            int Id = (trainers[trainers.Count - 1].Id) + 1;

            string firstname = Helper.InputText("PLEASE INPUT TRAINER'S FIRST NAME");

            string lastname = Helper.InputText("PLEASE INPUT TRAINER'S SURNAME");
            
            string subject = Helper.InputText("PLEASE INPUT TRAINER'S SUBJECT");

            Trainer obj = new Trainer(Id, firstname, lastname, subject);

            trainers.Add(obj);
            Console.WriteLine("TRAINER CREATED");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"   \nID: {Id}   \nFULL NAME: {firstname} {lastname}   \nSUBJECT: {subject}");
            MyDatabase db = new MyDatabase();
            Console.ResetColor();
        }

    }
}
