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

        public static TypeEnum EnumOption(string placeholder)
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




    }
}
