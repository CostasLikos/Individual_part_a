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
            Student s1 = new Student(1,"Costas", "Likos", new DateTime(1993, 5, 3), 650);
            Student s2 = new Student(2,"Nick", "Tatopoulos", new DateTime(1984, 9, 25), 1050);
            Student s3 = new Student(3,"Gorge", "Ethan", new DateTime(1956, 4, 24), 1250);
            Student s4 = new Student(4,"Leo", "Sith", new DateTime(1936, 12, 1), 2500);
            Student s5 = new Student(5,"Debrah", "Lecopte", new DateTime(1989, 8, 5), 800);
            Student s6 = new Student(6,"Astrid", "Meckhah", new DateTime(1999, 4, 13), 2500);
            Student s7 = new Student(7,"Alir", "Abhan", new DateTime(1987, 1, 11), 0);
            Student s8 = new Student(8,"Ektor", "Gatsos", new DateTime(1986, 4, 2), 2500);
            Student s9 = new Student(9,"Nikos", "Korompos", new DateTime(1912, 1, 2), 1650);
            Student s10 = new Student(10,"Alis", "Smith", new DateTime(1956, 11, 7), 1050);
            Student s11 = new Student(11,"Jim", "Duncan", new DateTime(1974, 4, 5), 2250);
            Student s12 = new Student(12,"Norse", "Ibeleth", new DateTime(1986, 5, 12), 2250);
            Student s13 = new Student(13,"Archus", "Ravendreth", new DateTime(1985, 5, 10), 650);
            Student s14 = new Student(14,"Melina", "Pappa", new DateTime(1984, 4, 2), 650);
            Student s15 = new Student(15,"Millorn", "Ashenborn", new DateTime(1996, 5, 28), 0);
            Student s16 = new Student(16,"Ellon", "Bus", new DateTime(1997, 7, 27), 0);
            Student s17 = new Student(17,"Yahitero", "Mizukaya", new DateTime(1991, 9, 16), 2250);
            Student s18 = new Student(18,"Kira", "Don", new DateTime(1998, 7, 20), 150);
            Student s19 = new Student(19,"Naruto", "Uzumaki", new DateTime(1956, 6, 18), 2250);
            Student s20 = new Student(20,"Dexter", "Morgan", new DateTime(1972, 3, 19), 2500);
            #endregion
            //Courses-----------------
            Course c1 = new Course(1,"Csharp", "CB15", TypeEnum.PartTime, new DateTime(2021, 1, 1), new DateTime(2021, 7, 1));
            Course c2 = new Course(2,"Java", "CB14", TypeEnum.FullTime, new DateTime(2020, 1, 1), new DateTime(2020, 7, 1));
            Course c3 = new Course(3,"JavaScript", "CB12", TypeEnum.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 7, 1));
            Course c4 = new Course(4,"Python", "CB11", TypeEnum.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 7, 1));
            Course c5 = new Course(5,"Cobol", "CB08", TypeEnum.PartTime, new DateTime(2019, 1, 1), new DateTime(2019, 7, 1));
            Course c6 = new Course(6,"C++", "CB14", TypeEnum.PartTime, new DateTime(2020, 1, 1), new DateTime(2019, 7, 1));


            //Assingment----------------------
            Assignment a1 = new Assignment(1,"Calculator", "Make a functional calculator", new DateTime(2022, 12, 30), 20, 80);
            Assignment a2 = new Assignment(2,"Card game", "Make a card game with 52 cards", new DateTime(2022, 02, 15), 30, 70);
            Assignment a3 = new Assignment(3,"Site", "Make your own site", new DateTime(2022, 02, 10), 10, 90);
            Assignment a4 = new Assignment(4,"View", "Front-end assingment", new DateTime(2022, 02, 10), 10, 90);
            Assignment a5 = new Assignment(5,"Refactoring", "Refactor one of your previous assingments", new DateTime(2022, 02, 15), 10, 90);
            Assignment a6 = new Assignment(6,"Tik Tak Toe", "Construct the well known game", new DateTime(2022, 04, 20), 10, 90);
            Assignment a7 = new Assignment(7,"DataBase", "Make a full functional Database", new DateTime(2022, 01, 20), 10, 90);
            Assignment a8 = new Assignment(8,"Indinidual Project", "Architecture - Contact your Trainer.", new DateTime(2022, 03, 20), 10, 90);
            Assignment a9 = new Assignment(9,"Final Project", "Show us your work!", new DateTime(2022, 04, 20), 10, 90);

            //Trainers-------------------------
            Trainer t1 = new Trainer(1,"Ellias", "Gweanarth", "FrondEnd");
            Trainer t2 = new Trainer(2,"Nicky", "Something", "BackEnd");
            Trainer t3 = new Trainer(3,"Elun", "Asshen", "DataBases");
            Trainer t4 = new Trainer(4,"Ned", "Alison", "DotNet");
            Trainer t5 = new Trainer(5,"Dimitris", "Papas", "Interfaces");

            //Polulate Data

            students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            assignments = new List<Assignment>() { a1,a2,a3,a4,a5,a6,a7,a8,a9 };
            courses = new List<Course>() {c1,c2,c3,c4,c5,c6 };
            trainers = new List<Trainer>() { t1, t2, t3,t4,t5 };

            #region Pairing
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

            #region Assingment Per Student
            //Assingment Per Student
            //s1
            AssingmentsPerStudent.Pair(a1,s1);
            AssingmentsPerStudent.Pair(a2,s1);
            AssingmentsPerStudent.Pair(a3,s1);
            AssingmentsPerStudent.Pair(a5,s1);
            AssingmentsPerStudent.Pair(a6,s1);
            AssingmentsPerStudent.Pair(a7,s1);
            AssingmentsPerStudent.Pair(a8,s1);
            AssingmentsPerStudent.Pair(a9,s1);

            //s2
            AssingmentsPerStudent.Pair(a1, s2);
            AssingmentsPerStudent.Pair(a2, s2);
            AssingmentsPerStudent.Pair(a3, s2);
            AssingmentsPerStudent.Pair(a5, s2);
            AssingmentsPerStudent.Pair(a6, s2);
            AssingmentsPerStudent.Pair(a7, s2);
            AssingmentsPerStudent.Pair(a8, s2);
            AssingmentsPerStudent.Pair(a9, s2);

            //s3
            AssingmentsPerStudent.Pair(a1, s3);
            AssingmentsPerStudent.Pair(a2, s3);
            AssingmentsPerStudent.Pair(a3, s3);
            AssingmentsPerStudent.Pair(a4, s3);
            AssingmentsPerStudent.Pair(a5, s3);
            AssingmentsPerStudent.Pair(a7, s3);
            AssingmentsPerStudent.Pair(a8, s3);
            AssingmentsPerStudent.Pair(a9, s3);

            //s4
            AssingmentsPerStudent.Pair(a1, s4);
            AssingmentsPerStudent.Pair(a2, s4);
            AssingmentsPerStudent.Pair(a3, s4);
            AssingmentsPerStudent.Pair(a4, s4);
            AssingmentsPerStudent.Pair(a5, s4);
            AssingmentsPerStudent.Pair(a7, s4);
            AssingmentsPerStudent.Pair(a8, s4);
            AssingmentsPerStudent.Pair(a9, s4);

            //s5
            AssingmentsPerStudent.Pair(a1, s5);
            AssingmentsPerStudent.Pair(a2, s5);
            AssingmentsPerStudent.Pair(a3, s5);
            AssingmentsPerStudent.Pair(a5, s5);
            AssingmentsPerStudent.Pair(a7, s5);
            AssingmentsPerStudent.Pair(a8, s5);
            AssingmentsPerStudent.Pair(a9, s5);
            
            //s6
            AssingmentsPerStudent.Pair(a1, s6);
            AssingmentsPerStudent.Pair(a2, s6);
            AssingmentsPerStudent.Pair(a3, s6);
            AssingmentsPerStudent.Pair(a5, s6);
            AssingmentsPerStudent.Pair(a7, s6);
            AssingmentsPerStudent.Pair(a8, s6);
            AssingmentsPerStudent.Pair(a9, s6);

            //s7
            AssingmentsPerStudent.Pair(a1, s7);
            AssingmentsPerStudent.Pair(a2, s7);
            AssingmentsPerStudent.Pair(a3, s7);
            AssingmentsPerStudent.Pair(a4, s7);
            AssingmentsPerStudent.Pair(a5, s7);
            AssingmentsPerStudent.Pair(a7, s7);
            AssingmentsPerStudent.Pair(a8, s7);
            AssingmentsPerStudent.Pair(a9, s7);

            //s8
            AssingmentsPerStudent.Pair(a1, s8);
            AssingmentsPerStudent.Pair(a2, s8);
            AssingmentsPerStudent.Pair(a3, s8);
            AssingmentsPerStudent.Pair(a5, s8);
            AssingmentsPerStudent.Pair(a7, s8);
            AssingmentsPerStudent.Pair(a8, s8);
            AssingmentsPerStudent.Pair(a9, s8);

            //s9
            AssingmentsPerStudent.Pair(a1, s9);
            AssingmentsPerStudent.Pair(a2, s9);
            AssingmentsPerStudent.Pair(a3, s9);
            AssingmentsPerStudent.Pair(a5, s9);
            AssingmentsPerStudent.Pair(a7, s9);
            AssingmentsPerStudent.Pair(a8, s9);
            AssingmentsPerStudent.Pair(a9, s9);

            //s10
            AssingmentsPerStudent.Pair(a1, s10);
            AssingmentsPerStudent.Pair(a2, s10);
            AssingmentsPerStudent.Pair(a3, s10);
            AssingmentsPerStudent.Pair(a5, s10);
            AssingmentsPerStudent.Pair(a7, s10);
            AssingmentsPerStudent.Pair(a8, s10);
            AssingmentsPerStudent.Pair(a9, s10);
            //s11
            AssingmentsPerStudent.Pair(a1, s11);
            AssingmentsPerStudent.Pair(a2, s11);
            AssingmentsPerStudent.Pair(a3, s11);
            AssingmentsPerStudent.Pair(a5, s11);
            AssingmentsPerStudent.Pair(a7, s11);
            AssingmentsPerStudent.Pair(a8, s11);
            AssingmentsPerStudent.Pair(a9, s11);

            //s12
            AssingmentsPerStudent.Pair(a1, s12);
            AssingmentsPerStudent.Pair(a2, s12);
            AssingmentsPerStudent.Pair(a3, s12);
            AssingmentsPerStudent.Pair(a5, s12);
            AssingmentsPerStudent.Pair(a7, s12);
            AssingmentsPerStudent.Pair(a8, s12);
            AssingmentsPerStudent.Pair(a9, s12);

            //s13
            AssingmentsPerStudent.Pair(a1, s13);
            AssingmentsPerStudent.Pair(a2, s13);
            AssingmentsPerStudent.Pair(a3, s13);
            AssingmentsPerStudent.Pair(a5, s13);
            AssingmentsPerStudent.Pair(a7, s13);
            AssingmentsPerStudent.Pair(a8, s13);
            AssingmentsPerStudent.Pair(a9, s13);
            //s14
            AssingmentsPerStudent.Pair(a1, s14);
            AssingmentsPerStudent.Pair(a2, s14);
            AssingmentsPerStudent.Pair(a3, s14);
            AssingmentsPerStudent.Pair(a5, s14);
            AssingmentsPerStudent.Pair(a7, s14);
            AssingmentsPerStudent.Pair(a8, s14);
            AssingmentsPerStudent.Pair(a9, s14);

            //s15
            AssingmentsPerStudent.Pair(a1, s15);
            AssingmentsPerStudent.Pair(a2, s15);
            AssingmentsPerStudent.Pair(a3, s15);
            AssingmentsPerStudent.Pair(a5, s15);
            AssingmentsPerStudent.Pair(a6, s15);
            AssingmentsPerStudent.Pair(a7, s15);
            AssingmentsPerStudent.Pair(a8, s15);
            AssingmentsPerStudent.Pair(a9, s15);

            //s16
            AssingmentsPerStudent.Pair(a1, s16);
            AssingmentsPerStudent.Pair(a2, s16);
            AssingmentsPerStudent.Pair(a3, s16);
            AssingmentsPerStudent.Pair(a5, s16);
            AssingmentsPerStudent.Pair(a7, s16);
            AssingmentsPerStudent.Pair(a8, s16);
            AssingmentsPerStudent.Pair(a9, s16);

            //s17
            AssingmentsPerStudent.Pair(a1, s17);
            AssingmentsPerStudent.Pair(a2, s17);
            AssingmentsPerStudent.Pair(a3, s17);
            AssingmentsPerStudent.Pair(a5, s17);
            AssingmentsPerStudent.Pair(a6, s17);
            AssingmentsPerStudent.Pair(a7, s17);
            AssingmentsPerStudent.Pair(a8, s17);
            AssingmentsPerStudent.Pair(a9, s17);
            //s18
            AssingmentsPerStudent.Pair(a1, s18);
            AssingmentsPerStudent.Pair(a2, s18);
            AssingmentsPerStudent.Pair(a3, s18);
            AssingmentsPerStudent.Pair(a5, s18);
            AssingmentsPerStudent.Pair(a7, s18);
            AssingmentsPerStudent.Pair(a8, s18);
            AssingmentsPerStudent.Pair(a9, s18);

            //s19
            AssingmentsPerStudent.Pair(a1, s19);
            AssingmentsPerStudent.Pair(a2, s19);
            AssingmentsPerStudent.Pair(a3, s19);
            AssingmentsPerStudent.Pair(a5, s19);
            AssingmentsPerStudent.Pair(a6, s19);
            AssingmentsPerStudent.Pair(a7, s19);
            AssingmentsPerStudent.Pair(a8, s19);
            AssingmentsPerStudent.Pair(a9, s19);

            //s20
            AssingmentsPerStudent.Pair(a1, s20);
            AssingmentsPerStudent.Pair(a2, s20);
            AssingmentsPerStudent.Pair(a3, s20);
            AssingmentsPerStudent.Pair(a5, s20);
            AssingmentsPerStudent.Pair(a7, s20);
            AssingmentsPerStudent.Pair(a8, s20);
            AssingmentsPerStudent.Pair(a9, s20);



            #endregion
        }
    }
}
