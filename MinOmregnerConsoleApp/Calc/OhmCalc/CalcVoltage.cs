using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.Calc.Ohmcalc
{
    public class CalcVoltage
    {
        public double GetVoltageByCurrentAndResistance(double current, double resistance)
        {
            // Beregn effekten ved hjælp af Ohms lov: V = I * R
            return current * resistance;
        }

        public double GetVoltageByPowerAndCurrent(double power, double current)
        {
            // Beregn effekten ved hjælp af Ohms lov: V = P / I
            return power / current;
        }

        public double GetVoltageByPowerAndResistance(double power, double resistance)
        {
            // Beregn spændingen ved hjælp af Ohms lov: V = √(P * R)
            return Math.Sqrt(power * resistance);
        }
    }
}
