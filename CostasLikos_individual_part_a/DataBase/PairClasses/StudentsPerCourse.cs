using Costas_Part_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.DataBase.PairClasses
{
    class StudentsPerCourse
    {
        public static void Pair(Student s, Course c)
        {
            c.students.Add(s);
            s.courses.Add(c);
        }
    }
}
