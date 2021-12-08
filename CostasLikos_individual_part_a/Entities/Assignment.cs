using System;

namespace Costas_Part_A
{
    class Assignment
    {
        //CTOR--------------------------
        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            this.title = title;
            this.description = description;
            this.subDateTime = subDateTime;
            this.oralMark = oralMark;
            this.totalMark = totalMark;
        }//CTOR--------------------------

        public string title { get; set; }
        public string description { get; set; }
        public DateTime subDateTime { get; set; }
        public int oralMark { get; set; }
        public int totalMark { get; set; }
    }
}
