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
        CourseRepository coursesService = new CourseRepository();
        TrainerRepository trainerService = new TrainerRepository();


        public void AssignStudentToCourse()
        {
            var students = studentService.GetAll();

            Console.WriteLine("Assign student to Movie");
            Console.WriteLine();
            foreach (var stu in students)
            {
                Console.WriteLine($"{}");
            }
        }
    }
}
