using System;
using MinOmregnerConsoleApp.Calc.Ohmcalc;

namespace MinOmregnerConsoleApp.UI.OhmUI
{
    public class CurrentUI
    {
        private static CalcCurrent calculator = new CalcCurrent();

        public static void CurrentMenu()
        {
            Console.Clear();
            Console.WriteLine("Hvad vil du beregne?\n");
            Console.WriteLine("1. Strøm (I) ved hjælp af effekt og modstand (P og R) Formel: I = \u221A(P / R)");
            Console.WriteLine("2. Strøm (I) ved hjælp af effekt og spænding (P og V) Formel: I = P / V");
            Console.WriteLine("3. Strøm (I) ved hjælp af spænding og modstand (V og R) Formel: I = V / R");
            Console.WriteLine("4. Gå tilbage");

            double power, resistance, voltage, current;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Indtast effekten (P) i watt: ");
                    power = GetDoubleInput();
                    Console.Write("Indtast modstanden (R) i ohm: ");
                    resistance = GetDoubleInput();
                    current = calculator.GetCurrentByPowerAndResistance(power, resistance);
                    Console.WriteLine($"Strømmen (I) er {current} ampere.");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Indtast effekten (P) i watt: ");
                    power = GetDoubleInput();
                    Console.Write("Indtast spændingen (V) i volt: ");
                    voltage = GetDoubleInput();
                    current = calculator.GetCurrentByPowerAndVoltage(power, voltage);
                    Console.WriteLine($"Strømmen (I) er {current} ampere.");
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write("Indtast spændingen (V) i volt: ");
                    voltage = GetDoubleInput();
                    Console.Write("Indtast modstanden (R) i ohm: ");
                    resistance = GetDoubleInput();
                    current = calculator.GetCurrentByVoltageAndResistance(voltage, resistance);
                    Console.WriteLine($"Strømmen (I) er {current} ampere.");
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
