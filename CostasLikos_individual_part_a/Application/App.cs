using Costas_Part_A;
using CostasLikos_individual_part_a.Controllers;
using CostasLikos_individual_part_a.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Application
{
    class App
    {
        
        public static void Run()
        {
            MyDatabase db = new MyDatabase();
            string input;

            Views.HELPER.Helper.ViewAllOptionsMenu();


            do
            {
               
                input = Console.ReadLine();
                switch (input)
                {
                    case "0": Console.WriteLine("skata"); break;
                    case "1":Views.Courses.ViewCourse.PrintCourse(db.courses);break;
                    case "2": Views.Assignments.ViewAssignments.CreateAssignment(db.assignments); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                        break;
                        
                }
                

            } while (input != "0");
            Console.ResetColor();





        }
    }
    
}
