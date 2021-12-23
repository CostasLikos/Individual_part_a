using Costas_Part_A;
using CostasLikos_individual_part_a.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.RepositoryService
{
    class AssignmentRepository
    {
        MyDatabase db = new MyDatabase();


        public Assignment GetByID(int id)
        {
            var assignment = db.assignments.Find(x => x.Id == id);
            return assignment;
        }

        public Assignment GetByName(string name)
        {
            var assignment = db.assignments.Find(x => x.title == name);
            return assignment;
        }

        public void Add(Assignment a)
        {
            int lastId = db.assignments[db.assignments.Count - 1].Id;
            a.Id = lastId + 1;
            db.assignments.Add(a);
        }
        public List<Assignment> GetAll()  
        {
            return db.assignments;
        }
    }
}
