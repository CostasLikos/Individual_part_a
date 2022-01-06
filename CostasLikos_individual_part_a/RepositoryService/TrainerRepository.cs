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
    public class TrainerRepository
    {
        
        public Trainer GetByID(int id)
        {
            var trainer = App.db.trainers.Find(x => x.Id == id);
            if (trainer is null)
            {
                throw new ArgumentNullException(nameof(trainer));
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Item you filtered with ID: {id} is:\n\n   {trainer.Id}  -  {trainer.firstName} {trainer.lastName}");
            Console.ResetColor();
            return trainer;
        }

        public Trainer GetByName(string name)
        {
            var trainer = App.db.trainers.Find(x => x.firstName == name);
            if (trainer is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no item with these creteria :{name}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Item you filtered with name: {name} is:\n\n   {trainer.Id}  -  {trainer.firstName} {trainer.lastName}");
            Console.ResetColor();
            return trainer;
        }
        public Trainer GetByLastName(string name)
        {
            var trainer = App.db.trainers.Find(x => x.lastName == name);
            if (trainer is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no item with these creteria :{name}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Item you filtered with name: {name} is:\n\n   {trainer.Id}  -  {trainer.firstName} {trainer.lastName}");
            Console.ResetColor();
            return trainer;
        }

       
        public List<Trainer> GetAll()  
        {
            return App.db.trainers;
        }
    }
}
