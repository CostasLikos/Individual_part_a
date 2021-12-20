using Costas_Part_A;
using CostasLikos_individual_part_a.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.RepositoryService
{
    class CourseRepository
    {
        MyDatabase db = new MyDatabase();
        public void AttachStudentToCourse(int studentId, int courseId)
        {
            var student = db.students.Find(x => x.Id == studentId);
            var course = db.courses.Find(x => x.Id == courseId);

            course.students.Add(student);

        }

        public List<Course> GetAll()  
        {
            return db.courses;
        }
        public Course GetByID(int id)
        {
            var course = db.courses.Find(x => x.Id == id);
            return course;
        }

        public Course GetByName(string name)
        {
            var course = db.courses.Find(x => x.title == name);
            return course;
        }

        public void Add(Course c)   
        {
            int lastId = db.courses[db.courses.Count - 1].Id;
            c.Id = lastId + 1;
            db.courses.Add(c);
        }

        public void Edit(int id, Movie m)
        {
            //Edit
        }

        public void Delete(int id)
        {
            //Delete
        }
    }
}
