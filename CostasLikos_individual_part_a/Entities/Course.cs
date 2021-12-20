using CostasLikos_individual_part_a.Enums;
using System;
using System.Collections.Generic;

namespace Costas_Part_A
{
    class Course
    {

        //CTOR--------------------------
        public Course(int Id, string title, string stream, TypeEnum type, DateTime startDate, DateTime endDate)
        {
            this.Id = Id;
            this.title = title;
            this.stream = stream;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }//CTOR------------------------------------

        public int Id { get; set; }
        public string title { get; set; }
        public string stream { get; set; }
        public TypeEnum type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

      //public DateTime SetDate()
      //{
      //    if (type = TypeEnum.FullTime)
      //    {
      //        //an balei full +6
      //    }
      //}

        //NavProp
        public List<Assignment> assignments { get; set; } = new List<Assignment>();
        public List<Student> students { get; set; } = new List<Student>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
    }
}
