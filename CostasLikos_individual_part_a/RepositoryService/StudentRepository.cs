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
    public class StudentRepository
    {
        

        public void AttachAssignmentToStudent(int assignmentId, int studentId)
        {
            var assignment = App.db.assignments.Find(x => x.Id == assignmentId);
            var student = App.db.students.Find(x => x.Id == studentId);

            student.assignments.Add(assignment);

        }

        public Student GetByID(int id)
        {
            var student = App.db.students.Find(x => x.Id == id);
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            return student;
        }

        public Student GetByName(string name)
        {
            var student = App.db.students.Find(x => x.firstName == name);
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            return student;
        }
        public Student GetByLastName(string name)
        {
            var student = App.db.students.Find(x => x.lastName == name);
            if (student is null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            return student;


        }


        public List<Student> GetAll()  
        {
            return App.db.students;
        }
    }
}
