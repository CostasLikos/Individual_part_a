using Costas_Part_A;
using CostasLikos_individual_part_a.Enums;
using CostasLikos_individual_part_a.Views.HELPER;
using System;
using System.Collections.Generic;
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
                Console.WriteLine($"    {ass.Id,-10}{ass.title,-30}{ass.description,-60}{ass.subDateTime,-30}{ass.oralMark,-30}{ass.totalMark,-30}");
            }
            Console.ResetColor();
        }

        public static void CreateAssignment(List<Assignment> assignments)
        {
            int Id = (assignments[assignments.Count - 1].Id) + 1;

            string title = Helper.InputText("Give Assignment's title");
            
            string description = Helper.InputText("Give Assignment's description");
            
            DateTime subDateTime = Helper.InputStartDate("Choose the subDateTime of the assignmet");
            
            int oralMark = Helper.InputNumber("Give the oral mark of assignmet");

            int totalMark = Helper.InputNumber("Give the total mark of assignmet");

            Assignment obj = new Assignment(Id, title, description, subDateTime, oralMark, totalMark);

            assignments.Add(obj);
        }

        public static void PrintStudentPerCoursePerAssignmets(List<Assignment> assignments)
        {
            foreach (var i in assignments)
            {
                Console.WriteLine($"{"Assignmets:",-15}{i.title,-15}");
                foreach (var j in i.courses)
                {
                    Console.WriteLine($"{"Courses:",-15}{j.title,-15}{j.stream,-15}{j.type,-15}");
                    foreach (var k in j.students)
                    {
                        Console.WriteLine($"{"Students:",-15}{k.Id,-15}{k.firstName,-15}{k.lastName,-15}{k.dateOfBirth,-15}{k.fees,-15}");
                    }
                }
            }
        }
    }
}
