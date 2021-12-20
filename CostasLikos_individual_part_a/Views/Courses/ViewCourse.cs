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
            Console.WriteLine("All Courses");
            Console.WriteLine();

            Console.WriteLine($"{"Id",-15}{"Title",-15}{"Price",-15}{"Rating",-15}");
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,-15}{course.title,-15}{course.stream,-15}{course.type,-15}");
            }
        }

        public static Course CreateCourse()
        {
            
            //title
            string title = Helper.InputText("Give Course's title");
            //stream
            string stream = Helper.InputText("Give Course's stream");
            //enum
            TypeEnum choise = Helper.InputEnumOption("Choose the type 1 for Full-Time or 2 for Part-Time");
            //StartDate
            DateTime start = Helper.InputStartDate("Choose the starting date of the course");
            //EndDate
            DateTime end = Helper.InputEndDate(start,choise);

            Course obj = new Course(0,title, stream, choise , start, end);

            return obj;
            //PWS FTIAXNW TO ID????

        }

        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine(course.title);
                foreach (var stu in course.students)
                {
                    Console.WriteLine($"{"",-15}{stu.firstName,-15}{stu.lastName,-15}");
                }
            }
        }
    }
}
