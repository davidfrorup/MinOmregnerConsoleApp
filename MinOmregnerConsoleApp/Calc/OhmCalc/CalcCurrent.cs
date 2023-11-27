using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.Calc.Ohmcalc
{
    public class CalcCurrent
    {

        public double GetCurrentByPowerAndResistance(double power, double resistance)
        {
            // Beregn spændingen ved hjælp af Ohms lov: I = √(P / R)
            return Math.Sqrt(power / resistance);
        }
        public double GetCurrentByPowerAndVoltage(double power, double voltage)
        {
            // Beregn spændingen ved hjælp af Ohms lov: I = P / V
            return power / voltage;
        }
        public double GetCurrentByVoltageAndResistance(double voltage, double resistance)
        {
            // Beregn spændingen ved hjælp af Ohms lov: I = V / R
            return voltage / resistance;
        }

    }
}
