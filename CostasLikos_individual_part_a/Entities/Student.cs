using System;

namespace Costas_Part_A
{
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
}
