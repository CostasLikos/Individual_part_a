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
            TypeEnum choise = Helper.EnumOption("Choose the type 1 for Full-Time or 2 for Part-Time");
            //StartDate
            DateTime start = Helper.EnumOption("Choose the starting date of the course");
            //EndDate
            DateTime end = Helper.EnumOption("Choose the finishing date of the course");

            Course obj = new Course(0,title, stream, choise , );

            return obj;
            //PWS FTIAXNW TO ID????

        }

        public static void PrintActorsPerMovies(List<Movie> movies)
        {
            foreach (var mov in movies)
            {
                Console.WriteLine(mov.Title);
                foreach (var actor in mov.Actors)
                {
                    Console.WriteLine($"{"",-15}{actor.FirstName,-15}{actor.LastName,-15}");
                }
            }
        }
    }
}
