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


        public static void ViewCreateMenu(List<Student> students, List<Trainer> trainers, List<Course> courses, List<Assignment> assignments)
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
                    Thread.Sleep(100);
                    Console.WriteLine($"{"  PRESS 1 TO CREATE YOUR COURSE  "}");
                    Thread.Sleep(50);
                    Console.WriteLine($"{"  PRESS 2 TO CREATE YOUR STUDENT  "}");
                    Thread.Sleep(50);
                    Console.WriteLine($"{"  PRESS 3 TO CREATE YOUR ASSIGNMENT  "}");
                    Thread.Sleep(50);
                    Console.WriteLine($"{"  PRESS 4 TO CREATE YOUR TRAINER  "}");
                    Thread.Sleep(50);
                    Console.WriteLine($"{"  PRESS 0 TO EXIT  "}");
                    Console.ResetColor();

                    input2 = Console.ReadLine();

                } while (input2 != "0" && input2 != "1" && input2 != "2" && input2 != "3" && input2 != "4");
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
            ViewAllOptionsMenu(students, trainers, courses, assignments);

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
            Console.WriteLine($"{"3 - ASSIGNMENTS",first}{"12 - CREATE AN ASSIGNMENT",second}{"16 - FILTER DATA",third}");
            Console.WriteLine($"{"4 - TRAINERS",first}{"13 - CREATE A TRAINER",second}{"17 - MERGE A STUDENT TO A COURSE",third}{"",fourth}");
            Console.WriteLine($"{"5 - ASSIGNMENTS PER COURSE",first}{"",second}{"18 - MERGE AN ASSINGMENT TO A COURSE",third}");
            Console.WriteLine($"{"6 - STUDENTS PER COURSE",first}{"",second}{"19 - MERGE A TRAINER TO A COURSE",third}");
            Console.WriteLine($"{"7 - TRAINERS PER COURSE",first}{"",second}{"20 - MERGE AN ASSIGNMENT TO A STUDENT",third}");
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
                    case "14": StudentsWithMoreThanOneCourse("These are the students with more than one course :", students); break;
                    case "15": DateForStudentsWithAssignmentToGive(Helper.InputStartDate("  Please input the date you want to check for pending assingments.\n       format: YYYY-MM-DD"), students); break;
                    case "16": FilteringMenu(students, trainers, courses, assignments); break;
                    case "17":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        ViewStudents.PrintStudent(students);
                        int stuid = InputNumber("Please choose and input Student's ID");
                        if (stuid > (students.Count) || stuid == 0)
                        {
                            do
                            {
                                stuid = InputNumber("Please choose and input Student's ID only from the following");
                            } while (stuid > (students.Count) || stuid == 0);
                        }
                        ViewCourse.PrintCourse(courses);
                        Console.WriteLine();
                        int couidstu = InputNumber("Please choose and input Course's ID");
                        if (couidstu > (courses.Count) || couidstu == 0)
                        {
                            do
                            {
                                couidstu = InputNumber("Please choose and input Courses's ID only from the following");
                            } while (couidstu > (courses.Count) || couidstu == 0);
                        }
                        new CourseRepository().AttachStudentToCourse(stuid, couidstu);
                        ViewCourse.PrintStudentsPerCourse(courses);
                        break;
                    case "18":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        ViewAssignments.PrintAssignment(assignments);
                        int assid = InputNumber("Please choose and input Assignment's ID");
                        if (assid > (assignments.Count) || assid == 0)
                        {
                            do
                            {
                                assid = InputNumber("Please choose and input Assignment's ID only from the following");
                            } while (assid > (assignments.Count) || assid == 0);
                        }
                        ViewCourse.PrintCourse(courses);
                        Console.WriteLine();
                        int couidass = InputNumber("Please choose and input Course's ID");
                        if (couidass > (courses.Count) || couidass == 0)
                        {
                            do
                            {
                                couidass = InputNumber("Please choose and input Course's ID only from the following");
                            } while (couidass > (courses.Count) || couidass == 0);
                        }
                        new CourseRepository().AttachAssignmentToCourse(assid, couidass);
                        ViewCourse.PrintAssignmentPerCourse(courses);
                        break;
                    case "19":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        ViewTrainers.PrintTrainers(trainers);
                        int traid = InputNumber("Please choose and input Trainer's ID");
                        if (traid > (trainers.Count) || traid == 0)
                        {
                            do
                            {
                                traid = InputNumber("Please choose and input Trainer's ID only from the following");
                            } while (traid > (trainers.Count) || traid == 0);
                        }
                        ViewCourse.PrintCourse(courses);
                        Console.WriteLine();
                        int couidtra = InputNumber("Please choose and input Course's ID");
                        if (couidtra > (courses.Count) || couidtra == 0)
                        {
                            do
                            {
                                couidtra = InputNumber("Please choose and input Course's ID only from the following");
                            } while (couidtra > (courses.Count) || couidtra == 0);
                        }
                        new CourseRepository().AttachTrainerToCourse(traid, couidtra);
                        ViewCourse.PrintTrainersPerCourse(courses);
                        break;
                    case "20":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        ViewAssignments.PrintAssignment(assignments);
                        int assid2 = InputNumber("Please choose and input Assignment's ID");
                        if (assid2 > (assignments.Count) || assid2 == 0)
                        {
                            do
                            {
                                assid2 = InputNumber("Please choose and input Assignment's ID only from the following");
                            } while (assid2 > (assignments.Count) || assid2 == 0);
                        }
                        ViewStudents.PrintStudent(students);
                        Console.WriteLine();
                        int stuidass = InputNumber("Please choose and input Student's ID");
                        if (stuidass > (students.Count) || stuidass == 0)
                        {
                            do
                            {
                                stuidass = InputNumber("Please choose and input Student's ID only from the following");
                            } while (stuidass > (students.Count) || stuidass == 0);
                        }
                        new StudentRepository().AttachAssignmentToStudent(assid2, stuidass);
                        ViewStudents.PrintAssignmentPerStudent(students);
                        break;
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

        public static void FilteringMenu(List<Student> students, List<Trainer> trainers, List<Course> courses, List<Assignment> assignments)
        {


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"    CHOOSE ONE OF THE FOLLOWING AND USE THE NUMBERS BELOW INDICATING YOUR OPTIONS ");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 0 TO EXIT FILTER MENU"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 1 TO FILTER COURSES BY ID"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 2 TO FILTER STUDENTS BY ID"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 3 TO FILTER ASSIGNMENTS BY ID"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 4 TO FILTER TRAINERS BY ID"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 5 TO FILTER COURSES BY NAME"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 6 TO FILTER STUDENTS BY NAME"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 7 TO FILTER ASSIGNMENTS BY NAME"}");
            Thread.Sleep(50);
            Console.WriteLine($"{"  PRESS 8 TO FILTER TRAINERS BY NAME"}");
            Thread.Sleep(50);
            Console.ResetColor();

            string input;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "0": ViewAllOptionsMenu(students, trainers, courses, assignments); break;
                    case "1": new CourseRepository().GetByID(InputNumber("Please Input the ID You want to filter")); break;
                    case "2": new StudentRepository().GetByID(InputNumber("Please Input the ID You want to filter")); break;
                    case "3": new AssignmentRepository().GetByID(InputNumber("Please Input the ID You want to filter")); break;
                    case "4": new TrainerRepository().GetByID(InputNumber("Please Input the ID You want to filter")); break;
                    case "5":
                        new CourseRepository().GetByName(InputText("Please Input the Name You want to filter")); break;
                    case "6":
                        new StudentRepository().GetByName(InputText("Please Input the Name You want to filter"));
                        new StudentRepository().GetByLastName(InputText("Please Input the Last Name You want to filter")); break;
                    case "7":
                        new AssignmentRepository().GetByName(InputText("Please Input the Name You want to filter")); break;
                    case "8":
                        new TrainerRepository().GetByName(InputText("Please Input the Name You want to filter"));
                        new TrainerRepository().GetByLastName(InputText("Please Input the Last Name You want to filter")); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine();
                        Console.WriteLine("  WRONG INPUT, PLEASE SELECT A GIVEN NUMBER FROM ABOVE.");
                        break;
                }

            } while (input != "0");
            Console.ResetColor();
        }

        public static void Exit()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("       . . . . o o o o o o");
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o");
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(margin + "                _____      o");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(margin + "      [________]_|__|________)< ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");

                    Thread.Sleep(50);
                }
                Exit2();
            }
        }

        public static void Exit2()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("THANK YOU FOR VISITING !");
            Console.ResetColor();
            Environment.Exit(0);

        }

        public static string InputText(string placeholder)
        {

            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            if (string.IsNullOrEmpty(result))
            {
                do
                {
                    Console.WriteLine($" There as an error with your input: {result}\n your input can not be empty or null.\n Please try again. ");
                    result = Console.ReadLine();
                } while (string.IsNullOrEmpty(result));
            }
            return result;
        }

        public static int InputNumber(string placeholder)
        {
            int number;
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            bool success = int.TryParse(result, out number);
            if (!success)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"Attempted conversion of '{result ?? "<null>"}' failed.");
                    Console.WriteLine();
                    Console.WriteLine($"Please Try again");
                    result = Console.ReadLine();
                    success = int.TryParse(result, out number);

                } while (!success);
            }

            Console.WriteLine($"Converted '{result}' to {number}.");
            return number;

        }

        public static double InputDouble(string placeholder)
        {

            double number;
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            bool success = double.TryParse(result, out number);
            if (!success)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"Attempted conversion of '{result ?? "<null>"}' failed.");
                    Console.WriteLine();
                    Console.WriteLine($"Please Try again");
                    result = Console.ReadLine();
                    success = double.TryParse(result, out number);

                } while (!success);
            }

            Console.WriteLine($"Converted '{result}' to {number}.");
            return number;
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
            if (!x)
            {
                do
                {
                    Console.WriteLine("WRONG INPUT PLESE TRY ARAIN WITH VALID DATE FORMATING ex : YYYY-MM-DD");
                    result = Console.ReadLine();
                    x = IsProperDate(result);
                } while (!x);
            }

            DateTime date = Convert.ToDateTime(result);

            return date;
            //DEN BAZW VALIDATION GIA TO PARELTHON GT MPOREI NA THELW NA KANW ADD KATI POU EXEI PERASEI O KAIROS TOU

        }

        public static DateTime InputBirthDate(string placeholder)
        {
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            bool x = IsProperDate(result); ;
            if (!x)
            {
                do
                {
                    Console.WriteLine("WRONG INPUT PLESE TRY AGAIN WITH VALID DATE OF BIRTH FORMATING ex : YYYY-MM-DD");
                    result = Console.ReadLine();
                    x = IsProperDate(result);
                } while (!x);
            }

            DateTime date = Convert.ToDateTime(result);
            DateTime now = DateTime.Now;

            if (date > now)
            {
                do
                {
                    Console.WriteLine("WRONG INPUT PLESE TRY AGAIN WITH A DATE BEFORE TODAY, THANK YOU");
                    result = Console.ReadLine();
                    x = IsProperDate(result);
                    date = Convert.ToDateTime(result);
                } while (date > now || !x);
            }
            return date;
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

        public static void DateForStudentsWithAssignmentToGive(DateTime date, List<Student> students)
        {
            List<DateTime> week = GetWeek(date);
            foreach (var stu in students)
            {
                foreach (var ass in stu.assignments)
                {
                    if (ass.subDateTime >= week[0] && ass.subDateTime <= week[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine();
                        Console.WriteLine($"  Student:  {stu.firstName} { stu.lastName} - { ass.title} - { ass.subDateTime.ToShortDateString()}");
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                }

            }
        }
        public static List<DateTime> GetWeek(DateTime date)
        {
            var dayOfTheWeek = date.DayOfWeek; // enum list
            Console.WriteLine($"The day you choose is: {dayOfTheWeek}");
            var startDate = date;
            var endDate = date;



            if (dayOfTheWeek == DayOfWeek.Monday)
            {
                endDate = endDate.AddDays(4);
            }
            else if (dayOfTheWeek == DayOfWeek.Tuesday)
            {
                startDate = startDate.AddDays(-1);
                endDate = endDate.AddDays(3);
            }
            else if (dayOfTheWeek == DayOfWeek.Wednesday)
            {
                startDate = startDate.AddDays(-2);
                endDate = endDate.AddDays(2);
            }
            else if (dayOfTheWeek == DayOfWeek.Thursday)
            {
                startDate = startDate.AddDays(-3);
                endDate = endDate.AddDays(1);
            }
            else if (dayOfTheWeek == DayOfWeek.Friday)
            {
                startDate = startDate.AddDays(-4);
            }
            else if (dayOfTheWeek == DayOfWeek.Saturday)
            {
                startDate = startDate.AddDays(-5);
                endDate = endDate.AddDays(-1);
            }
            else
            {
                startDate = startDate.AddDays(-6);
                endDate = endDate.AddDays(-2);
            }

            List<DateTime> days = new List<DateTime>() { startDate, endDate };
            return days;
        }

        public static void StudentsWithMoreThanOneCourse(string placeholder, List<Student> students)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(placeholder);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var stu in students)
            {
                foreach (Course cour in stu.courses)
                {
                    if (stu.courses.Count > 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"  Student:  {stu.firstName} { stu.lastName} \n Courses number: { stu.courses.Count}");
                    }
                }

            }
            Console.ResetColor();
        }


    }
}
