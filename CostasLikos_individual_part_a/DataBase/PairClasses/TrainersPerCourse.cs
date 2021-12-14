using Costas_Part_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.DataBase.PairClasses
{
    class TrainersPerCourse
    {
        public static void Pair(Trainer t, Course c)
        {
            c.trainers.Add(t);
            t.courses.Add(c);
        }

    }
}
