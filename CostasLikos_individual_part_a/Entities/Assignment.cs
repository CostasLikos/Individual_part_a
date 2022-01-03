using System;
using System.Collections.Generic;

namespace Costas_Part_A
{
     public class Assignment
    {
        //CTOR--------------------------
        public Assignment(int Id , string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            this.Id = Id;
            this.title = title;
            this.description = description;
            this.subDateTime = subDateTime;
            this.oralMark = oralMark;
            this.totalMark = totalMark;
        }//CTOR--------------------------

        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime subDateTime { get; set; }
        public int oralMark { get; set; }
        public int totalMark { get; set; }

        //NavProp
        public List<Course> courses { get; set; } = new List<Course>();
        public List<Student> students { get; set; } = new List<Student>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
    }
}
