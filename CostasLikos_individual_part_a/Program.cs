using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostasLikos_individual_part_a.Application;
using CostasLikos_individual_part_a.DataBase;
using CostasLikos_individual_part_a.Views.HELPER;

namespace Costas_Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //App.Run();

            DateTime example = new DateTime(2021,12,25);

            CultureInfo enUS = new CultureInfo("en-US");
            example.ToString("d", enUS);

            if (example.ToString("ddd", enUS) == "Sat" || example.ToString("ddd", enUS) == "Sun")  Console.WriteLine("ΔΟΥΛΕΥΕΙ ΜΠΡΟ");

        }
    }  }
