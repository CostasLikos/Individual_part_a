using Costas_Part_A;
using CostasLikos_individual_part_a.Views.HELPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostasLikos_individual_part_a.DataBase;
using CostasLikos_individual_part_a.Enums;

namespace CostasLikos_individual_part_a.Views.Courses
{
    class ViewCourse
    {
        public static void PrintCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("     All Courses");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"    {"Id",-10}{"Title",-30}{"Price",-30}{"Rating",-30}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var course in courses)
            {
                Console.WriteLine($"    {course.Id,-10}{course.title,-30}{course.stream,-30}{course.type,-30}");
            }
            Console.ResetColor();
        }

        public static void CreateCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int Id = (courses[courses.Count - 1].Id)+1;
            //title
            string title = Helper.InputText("PLEASE INPUT COURSE'S TITLE");
            //stream
            string stream = Helper.InputText("PLEASE INPUT COURSE'S STREAM");
            //enum
            TypeEnum choise = Helper.InputEnumOption("PLASE CHOOSE 1 OR 2 FOR:\n      1 ---> Full Time\n      2 ---> Part Time");
            //StartDate
            DateTime start = Helper.InputStartDate("PLEASE INPUT THE STARTING DATE OF A COURSE");
            //EndDate
            DateTime end = Helper.InputEndDate(start,choise);

            Course obj = new Course(Id,title, stream, choise, start, end);
            
            
            courses.Add(obj);
            Console.WriteLine("COURSE CREATED");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"   \nID: {Id}   \nTITLE: {title}   \nSTREAM: {stream}   \nTYPE: {choise}   \nSTART DATE: {start.ToShortDateString()}   \nEND DATE: {end.ToShortDateString()}");
            Console.ResetColor();
        }

        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            Console.WriteLine("");
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(course.title);
                foreach (var stu in course.students)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{"Student:",-15}{stu.Id,-15}{stu.firstName,-15}{stu.lastName,-15}");

                }
            }
            Console.ResetColor();
        }

        public static void PrintTrainersPerCourse(List<Course> courses)
        {
            Console.WriteLine("");
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(course.title);
                foreach (var tr in course.trainers)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{"Trainers:",-15}{tr.Id,-15}{tr.firstName,-15}{tr.lastName,-15}");
                }
            }
            Console.ResetColor();
        }

        public static void PrintAssignmentPerCourse(List<Course> courses)
        {
            Console.WriteLine("");
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(course.title);
                foreach (var ass in course.assignments)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{"Assignment:",-15}{ass.Id,-15}{ass.title,-15}");
                }
            }
            Console.ResetColor();

        }
    }
}
