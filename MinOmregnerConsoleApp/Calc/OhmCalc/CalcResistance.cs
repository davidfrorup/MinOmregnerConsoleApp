using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.Calc.Ohmcalc
{
    public class CalcResistance
    {

        public double GetResistanceByPowerAndCurrent(double power, double current)
        {
            // Beregn modstanden ved hjælp af Ohms lov: R = P / I^2
            return power / Math.Pow(current, 2);
        }

        public double GetResistanceByVoltageAndPower(double voltage, double power)
        {
            // Beregn modstanden ved hjælp af Ohms lov: R = V^2 / P
            return Math.Pow(voltage, 2) / power;
        }

        public double GetResistanceByVoltageAndCurrent(double voltage, double current)
        {
            // Beregn modstanden ved hjælp af Ohms lov: R = E / I
            return voltage / current;
        }


    }
}
