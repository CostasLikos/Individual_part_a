using Costas_Part_A;
using CostasLikos_individual_part_a.DataBase;
using CostasLikos_individual_part_a.Enums;
using CostasLikos_individual_part_a.Views.Courses;
using CostasLikos_individual_part_a.Views.Students;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Views.HELPER
{
    
    class Helper
    {
        public static void ViewCreateMenu()
        {

            MyDatabase db = new MyDatabase();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"    CHOOSE HOW MANY ENTITIES YOU WANT TO CREATE ,PLEASE INSERT NUMBER. ");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
             int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string input2;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"    CHOOSE ONE OF THE FOLLOWING AND USE THE NUMBERS BELOW INDICATING WHAT YOU WANT TO CREATE    ");
                Console.WriteLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                
                Thread.Sleep(700);
                Console.WriteLine($"{"  PRESS 1 TO CREATE YOUR COURSE  "}");
                Thread.Sleep(700);
                Console.WriteLine($"{"  PRESS 2 TO CREATE YOUR STUDENT  "}");
                Thread.Sleep(700);
                Console.WriteLine($"{"  PRESS 3 TO CREATE YOUR ASSIGNMENT  "}");
                Thread.Sleep(700);
                Console.WriteLine($"{"  PRESS 4 TO CREATE YOUR TRAINER  "}");
                Thread.Sleep(700);
                Console.WriteLine($"{"  PRESS 0 TO EXIT  "}");
                Console.ResetColor();

                do
                {
                    input2 = Console.ReadLine();
                    switch (input2)
                    {
                        case "0": Helper.Exit(); break;
                        case "1": ViewCourse.CreateCourse(db.courses); break;
                        case "2": ViewStudents.CreateStudent(db.students); break;
                        case "3": Assignments.ViewAssignments.CreateAssignment(db.assignments); break;
                        case "4": Trainers.ViewTrainers.CreateTrainer(db.trainers); break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                            break;

                    } 
                } while (input2 != "0");

            }


        }
        public static void ViewAllOptionsMenu()
        {
            const int first = -40;
            const int second = -40;
            const int third = -40;
            const int fourth = -40;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"    CHOOSE ONE OF THE FOLLOWING AND USE THE NUMBERS BELOW INDICATING YOUR OPTIONS ");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{"------------ALL DATA------------",first}{"------------CREATE DATA------------",second}{"------ADDITIONAL OPTIONS------",third}{"------------MANAGE APP------------",fourth}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine($"{"1 - COURSES",first}{"10 - CREATE A COURSE",second}{"14 - STUDENTS WITH MORE THAN ONE COURSE",third}{"PRESS 0 BUTTON TO EXIT THE APP",fourth}");
            Console.WriteLine($"{"2 - STUDENT",first}{"11 - CREATE A STUDENT",second}{"15 - PENDING ASSIGNMENT SUBMISSION",third}{"PRESS 99 BUTTON TO CLEAR THE CONSOLE",fourth}");
            Console.WriteLine($"{"3 - ASSIGNMENTS",first}{"12 - CREATE AN ASSIGNMENT",second}{"16 - FILTER DATA",third}{"",fourth}");
            Console.WriteLine($"{"4 - TRAINERS",first}{"13 - CREATE A TRAINER",second}{"",third}{"",fourth}");
            Console.WriteLine($"{"5 - ASSIGNMENTS PER COURSE",first}{"",second}{"",third}");
            Console.WriteLine($"{"6 - STUDENTS PER COURSE",first}{"",second}");
            Console.WriteLine($"{"7 - TRAINERS PER COURSE",first}{"",second}");
            Console.WriteLine($"{"8 - ASSIGNMENTS PER STUDENT",first}{"",second}");
            Console.WriteLine($"{"9 - STUDENT PER COURSE PER ASSIGNMENT",first}{"",second}");
            Console.WriteLine($"{"",first}{"",second}");
            Console.WriteLine($"{"",first}{"",second}");
            Console.ResetColor();
        }

        public static void Exit()
        {
            Console.WriteLine("THANK YOU FOR VISITING");
            Environment.Exit(0);
        }

        public static string InputText(string placeholder)
        {
            
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            return result;
        }

        public static int InputNumber(string placeholder)
        {
            
            Console.WriteLine(placeholder);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public static double InputDouble(string placeholder)
        {

            Console.WriteLine(placeholder);
            double result = Convert.ToDouble(Console.ReadLine());
            return result;
        }
        public static int Counterplus1(List<Course> courses) => courses.Count() + 1; //??

        public static TypeEnum InputEnumOption(string placeholder)
        {
            int result;
            Console.WriteLine(placeholder);

            do
            {
                result = Convert.ToInt32(Console.ReadLine());



            } while (result != 1 && result != 2);

            if (result == 1)
            {
                return TypeEnum.FullTime;
            }
            else 
            {
                return TypeEnum.PartTime;
            }
        }

        public static bool IsProperDate(string date)
        {
            DateTime result;
            DateTime.TryParse(date, out result);
            return result == default(DateTime) ? false : true;
        }

       

        public static DateTime InputStartDate(string placeholder)
        {
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            bool x;
            do
            {
                x = IsProperDate(result);
                if (!x)
                {
                    Console.WriteLine("Wrong Input, Try again with DateTime Formating ex. YYYY-MM-DD");
                    Console.ReadLine();
                }
            } while (!x);

            DateTime date = Convert.ToDateTime(result);

            return date;
            //DEN BAZW VALIDATION GIA TO PARELTHON GT MPOREI NA THELW NA KANW ADD KATI POU EXEI PERASEI O KAIROS TOU

        }

        public static DateTime InputEndDate(DateTime start, TypeEnum choice)
        {
            DateTime result;

            if (choice == TypeEnum.FullTime)
            {
                result  = start.AddMonths(3); 
            }
            else
            {
                result = start.AddMonths(6);
            }
            
            return result;

        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.Read();
        }

        public static void ResetView()
        {
            Console.Clear();

            ViewAllOptionsMenu();
            
        }

        public static void DateForStudentsWithAssignmentToGive(DateTime date,List<Student> students)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  PLEASE IN PUT THE DATE YOU WANT TO CHECK.\n       format: YYYY,MM,DD");
            Console.ResetColor();



            CultureInfo enUS = new CultureInfo("en-US");
            date.ToString("d", enUS);
            DateTime weekstart = new DateTime();

            if (date.ToString("ddd", enUS) == "Sat")
            {
                date.AddDays(-1);
                 weekstart = date;
                weekstart.AddDays(-4);
            }
            else if (date.ToString("ddd", enUS) == "Sun")
            {
                date.AddDays(-2);
                weekstart = date;
                weekstart.AddDays(-4);
            }
            else
            {
                if (date.ToString("ddd", enUS) == "Mon")
                {
                    weekstart = date;
                    date.AddDays(+4);
                }
                else if (date.ToString("ddd", enUS) == "Tue")
                {
                    weekstart = date;
                    weekstart.AddDays(-1);
                    date.AddDays(+3);

                }
                else if (date.ToString("ddd", enUS) == "Wed")
                {
                    weekstart = date;
                    weekstart.AddDays(-2);
                    date.AddDays(+2);
                }
                else if (date.ToString("ddd", enUS) == "The")
                {
                    weekstart = date;
                    weekstart.AddDays(-3);
                    date.AddDays(+1);
                }
                else if (date.ToString("ddd", enUS) == "Fri")
                {
                    weekstart = date;
                    weekstart.AddDays(-4);
                }
            }
            
            foreach (var stu in students)
            {
                if (stu.assignments.FindAll()> weekstart && stu.assignment.subDateTime < date)
                {
                    Console.WriteLine();
                    Console.WriteLine($"  Student:  {stu.firstName} { stu.lastName} - { stu.assignment.title} - { stu.assignment.subDateTime}");
                }
            }
        }


    }
}
