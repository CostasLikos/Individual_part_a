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
     public class AssignmentRepository
    {
       
        public Assignment GetByID(int id)
        {
            var assignment = App.db.assignments.Find(x => x.Id == id);
            if (assignment is null)
            {
                throw new ArgumentNullException(nameof(assignment));
            }
            return assignment;
        }

        public Assignment GetByName(string name)
        {
            var assignment = App.db.assignments.Find(x => x.title == name);
            if (assignment is null)
            {
                throw new ArgumentNullException(nameof(assignment));
            }
            return assignment;
        }

       
        public List<Assignment> GetAll()  
        {
            return App.db.assignments;
        }
    }
}
