using Costas_Part_A;
using CostasLikos_individual_part_a.Enums;
using CostasLikos_individual_part_a.Views.HELPER;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Views.Assignments
{

    class ViewAssignments
    {
        public static void PrintAssignment(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("     All Assignments");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"    {"Id",-10}{"Title",-30}{"Description",-60}{"Subition Date",-30}{"Oral mark",-30}{"Total Mark",-30}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var ass in assignments)
            {
                Console.WriteLine($"    {ass.Id,-10}{ass.title,-30}{ass.description,-60}{ass.subDateTime.ToShortDateString(),-30}{ass.oralMark,-30}{ass.totalMark,-30}");
            }
            Console.ResetColor();
        }

        public static void CreateAssignment(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            int Id = (assignments[assignments.Count - 1].Id) + 1;

            string title = Helper.InputText("PLEASE INPUT ASSIGNMENT'S TITLE");

            string description = Helper.InputText("PLESE TYPE YOUR DESCEPTION OF THE ASSIGNMENT");

            DateTime subDateTime = Helper.InputStartDate("PLEASE INPUT THE SUBMISSION DATE OF THE ASSIGNMENT. ex : YYYY-MM-DD");

            int oralMark = Helper.InputNumber("PLEASE INPUT THE ORAL MARK OF THE ASSIGNMENT");

            int totalMark = Helper.InputNumber("PLEASE INPUT THE TOTAL MARK OF THE ASSIGNMENT");

            Assignment obj = new Assignment(Id, title, description, subDateTime, oralMark, totalMark);

            assignments.Add(obj);
            Console.WriteLine("ASSIGNMENT CREATED");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"   \nID: {Id}   \nTITLE: {title}   \nDESCIPTION: {description}   \nSUBMISSION DATE: {subDateTime.ToShortDateString()}   \nORAL MARK: {oralMark}   \nTOTAL MARK: {totalMark}");
            Console.ResetColor();
        }

        public static void PrintStudentPerCoursePerAssignmets(List<Assignment> assignments)
        {
            foreach (var i in assignments)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{"Assignmets:",-15}{i.title,-15}");
                foreach (var j in i.courses)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{"Courses:",-15}{j.title,-15}{j.stream,-15}{j.type,-15}");
                    Console.WriteLine();
                    foreach (var k in j.students)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"{"Students:",-15}{k.Id,-15}{k.firstName,-15}{k.lastName,-15}{k.dateOfBirth.ToShortDateString(),-15}{k.fees,-15}");
                    }
                }
            }
        }
    }
}
