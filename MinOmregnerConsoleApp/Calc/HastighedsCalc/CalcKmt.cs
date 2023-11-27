using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.Calc.HastighedsCalc
{
    public class CalcKmt
    {

        public double KnobToKmt(double knob)
        {
            // Konverter knob til km/t (1 kn = 1.852 km/t)
            return knob * 1.852;
        }





    }
}
