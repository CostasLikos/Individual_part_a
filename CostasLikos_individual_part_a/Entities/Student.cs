using System;
using System.Collections.Generic;

namespace Costas_Part_A
{
     public class Student
    {
        //CTOR-------------------------
        public Student(int Id, string firstName, string lastName, DateTime dateOfBirth, double fees)
        {
            this.Id = Id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.fees = fees;
        }//CTOR-------------------------

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double fees { get; set; }

        //public Assignment assignment {get; set;}

        //NavProp
        public List<Course> courses { get; set; } = new List<Course>();
        public List<Assignment> assignments { get; set; } = new List<Assignment>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
    }
}
