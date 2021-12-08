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


    }
}
