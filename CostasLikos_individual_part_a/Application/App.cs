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
            MyDatabase db = new MyDatabase();
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
            Console.WriteLine($"{"  PRESS 3 TO EXIT APPLICATION"}");
            Console.ResetColor();


            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "0": Views.HELPER.Helper.Exit(); break;
                    case "1": ; break;
                    case "2": Views.HELPER.Helper.ViewAllOptionsMenu(); ; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                        break;

                }

                do
                {

                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "0": Views.HELPER.Helper.Exit(); break;
                        case "1": Views.Courses.ViewCourse.PrintCourse(db.courses); break;
                        case "2": Views.Students.ViewStudents.PrintStudent(db.students); break;
                        case "3": Views.Assignments.ViewAssignments.PrintAssignment(db.assignments); break;
                        case "4": Views.Trainers.ViewTrainers.PrintTrainers(db.trainers); break;
                        case "5": Views.Courses.ViewCourse.PrintAssignmentPerCourse(db.courses); break;
                        case "6": Views.Courses.ViewCourse.PrintStudentsPerCourse(db.courses); break;
                        case "7": Views.Courses.ViewCourse.PrintTrainersPerCourse(db.courses); break;
                        case "8": Views.Students.ViewStudents.PrintAssignmentPerStudent(db.students); break;
                        case "9": Views.Assignments.ViewAssignments.PrintStudentPerCoursePerAssignmets(db.assignments); break;
                        case "10": Views.Courses.ViewCourse.CreateCourse(db.courses); break;
                        case "11": Views.Students.ViewStudents.CreateStudent(db.students); break;
                        case "12": Views.Assignments.ViewAssignments.CreateAssignment(db.assignments); break;
                        case "13": Views.Trainers.ViewTrainers.CreateTrainer(db.trainers); break;
                        case "14": ; break;
                        case "15": ; break;
                        case "16": ; break;
                        case "99":Views.HELPER.Helper.ResetView(); break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                            break;

                    }


                } while (input != "0");
                Console.ResetColor(); 


            } while (input != "0");
            Console.ResetColor();





        }
    }
    
}
