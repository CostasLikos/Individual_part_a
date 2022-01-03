using CostasLikos_individual_part_a.RepositoryService;
using CostasLikos_individual_part_a.Views.Courses;
using CostasLikos_individual_part_a.Views.Students;
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
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Assign student to Course");
            Console.WriteLine();
            Console.WriteLine("All students");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.Id,-15}{stu.firstName,-15}");
            }
            Console.WriteLine();

            var courses = courseService.GetAll();
            ViewCourse.PrintCourse(courses);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Give Student Id");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Give Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            courseService.AttachStudentToCourse(studentId, courseId);
        }

        public void AssignAssignmentToCourse()
        {
            var asssignments = assignmentService.GetAll();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Assign an assignment to Course");
            Console.WriteLine();
            Console.WriteLine("All assignmets");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var ass in asssignments)
            {
                Console.WriteLine($"{ass.Id,-15} - {ass.title,-15}");
            }
            Console.WriteLine();

            var courses = courseService.GetAll();
            ViewCourse.PrintCourse(courses);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Give Assignment Id");
            int assId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Give Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            courseService.AttachAssignmentToCourse(assId, courseId);
        }
        public void AssignTrainerToCourse()
        {
            var trainers = trainerService.GetAll();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Assign a trainer to Course");
            Console.WriteLine();
            Console.WriteLine("All trainers");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var tr in trainers)
            {
                Console.WriteLine($"{tr.Id,-15} - {tr.firstName,-5}{tr.lastName,-5}");
            }
            Console.WriteLine();

            var courses = courseService.GetAll();
            ViewCourse.PrintCourse(courses);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Give Trainer Id");
            int trId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Give Course Id");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            courseService.AttachTrainerToCourse(trId, courseId);
        }
        
    }
}
