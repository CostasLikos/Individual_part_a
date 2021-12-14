using System.Collections.Generic;

namespace Costas_Part_A
{

    class Trainer
    {

        //CTOR--------------------------------------
        public Trainer(string firstName, string lastName, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }//CTOR-------------------------

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string subject;

        //NavProp
        public List<Assignment> assignments { get; set; } = new List<Assignment>();
        public List<Student> students { get; set; } = new List<Student>();
        public List<Course> courses { get; set; } = new List<Course>();


    }
}
