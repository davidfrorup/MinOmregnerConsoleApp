using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinOmregnerConsoleApp;

namespace MinOmregnerConsoleApp.UI.OhmUI
{
    public class OhmMenu
    {

        public static void OhmValg()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hvad vil du omregne?\n");
                Console.WriteLine("1. Beregning af strøm (I)");
                Console.WriteLine("2. Beregning af spænding (V)");
                Console.WriteLine("3. Beregning af modstand (R)");
                Console.WriteLine("4. Beregning af effekt (P)");
                Console.WriteLine("5. Gå tilbage");

                try
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            CurrentUI.CurrentMenu();
                            break;
                        case ConsoleKey.D2:
                            VoltageUI.VoltageMenu();
                            break;
                        case ConsoleKey.D3:
                            ResistanceUI.ResistanceMenu();
                            break;
                        case ConsoleKey.D4:
                            PowerUI.PowerMenu();
                            break;
                        case ConsoleKey.D5:
                            MainMenu.menu();
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg. Prøv igen.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ugyldig indtastning. Indtast venligst et gyldigt tal.");
                    Console.ReadLine();
                }
            }

        }

    }
}


