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
        public List<Student> GetAll()  //4
        {
            return db.students;
        }
    }
}
