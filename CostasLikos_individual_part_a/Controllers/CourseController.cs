using CostasLikos_individual_part_a.RepositoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Controllers
{
    class CourseController
    {
        AssignmentRepository assignmentService = new AssignmentRepository();
        StudentRepository studentService = new StudentRepository();
        CourseRepository courseService = new CourseRepository();
        TrainerRepository trainerService = new TrainerRepository();


        public void AssignStudentToCourse()
        {
            var students = studentService.GetAll();

            Console.WriteLine("Assign student to Movie");
            Console.WriteLine();
            Console.WriteLine("All students");
            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.Id,-15}{stu.firstName,-15}");
            }
            Console.WriteLine();

            var courses = courseService.GetAll();
            ViewCourse.PrintCourses(courses);

            Console.WriteLine("Give Student Id");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Give Movies Id");
            int movieId = Convert.ToInt32(Console.ReadLine());

            courseService.AttachActorToMovie(actorId, movieId);
        }
    }
}
