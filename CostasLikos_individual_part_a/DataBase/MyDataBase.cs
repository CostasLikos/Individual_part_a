using Costas_Part_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.DataBase
{
    class MyDataBase
    {
        public List<Student> students = new List<Student>();

        public List<Course> courses = new List<Course>();

        public List<Assignment> assignments = new List<Assignment>();

        public List<Trainer> trainers = new List<Trainer>();

        //Feed-----

        //Students --------------
        Student s1 = new Student("Costas", "Likos", new DateTime(1993,5,3),650);
        Student s2 = new Student("Nick", "Tatopoulos", new DateTime(1984,9,25),1050);
        Student s3 = new Student("Gorge", "Ethan", new DateTime(1956,4,24),1250);
        Student s4 = new Student("Leo", "Sith", new DateTime(1936,12,1),2500);
        Student s5 = new Student("Debrah", "Lecopte", new DateTime(1989,8,5),800);
        Student s6 = new Student("Astrid", "Meckhah", new DateTime(1999,4,13),2500);
        Student s7 = new Student("Alir", "Abhan", new DateTime(1987,1,11),0);
        Student s8 = new Student("Ektor", "Gatsos", new DateTime(1986,4,2),2500);
        Student s9 = new Student("Nikos", "Korompos", new DateTime(1912,1,2),1650);
        Student s10 = new Student("Alis", "Smith", new DateTime(1956,11,7),1050);
        Student s11 = new Student("Jim", "Duncan", new DateTime(1974,4,5),2250);
        Student s12 = new Student("Norse", "Ibeleth", new DateTime(1986,5,12),2250);
        Student s13 = new Student("Archus", "Ravendreth", new DateTime(1985,5,10),650);
        Student s14 = new Student("Melina", "Pappa", new DateTime(1984,4,2),650);
        Student s15 = new Student("Millorn", "Ashenborn", new DateTime(1996,5,28),0);
        Student s16 = new Student("Ellon", "Bus", new DateTime(1997,7,27),0);
        Student s17 = new Student("Yahitero", "Mizukaya", new DateTime(1991,9,16),2250);
        Student s18 = new Student("Kira", "Don", new DateTime(1998,7,20),150);
        Student s19 = new Student("Naruto", "Uzumaki", new DateTime(1956,6,18),2250);
        Student s20 = new Student("Dexter", "Morgan", new DateTime(1972,3,19),2500);

        //Courses-----------------
        Course c1 = new Course();

        
    }
}
