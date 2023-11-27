using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinOmregnerConsoleApp.Calc.Ohmcalc;

namespace MinOmregnerConsoleApp.UI.OhmUI
{
    public class PowerUI
    {

        private static CalcPower calculator = new CalcPower();

        public static void PowerMenu()
        {

            Console.Clear();
            Console.WriteLine("Hvad vil du beregne?\n");
            Console.WriteLine("1. Effekt (P) ved hjælp af spænding og strøm (V og I) Formel: P = V * I");
            Console.WriteLine("2. Effekt (P) ved hjælp af spænding og modstand (V og R) Formel: P = (V^2) / R");
            Console.WriteLine("3. Effekt (P) ved hjælp af strøm og modstand (I og R) Formel: P = I^2 * R");
            Console.WriteLine("4. Gå tilbage");

            double current, power, resistance, voltage;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Indtast spændingen (V) i volt: ");
                    voltage = GetDoubleInput();
                    Console.Write("Indtast strømmen (I) i ampere: ");
                    current = GetDoubleInput();
                    power = calculator.GetPowerByVoltageAndCurrent(voltage, current);
                    Console.WriteLine($"Effekten (P) er {power} watt.");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Indtast spændingen (V) i volt: ");
                    voltage = GetDoubleInput();
                    Console.Write("Indtast modstanden (R) i ohm: ");
                    resistance = GetDoubleInput();
                    power = calculator.GetPowerByVoltageAndResistance(voltage, resistance);
                    Console.WriteLine($"Effekten (P) er {power} watt.");
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write("Indtast strømmen (I) i ampere: ");
                    current = GetDoubleInput();
                    Console.Write("Indtast modstanden (R) i ohm: ");
                    resistance = GetDoubleInput();
                    power = calculator.GetPowerByCurrentAndResistance(current, resistance);
                    Console.WriteLine($"Effekten (P) er {power} watt.");
                    break;
                case ConsoleKey.D4:
                    OhmMenu.OhmValg();
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    return;
            }

            Console.WriteLine("\nTryk Vilkårlig tast for at vende tilbage til start menuen");
            Console.ReadLine();
        }

        private static double GetDoubleInput()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ugyldig indtastning. Prøv igen.");
            }
            return input;
        }
    }
}