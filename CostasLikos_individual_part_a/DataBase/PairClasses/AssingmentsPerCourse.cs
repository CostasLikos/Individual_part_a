using Costas_Part_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.DataBase.PairClasses
{
    class AssingmentsPerCourse
    {
        public static void Pair(Assignment a, Course c)
        {
            c.assignments.Add(a);
            a.courses.Add(c);
        }
    }
}
