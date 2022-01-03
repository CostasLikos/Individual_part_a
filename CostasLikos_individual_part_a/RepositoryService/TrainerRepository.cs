using Costas_Part_A;
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
        MyDatabase db = new MyDatabase();

        public Trainer GetByID(int id)
        {
            var trainer = db.trainers.Find(x => x.Id == id);
            return trainer;
        }

        public Trainer GetByName(string name)
        {
            var trainer = db.trainers.Find(x => x.firstName == name);
            return trainer;
        }
        public Trainer GetByLastName(string name)
        {
            var trainer = db.trainers.Find(x => x.lastName == name);
            return trainer;
        }

       
        public List<Trainer> GetAll()  
        {
            return db.trainers;
        }
    }
}
