using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOmregnerConsoleApp.Calc.Ohmcalc;

public class CalcPower
{
    public double GetPowerByVoltageAndResistance(double voltage, double resistance)
    {
        // Beregn effekten ved hjælp af Ohms lov: P = V^2 / R
        return Math.Pow(voltage, 2) / resistance;
    }

    public double GetPowerByVoltageAndCurrent(double voltage, double current)
    {
        // Beregn effekten ved hjælp af Ohms lov: P = V * I
        return voltage * current;
    }

    public double GetPowerByCurrentAndResistance(double current, double resistance)
    {
        // Beregn effekten ved hjælp af Ohms lov: P = I^2 * R
        return Math.Pow(current, 2) * resistance;
    }

}
