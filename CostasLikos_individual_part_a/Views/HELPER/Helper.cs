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
using CostasLikos_individual_part_a.RepositoryService;
using CostasLikos_individual_part_a.Views.Assignments;
using CostasLikos_individual_part_a.Views.Trainers;

namespace CostasLikos_individual_part_a.Views.HELPER
{
    
    public static class Helper
    {

        
        public static void ViewCreateMenu(List<Student> students,List<Trainer> trainers,List<Course> courses,List<Assignment> assignments)
        {

            int input;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"    CHOOSE HOW MANY ENTITIES YOU WANT TO CREATE ,PLEASE INSERT NUMBER FROM 1-10. ");
                Console.WriteLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;


                var kati = Console.ReadLine();
                bool isNumerical = int.TryParse(kati, out input);

            } while (input != 1 && input != 2 && input != 3 && input != 4 && input != 5 && input != 6 && input != 7 && input != 8 && input != 9 && input != 10);
            Console.WriteLine($"  YOU ARE CREATING :{input} ENTITIES.");
            for (int i = 1; i <= input; i++)
            {
                string input2;
                Console.WriteLine($"  YOU ARE CREATING ENTITY NUMBER : {i}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"    CHOOSE ONE OF THE FOLLOWING AND USE THE NUMBERS BELOW INDICATING WHAT YOU WANT TO CREATE    ");
                Console.WriteLine();
                Console.ResetColor();
                

                

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(300);
                    Console.WriteLine($"{"  PRESS 1 TO CREATE YOUR COURSE  "}");
                    Thread.Sleep(100);
                    Console.WriteLine($"{"  PRESS 2 TO CREATE YOUR STUDENT  "}");
                    Thread.Sleep(100);
                    Console.WriteLine($"{"  PRESS 3 TO CREATE YOUR ASSIGNMENT  "}");
                    Thread.Sleep(100);
                    Console.WriteLine($"{"  PRESS 4 TO CREATE YOUR TRAINER  "}");
                    Thread.Sleep(100);
                    Console.WriteLine($"{"  PRESS 0 TO EXIT  "}");
                    Console.ResetColor();
                    
                    input2 = Console.ReadLine();
                    
                } while (input2 != "0" && input2 != "1" && input2 != "2" && input2 != "3" && input2 != "4" );
                switch (input2)
                {
                    case "0": Exit(); break;
                    case "1": ViewCourse.CreateCourse(courses); break;
                    case "2": ViewStudents.CreateStudent(students); break;
                    case "3": ViewAssignments.CreateAssignment(assignments); break;
                    case "4": ViewTrainers.CreateTrainer(trainers); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                        break;

                }

            }

            Console.ReadKey();
            Helper.ViewAllOptionsMenu(students,trainers,courses,assignments);

        }
        public static void ViewAllOptionsMenu(List<Student> students, List<Trainer> trainers, List<Course> courses, List<Assignment> assignments)
        {
            const int first = -50;
            const int second = -50;
            const int third = -50;
            const int fourth = -50;
            string input;

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
            Console.WriteLine($"{"2 - STUDENT",first}{"11 - CREATE A STUDENT",second}{"15 - PENDING ASSIGNMENT SUBMISSION DATE",third}{"PRESS 99 BUTTON TO CLEAR THE CONSOLE",fourth}");
            Console.WriteLine($"{"3 - ASSIGNMENTS",first}{"12 - CREATE AN ASSIGNMENT",second}{"16 - FILTER DATA",third}{"",fourth}");
            Console.WriteLine($"{"4 - TRAINERS",first}{"13 - CREATE A TRAINER",second}{"17 - ASSING A STUDENT TO A COURSE",third}{"",fourth}");
            Console.WriteLine($"{"5 - ASSIGNMENTS PER COURSE",first}{"",second}{"18 - ASSING AN ASSINGMENT TO A COURSE",third}");
            Console.WriteLine($"{"6 - STUDENTS PER COURSE",first}{"",second}{"19 - ASSING A TRAINER TO A COURSE",third}");
            Console.WriteLine($"{"7 - TRAINERS PER COURSE",first}{"",second}{"20 - ASSING AN ASSIGNMENT TO A STUDENT",third}");
            Console.WriteLine($"{"8 - ASSIGNMENTS PER STUDENT",first}{"",second}{"",third}");
            Console.WriteLine($"{"9 - STUDENT PER COURSE PER ASSIGNMENT",first}{"",second}");
            Console.WriteLine($"{"",first}{"",second}");
            Console.WriteLine($"{"",first}{"",second}");
            Console.ResetColor();

            do
            {

                input = Console.ReadLine();
                
                switch (input)
                {
                    case "0": Exit(); break;
                    case "1": ViewCourse.PrintCourse(courses); break;
                    case "2": ViewStudents.PrintStudent(students); break;
                    case "3": ViewAssignments.PrintAssignment(assignments); break;
                    case "4": ViewTrainers.PrintTrainers(trainers); break;
                    case "5": ViewCourse.PrintAssignmentPerCourse(courses); break;
                    case "6": ViewCourse.PrintStudentsPerCourse(courses); break;
                    case "7": ViewCourse.PrintTrainersPerCourse(courses); break;
                    case "8": ViewStudents.PrintAssignmentPerStudent(students); break;
                    case "9": ViewAssignments.PrintStudentPerCoursePerAssignmets(assignments); break;
                    case "10": ViewCourse.CreateCourse(courses); break;
                    case "11": ViewStudents.CreateStudent(students); break;
                    case "12": ViewAssignments.CreateAssignment(assignments); break;
                    case "13": ViewTrainers.CreateTrainer(trainers); break;
                    case "14":; break;
                    case "15": DateForStudentsWithAssignmentToGive("  PLEASE IN PUT THE DATE YOU WANT TO CHECK.\n       format: YYYY-MM-DD",students); break;
                    case "16":; break;
                    case "17":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        ViewStudents.PrintStudent(students);
                        int stuid = InputNumber("Please choose and input Student's ID");
                        ViewCourse.PrintCourse(courses);
                        Console.WriteLine();
                        int couid = InputNumber("Please choose and input Course's ID");
                        new CourseRepository().AttachStudentToCourse(stuid, couid);
                        ViewCourse.PrintStudentsPerCourse(courses);
                        break;
                    case "18":
                        
                        break;
                    case "19":new AssignmentRepository().GetByName("skata"); break;
                    case "20":new AssignmentRepository().GetByName("skata"); break;
                    case "99": Console.Clear(); ViewAllOptionsMenu(students, trainers, courses, assignments); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                        Console.ResetColor();
                        break;

                }


            } while (input != "0");
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
            if (string.IsNullOrEmpty(result))
            {
                throw new ArgumentNullException(nameof(result));
            }
            return result;
        }

        public static int InputNumber(string placeholder)
        {
            int number;
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            bool success = int.TryParse(result, out number);
            if (success)
            {
                Console.WriteLine($"Converted '{result}' to {number}.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{result ?? "<null>"}' failed.");
            }
            return number;
        }

        public static double InputDouble(string placeholder)
        {

            Console.WriteLine(placeholder);
            double result = Convert.ToDouble(Console.ReadLine());
            if (double.IsNaN(result)||double.IsInfinity(result))
            {
                throw new ArgumentNullException(nameof(result));
            }
            return result;
        }

        public static TypeEnum InputEnumOption(string placeholder)
        {
            int result;
            Console.WriteLine(placeholder);

            do
            {

                var kati = Console.ReadLine();
                bool isNumerical = int.TryParse(kati, out result);



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
            bool x = IsProperDate(result); ;

            do
            {
                Console.WriteLine("WRONG INPUT PLESE TRY ARAIN WITH VALID DATE FORMATING ex : YYYY-MM-DD");
                result = Console.ReadLine();
                x = IsProperDate(result);
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
                result = start.AddMonths(3);
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

        public static void DateForStudentsWithAssignmentToGive(string placeholder, List<Student> students)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(placeholder);
            Console.ResetColor();
            DateTime date = Convert.ToDateTime(Console.ReadLine());
           



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
                foreach (Assignment ass in stu.assignments)
                {
                    if (ass.subDateTime > weekstart && ass.subDateTime < date)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"  Student:  {stu.firstName} { stu.lastName} - { ass.title} - { ass.subDateTime}");
                    }
                }

            }
        }


    }
}
