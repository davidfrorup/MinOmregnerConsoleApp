using MinOmregnerConsoleApp.Calc.HastighedsCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.UI.HastighedsUI
{
    public class KmtUI
    {

        public static void KmtMenu()
        {
            Console.Clear();
            Console.WriteLine("Her beregnes knob til km/t");
            Console.WriteLine("Indtast knob:");

            double knob = Convert.ToDouble(Console.ReadLine());

            CalcKmt calcKmt = new CalcKmt();

            double kmt = calcKmt.KnobToKmt(knob);

            Console.WriteLine($"{knob} knob svarer til {kmt} km/t");

            Console.WriteLine("\nTryk vilkårlig tast for at vende tilbage til start");
            Console.ReadKey();
            MainMenu.menu();

        }



    }
}
