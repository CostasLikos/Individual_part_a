using Costas_Part_A;
using CostasLikos_individual_part_a.Enums;
using CostasLikos_individual_part_a.Views.HELPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Views.Students
{
    class ViewStudents
    {
        public static void PrintStudent(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("     All Students");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"    {"Id",-10}{"Firstname",-30}{"Lastname",-30}{"Date of Birth",-30}{"Fees",-30}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var stu in students)
            {
                Console.WriteLine($"    {stu.Id,-10}{stu.firstName,-30}{stu.lastName,-30}{stu.dateOfBirth.ToShortDateString(),-30}{stu.fees,-30}");
            }
            Console.ResetColor();
        }

        public static void CreateStudent(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            int Id = (students[students.Count - 1].Id) + 1;
            
            string firstname = Helper.InputText("PLEASE INPUT STUDENT'S FIRSTNAME");
            
            string lastname = Helper.InputText("PLEASE INPUT STUDENT'S SURNAME");
            
            DateTime bdate = Helper.InputStartDate("PLEASE INPUT STUDENT'S DATE OF BIRTH");

            double fees = Helper.InputDouble("PLEASE INPUT STUDENT'S FEES");

            Student obj = new Student(Id, firstname, lastname, bdate, fees);


            students.Add(obj);
            Console.WriteLine("STUDENT CREATED");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"   \nID: {Id}   \nFULL NAME: {firstname} {lastname}   \nDATE OF BIRTH: {bdate.ToShortDateString()}   \nFEES: {fees}");
            Console.ResetColor();
        }

       

        public static void PrintAssignmentPerStudent(List<Student> students)
        {
            Console.WriteLine("");
            foreach (var stu in students)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{stu.firstName} {stu.lastName}");
                foreach (var ass in stu.assignments)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{"Assignment:",-15}{ass.Id,-15}{ass.title,-15}");
                }
            }
            Console.ResetColor();

        }
    }
}
