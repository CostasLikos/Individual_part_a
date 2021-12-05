using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arxi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Course
    {

        //CTOR--------------------------
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            this.title = title;
            this.stream = stream;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }//CTOR------------------------------------

        public string title { get; set; }
        public string stream { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
    class Trainer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string subject;


        //CTOR--------------------------------------
        public Trainer(string firstName, string lastName, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }//CTOR-------------------------
    }
    class Student
    {
        //CTOR-------------------------
        public Student(string firstName, string lastName, DateTime dateOfBirth, double fees)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.fees = fees;
        }//CTOR-------------------------

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double fees { get; set; }
    }
    class Assignment
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime subDateTime { get; set; }
        public int oralMark { get; set; }
        public int totalMark { get; set; }
    }
}
