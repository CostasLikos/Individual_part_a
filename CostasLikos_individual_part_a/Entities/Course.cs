using System;

namespace Costas_Part_A
{
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
}
