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
    class StudentController
    {
        AssignmentRepository assignmentService = new AssignmentRepository();
        StudentRepository studentService = new StudentRepository();
        CourseRepository courseService = new CourseRepository();
        TrainerRepository trainerService = new TrainerRepository();
        public void AssignAssignmentToStudent()
        {
            var asssignments = assignmentService.GetAll();

            Console.WriteLine("Assign an assignment to a Student");
            Console.WriteLine();
            Console.WriteLine("All assignmets");
            foreach (var ass in asssignments)
            {
                Console.WriteLine($"{ass.Id,-15} - {ass.title,-15}");
            }
            Console.WriteLine();

            var students = studentService.GetAll();
            ViewStudents.PrintStudent(students);

            Console.WriteLine("Give Assignment Id");
            int assId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Give Student Id");
            int stuId = Convert.ToInt32(Console.ReadLine());

            courseService.AttachAssignmentToCourse(assId, stuId);
        }
    }
}
