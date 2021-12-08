using CostasLikos_individual_part_a.Enums;
using System;

namespace Costas_Part_A
{
    class Course
    {

        //CTOR--------------------------
        public Course(TitleEnum title, StreamEnum stream, TypeEnum type, DateTime startDate, DateTime endDate)
        {
            this.title = title;
            this.stream = stream;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }//CTOR------------------------------------

        public TitleEnum title { get; set; }
        public StreamEnum stream { get; set; }
        public TypeEnum type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
