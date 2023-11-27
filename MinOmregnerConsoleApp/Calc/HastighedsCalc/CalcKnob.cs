using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.Calc.HastighedsCalc
{
    public class CalcKnob
    {

        public static double KmtToKnob(double kmt)
        {
            // Konverter km/t til kn (1 km/t = 0.539956 kn)
            return kmt * 0.539956;
        }


    }
}
