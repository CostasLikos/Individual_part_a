using Costas_Part_A;
using CostasLikos_individual_part_a.Controllers;
using CostasLikos_individual_part_a.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Application
{
    class App
    {
        
        public static void Run()
        {
            
            string input;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"    CHOOSE ONE OF THE FOLLOWING AND USE THE NUMBERS BELOW INDICATING YOUR OPTIONS ");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Thread.Sleep(700);
            Console.WriteLine($"{"  PRESS 1 TO CREATE YOUR DATA"}");
            Thread.Sleep(700);
            Console.WriteLine($"{"  PRESS 2 TO PROCEED WITHOUR CREATING NEW DATA"}");
            Thread.Sleep(700);
            Console.WriteLine($"{"  PRESS 0 TO EXIT APPLICATION"}");
            Console.ResetColor();


            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "0": Views.HELPER.Helper.Exit(); break;
                    case "1": Views.HELPER.Helper.ViewCreateMenu(); break;
                    case "2": Views.HELPER.Helper.ViewAllOptionsMenu(); ; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine();
                        Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                        break;

                }

                


            } while (input != "0");
            Console.ResetColor();





        }
    }
    
}
