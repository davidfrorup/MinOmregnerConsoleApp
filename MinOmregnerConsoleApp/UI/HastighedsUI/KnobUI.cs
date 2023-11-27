using MinOmregnerConsoleApp.Calc.HastighedsCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.UI.HastighedsUI
{
    public class KnobUI
    {

            public static void KnobMenu()
            {
                Console.Clear();
                Console.WriteLine("Her beregnes km/t til knob");
                Console.WriteLine("Indtast km/t:");

                double kmt = Convert.ToDouble(Console.ReadLine());

                CalcKnob calcKnob = new CalcKnob();

                double knob = CalcKnob.KmtToKnob(kmt);

                Console.WriteLine($"{kmt} km/t svarer til {knob} knob");

                Console.WriteLine("\nTryk vilkårlig tast for at vende tilbage til start");
                Console.ReadKey();
                MainMenu.menu();

            }



        


    }
}
