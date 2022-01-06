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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no item with these creteria :{id}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Item you filtered with ID: {id} is:\n\n   {assignment.Id}  -  {assignment.title}");
            Console.ResetColor();
            return assignment;
        }

        public Assignment GetByName(string name)
        {
            var assignment = App.db.assignments.Find(x => x.title == name);
            if (assignment is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no item with these creteria :{name}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Item you filtered with name: {name} is:\n\n   {assignment.Id}  -  {assignment.title}");
            Console.ResetColor();
            return assignment;
        }

       
        public List<Assignment> GetAll()  
        {
            return App.db.assignments;
        }
    }
}
