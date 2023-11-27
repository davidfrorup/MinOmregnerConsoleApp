using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinOmregnerConsoleApp.Calc.Ohmcalc;

namespace MinOmregnerConsoleApp.UI.OhmUI
{
    public class VoltageUI
    {

        private static CalcVoltage calculator = new CalcVoltage();

        public static void VoltageMenu()
        {

            Console.Clear();
            Console.WriteLine("Hvad vil du beregne?\n");
            Console.WriteLine("1. Spænding (V) ved hjælp af strøm og modstand (I og R) Formel: V = I * R");
            Console.WriteLine("2. Spænding (V) ved hjælp af effekt og strøm (P og I) Formel: V = P / I");
            Console.WriteLine("3. Spænding (V) ved hjælp af effekt og modstand (P og R) Formel: V = \u221A(P * R)");
            Console.WriteLine("4. Gå tilbage");

            double current, power, resistance, voltage;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Indtast strømmen (I) i ampere: ");
                    current = GetDoubleInput();
                    Console.Write("Indtast modstanden (R) i ohm: ");
                    resistance = GetDoubleInput();
                    voltage = calculator.GetVoltageByCurrentAndResistance(current, resistance);
                    Console.WriteLine($"Spændingen (V) er {voltage} volt.");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Indtast effekten (P) i watt: ");
                    power = GetDoubleInput();
                    Console.Write("Indtast strømmen (I) i ampere: ");
                    current = GetDoubleInput();
                    voltage = calculator.GetVoltageByPowerAndCurrent(power, current);
                    Console.WriteLine($"Spændingen (V) er {voltage} volt.");
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write("Indtast effekten (P) i watt: ");
                    power = GetDoubleInput();
                    Console.Write("Indtast modstanden (R) i ohm: ");
                    resistance = GetDoubleInput();
                    voltage = calculator.GetVoltageByPowerAndResistance(power, resistance);
                    Console.WriteLine($"Spændingen (V) er {voltage} volt.");
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
