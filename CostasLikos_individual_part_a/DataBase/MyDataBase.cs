using Costas_Part_A;
using CostasLikos_individual_part_a.DataBase.PairClasses;
using CostasLikos_individual_part_a.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.DataBase
{
    class MyDatabase
    {

        public List<Student> students { get; set; } 

        public List<Course> courses { get; set; } 

        public List<Assignment> assignments { get; set; }

        public List<Trainer> trainers { get; set; }


        public MyDatabase()
        {
            #region Seeding Students
            //Feed-----

            //Students --------------
            Student s1 = new Student("Costas", "Likos", new DateTime(1993, 5, 3), 650);
            Student s2 = new Student("Nick", "Tatopoulos", new DateTime(1984, 9, 25), 1050);
            Student s3 = new Student("Gorge", "Ethan", new DateTime(1956, 4, 24), 1250);
            Student s4 = new Student("Leo", "Sith", new DateTime(1936, 12, 1), 2500);
            Student s5 = new Student("Debrah", "Lecopte", new DateTime(1989, 8, 5), 800);
            Student s6 = new Student("Astrid", "Meckhah", new DateTime(1999, 4, 13), 2500);
            Student s7 = new Student("Alir", "Abhan", new DateTime(1987, 1, 11), 0);
            Student s8 = new Student("Ektor", "Gatsos", new DateTime(1986, 4, 2), 2500);
            Student s9 = new Student("Nikos", "Korompos", new DateTime(1912, 1, 2), 1650);
            Student s10 = new Student("Alis", "Smith", new DateTime(1956, 11, 7), 1050);
            Student s11 = new Student("Jim", "Duncan", new DateTime(1974, 4, 5), 2250);
            Student s12 = new Student("Norse", "Ibeleth", new DateTime(1986, 5, 12), 2250);
            Student s13 = new Student("Archus", "Ravendreth", new DateTime(1985, 5, 10), 650);
            Student s14 = new Student("Melina", "Pappa", new DateTime(1984, 4, 2), 650);
            Student s15 = new Student("Millorn", "Ashenborn", new DateTime(1996, 5, 28), 0);
            Student s16 = new Student("Ellon", "Bus", new DateTime(1997, 7, 27), 0);
            Student s17 = new Student("Yahitero", "Mizukaya", new DateTime(1991, 9, 16), 2250);
            Student s18 = new Student("Kira", "Don", new DateTime(1998, 7, 20), 150);
            Student s19 = new Student("Naruto", "Uzumaki", new DateTime(1956, 6, 18), 2250);
            Student s20 = new Student("Dexter", "Morgan", new DateTime(1972, 3, 19), 2500);
            #endregion
            //Courses-----------------
            Course c1 = new Course("Csharp", "CB15", TypeEnum.PartTime, new DateTime(2021, 1, 1), new DateTime(2021, 7, 1));
            Course c2 = new Course("Java", "CB14", TypeEnum.FullTime, new DateTime(2020, 1, 1), new DateTime(2020, 7, 1));
            Course c3 = new Course("JavaScript", "CB12", TypeEnum.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 7, 1));
            Course c4 = new Course("Python", "CB11", TypeEnum.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 7, 1));
            Course c5 = new Course("Kobol", "CB08", TypeEnum.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 7, 1));
            Course c6 = new Course("C++", "CB14", TypeEnum.PartTime, new DateTime(2020, 1, 1), new DateTime(2019, 7, 1));


            //Assingment----------------------
            Assignment a1 = new Assignment("Calculator", "Make a functional calculator", new DateTime(0, 0, 30), 20, 80);
            Assignment a2 = new Assignment("Card game", "Make a card game with 52 cards", new DateTime(0, 0, 15), 30, 70);
            Assignment a3 = new Assignment("Site", "Make your own site", new DateTime(0, 0, 10), 10, 90);
            Assignment a4 = new Assignment("View", "Front-end assingment", new DateTime(0, 0, 10), 10, 90);
            Assignment a5 = new Assignment("Refactoring", "Refactor one of your previous assingments", new DateTime(0, 0, 20), 10, 90);
            Assignment a6 = new Assignment("Tik Tak Toe", "Construct the well known game", new DateTime(0, 0, 20), 10, 90);
            Assignment a7 = new Assignment("DataBase", "Make a full functional Database", new DateTime(0, 0, 20), 10, 90);
            Assignment a8 = new Assignment("Indinidual Project", "Architecture - Contact your Trainer.", new DateTime(0, 2, 0), 10, 90);
            Assignment a9 = new Assignment("Final Project", "Show us your work!", new DateTime(0, 3, 0), 10, 90);

            //Trainers-------------------------
            Trainer t1 = new Trainer("Ellias", "Gweanarth", "FrondEnd");
            Trainer t2 = new Trainer("Nicky", "Something", "BackEnd");
            Trainer t3 = new Trainer("Elun", "Asshen", "DataBases");
            Trainer t4 = new Trainer("Ned", "Alison", "DotNet");
            Trainer t5 = new Trainer("Dimitris", "Papas", "Interfaces");

            //Polulate Data

            students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            assignments = new List<Assignment>() { a1,a2,a3,a4,a5,a6,a7,a8,a9 };
            courses = new List<Course>() {c1,c2,c3,c4,c5,c6 };
            trainers = new List<Trainer>() { t1, t2, t3,t4,t5 };

            #region Pairing courses
            //PAIRING===========================
            //==================================

            //Csharp - c1
              
            StudentsPerCourse.Pair(s1,c1);
            StudentsPerCourse.Pair(s2,c1);
            StudentsPerCourse.Pair(s3,c1);
            StudentsPerCourse.Pair(s4,c1);
            StudentsPerCourse.Pair(s5,c1);
            StudentsPerCourse.Pair(s6,c1);
            StudentsPerCourse.Pair(s7,c1);

            AssingmentsPerCourse.Pair(a1, c1);
            AssingmentsPerCourse.Pair(a2, c1);
            AssingmentsPerCourse.Pair(a3, c1);
            AssingmentsPerCourse.Pair(a5, c1);
            AssingmentsPerCourse.Pair(a7, c1);
            AssingmentsPerCourse.Pair(a8, c1);
            AssingmentsPerCourse.Pair(a9, c1);

            TrainersPerCourse.Pair(t1,c1);
            TrainersPerCourse.Pair(t2,c1);
            TrainersPerCourse.Pair(t3,c1);
            TrainersPerCourse.Pair(t4,c1);

            //Java - c2

            StudentsPerCourse.Pair(s10,c2);
            StudentsPerCourse.Pair(s12,c2);
            StudentsPerCourse.Pair(s13,c2);
            StudentsPerCourse.Pair(s14,c2);
            StudentsPerCourse.Pair(s15,c2);
            StudentsPerCourse.Pair(s6,c2);
            StudentsPerCourse.Pair(s7,c2);

            AssingmentsPerCourse.Pair(a1, c2);
            AssingmentsPerCourse.Pair(a2, c2);
            AssingmentsPerCourse.Pair(a4, c2);
            AssingmentsPerCourse.Pair(a5, c2);
            AssingmentsPerCourse.Pair(a6, c2);
            AssingmentsPerCourse.Pair(a8, c2);
            AssingmentsPerCourse.Pair(a9, c2);

            TrainersPerCourse.Pair(t1,c2);
            TrainersPerCourse.Pair(t2,c2);
            TrainersPerCourse.Pair(t3,c2);
            TrainersPerCourse.Pair(t5,c2);

            //JavaScript - c3

            StudentsPerCourse.Pair(s18,c3);
            StudentsPerCourse.Pair(s19,c3);
            StudentsPerCourse.Pair(s20,c3);
            StudentsPerCourse.Pair(s14,c3);
            StudentsPerCourse.Pair(s15,c3);
            StudentsPerCourse.Pair(s16,c3);
            StudentsPerCourse.Pair(s17,c3);

            AssingmentsPerCourse.Pair(a3, c3);
            AssingmentsPerCourse.Pair(a2, c3);
            AssingmentsPerCourse.Pair(a4, c3);
            AssingmentsPerCourse.Pair(a5, c3);
            AssingmentsPerCourse.Pair(a7, c3);
            AssingmentsPerCourse.Pair(a8, c3);
            AssingmentsPerCourse.Pair(a9, c3);

            TrainersPerCourse.Pair(t4,c3);
            TrainersPerCourse.Pair(t2,c3);
            TrainersPerCourse.Pair(t3,c3);
            TrainersPerCourse.Pair(t5,c3);


            //Python - c4

            StudentsPerCourse.Pair(s18,c4);
            StudentsPerCourse.Pair(s9,c4);
            StudentsPerCourse.Pair(s20,c4);
            StudentsPerCourse.Pair(s1,c4);
            

            AssingmentsPerCourse.Pair(a3, c4);
            AssingmentsPerCourse.Pair(a1, c4);
            AssingmentsPerCourse.Pair(a4, c4);
            AssingmentsPerCourse.Pair(a5, c4);
            AssingmentsPerCourse.Pair(a2, c4);
            AssingmentsPerCourse.Pair(a8, c4);
            AssingmentsPerCourse.Pair(a9, c4);

            TrainersPerCourse.Pair(t4,c4);
            TrainersPerCourse.Pair(t2,c4);

             //Kobol - c5
              
            StudentsPerCourse.Pair(s1,c5);
            StudentsPerCourse.Pair(s2,c5);
            StudentsPerCourse.Pair(s3,c5);
            StudentsPerCourse.Pair(s4,c5);
            StudentsPerCourse.Pair(s5,c5);

            AssingmentsPerCourse.Pair(a1, c5);
            AssingmentsPerCourse.Pair(a2, c5);
            AssingmentsPerCourse.Pair(a3, c5);
            AssingmentsPerCourse.Pair(a5, c5);
            AssingmentsPerCourse.Pair(a7, c5);
            AssingmentsPerCourse.Pair(a8, c5);
            AssingmentsPerCourse.Pair(a9, c5);

            TrainersPerCourse.Pair(t1,c5);
            TrainersPerCourse.Pair(t2,c5);

            //C++ - c6
              
            StudentsPerCourse.Pair(s11,c6);
            StudentsPerCourse.Pair(s12,c6);
            StudentsPerCourse.Pair(s13,c6);
            StudentsPerCourse.Pair(s14,c6);
            StudentsPerCourse.Pair(s15,c6);
            StudentsPerCourse.Pair(s16,c6);
            StudentsPerCourse.Pair(s17,c6);

            AssingmentsPerCourse.Pair(a1, c6);
            AssingmentsPerCourse.Pair(a2, c6);
            AssingmentsPerCourse.Pair(a3, c6);
            AssingmentsPerCourse.Pair(a5, c6);
            AssingmentsPerCourse.Pair(a7, c6);
            AssingmentsPerCourse.Pair(a8, c6);
            AssingmentsPerCourse.Pair(a9, c6);

            TrainersPerCourse.Pair(t1,c6);
            TrainersPerCourse.Pair(t2,c6);
            TrainersPerCourse.Pair(t3,c6);
            TrainersPerCourse.Pair(t4,c6);
            TrainersPerCourse.Pair(t5,c6);
           

            




            #endregion



        }
    }
}
