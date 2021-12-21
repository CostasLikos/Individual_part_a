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
            const int first = -40;
            const int second = -40;
            const int third = -40;
            const int fourth = -40;
            string input;

            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"    CHOOSE ONE OF THE FOLLOWING AND USE THE NUMBERS BELOW INDICATING YOUR OPTIONS ");
                Console.WriteLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"------------ALL DATA------------",first}{"------------ORDERED BY------------",second}{"------------FILTER BY------------",third}{"------------STATS------------",fourth}{"------------EXIT APP------------"}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                Console.WriteLine($"{"1 - COURSES",first}{"10 - COURSES BY TITLE",second}{"21 - COURSES BY TITLE",third}{"31 - COURSES COUNT",fourth}{"PRESS 0 BUTTON TO EXIT THE APP"}");
                Console.WriteLine($"{"2 - STUDENT",first}{"11 - STUDENT BY TITLE",second}{"22 - COURSES BY TITLE",third}{"32 - COURSES COUNT",fourth}");
                Console.WriteLine($"{"3 - ASSIGNMENTS",first}{"12 - ASSIGNMENTS BY TITLE",second}{"23 - COURSES BY TITLE",third}{"32 - COURSES COUNT",fourth}");
                Console.WriteLine($"{"4 - TRAINERS",first}{"13 - STUDENT BY TITLE",second}{"",third}{"32 - COURSES COUNT",fourth}");
                Console.WriteLine($"{"5 - ASSIGNMENTS PER COURSE",first}{"14 - STUDENT BY TITLE",second}");
                Console.WriteLine($"{"6 - STUDENTS PER COURSE",first}{"15 - STUDENT BY TITLE",second}");
                Console.WriteLine($"{"7 - TRAINERS PER COURSE",first}{"16 - STUDENT BY TITLE",second}");
                Console.WriteLine($"{"8 - ASSIGNMENTS PER STUDENT",first}{"17 - STUDENT BY TITLE",second}");
                Console.WriteLine($"{"9 - STUDENT PER COURSE PER ASSIGNMENT",first}{"18 - STUDENT BY TITLE",second}");
                Console.WriteLine($"{"",first}{"19 - STUDENT BY TITLE",second}");
                Console.WriteLine($"{"",first}{"20 - STUDENT BY TITLE",second}");
                Console.ResetColor();

                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":Views.Courses.ViewCourse.PrintCourse(db.courses);break;
                    case "2":;break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("  THANK YOU FOR VISITING");
                        break;
                        
                }


            } while (input != "0");
            Console.ResetColor();





        }
    }
    
}
