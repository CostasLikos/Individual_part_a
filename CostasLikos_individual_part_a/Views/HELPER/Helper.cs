using Costas_Part_A;
using CostasLikos_individual_part_a.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostasLikos_individual_part_a.Views.HELPER
{
    class Helper
    {

        public static string InputText(string placeholder)
        {
            //try catch  & do while
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            return result;
        }

        public static int InputNumber(string placeholder)
        {
            //try catch  & do while
            Console.WriteLine(placeholder);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        public static int Counterplus1(List<Course> courses) => courses.Count() + 1; //??

        public static TypeEnum InputEnumOption(string placeholder)
        {
            int result;
            Console.WriteLine(placeholder);

            do
            {
                result = Convert.ToInt32(Console.ReadLine());



            } while (result != 1 && result != 2);

            if (result == 1)
            {
                return TypeEnum.FullTime;
            }
            else 
            {
                return TypeEnum.PartTime;
            }
        }

        public static bool IsProperDate(string date)
        {
            DateTime result;
            DateTime.TryParse(date, out result);
            return result == default(DateTime) ? false : true;
        }

       

        public static DateTime InputStartDate(string placeholder)
        {
            Console.WriteLine(placeholder);
            string result = Console.ReadLine();
            bool x;
            do
            {
                x = IsProperDate(result);
                if (!x)
                {
                    Console.WriteLine("Wrong Input, Try again with DateTime Formating ex. YYYY-MM-DD");
                    Console.ReadLine();
                }
            } while (!x);

            DateTime date = Convert.ToDateTime(result);

            return date;
            //DEN BAZW VALIDATION GIA TO PARELTHON GT MPOREI NA THELW NA KANW ADD KATI POU EXEI PERASEI O KAIROS TOU

        }

        public static DateTime InputEndDate(DateTime start, TypeEnum choice)
        {
            DateTime result;

            if (choice == TypeEnum.FullTime)
            {
                result  = start.AddMonths(3); 
            }
            else
            {
                result = start.AddMonths(6);
            }
            
            return result;

        }




    }
}
