using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinOmregnerConsoleApp.Calc.Ohmcalc;

namespace MinOmregnerConsoleApp.UI.OhmUI
{
    public class ResistanceUI
    {

        private static CalcResistance calculator = new CalcResistance();

        public static void ResistanceMenu()
        {
            Console.Clear();
            Console.WriteLine("Hvad vil du beregne?\n");
            Console.WriteLine("1. Modstand (R) ved hjælp af spænding og strøm (V og I) Formel: R = V / I");
            Console.WriteLine("2. Modstand (R) ved hjælp af effekt og strøm (P og I) Formel: R = P / (I^2)");
            Console.WriteLine("3. Modstand (R) ved hjælp af spænding og effekt (V og P) Formel: R = (V^2) / P");
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
                    resistance = calculator.GetResistanceByVoltageAndCurrent(voltage, current);
                    Console.WriteLine($"Modstanden (R) er {resistance} ohm.");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Indtast effekten (P) i watt: ");
                    power = GetDoubleInput();
                    Console.Write("Indtast strømmen (I) i ampere: ");
                    current = GetDoubleInput();
                    resistance = calculator.GetResistanceByPowerAndCurrent(power, current);
                    Console.WriteLine($"Modstanden (R) er {resistance} ohm.");
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write("Indtast spændingen (V) i volt: ");
                    voltage = GetDoubleInput();
                    Console.Write("Indtast effekten (P) i watt: ");
                    power = GetDoubleInput();
                    resistance = calculator.GetResistanceByVoltageAndPower(voltage, power);
                    Console.WriteLine($"Modstanden (R) er {resistance} ohm.");
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