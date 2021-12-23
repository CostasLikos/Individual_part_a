using Costas_Part_A;
using CostasLikos_individual_part_a.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.RepositoryService
{
    class StudentRepository
    {
        MyDatabase db = new MyDatabase();

        public void AttachAssignmentToStudent(int assignmentId, int studentId)
        {
            var assignment = db.assignments.Find(x => x.Id == assignmentId);
            var student = db.students.Find(x => x.Id == studentId);

            student.assignments.Add(assignment);

        }

        public Student GetByID(int id)
        {
            var student = db.students.Find(x => x.Id == id);
            return student;
        }

        public Student GetByName(string name)
        {
            var students = db.students.Find(x => x.firstName == name);
            
            return students;
        }
        public Student GetByLastName(string name)
        {
            var students = db.students.Find(x => x.lastName == name);

            return students;
        }

        
        public List<Student> GetAll()  //4
        {
            return db.students;
        }
    }
}
