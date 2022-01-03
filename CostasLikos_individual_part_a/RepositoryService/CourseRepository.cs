using Costas_Part_A;
using CostasLikos_individual_part_a.Application;
using CostasLikos_individual_part_a.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.RepositoryService
{
    public class CourseRepository
    {
        
        public void AttachStudentToCourse(int studentId, int courseId)
        {
            var student = App.db.students.Find(x => x.Id == studentId);
            var course = App.db.courses.Find(x => x.Id == courseId);

            course.students.Add(student);

        }
        public void AttachAssignmentToCourse(int assignmentId, int courseId)
        {
            var assignment = App.db.assignments.Find(x => x.Id == assignmentId);
            var course = App.db.courses.Find(x => x.Id == courseId);

            course.assignments.Add(assignment);

        }
        public void AttachTrainerToCourse(int trainerId, int courseId)
        {
            var trainer = App.db.trainers.Find(x => x.Id == trainerId);
            var course = App.db.courses.Find(x => x.Id == courseId);

            course.trainers.Add(trainer);

        }

        public List<Course> GetAll()  
        {
            return App.db.courses;
        }
        public Course GetByID(int id)
        {
            var course = App.db.courses.Find(x => x.Id == id);
            return course;
        }

        public Course GetByName(string name)
        {
            
            var course = App.db.courses.FirstOrDefault(x => x.title == name);
            if (course is null)
            {
                throw new ArgumentNullException(nameof(course));
            }
            return course;
        }

        

       
    }
}
