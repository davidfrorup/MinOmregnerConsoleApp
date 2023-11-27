using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinOmregnerConsoleApp;
using MinOmregnerConsoleApp;

namespace MinOmregnerConsoleApp.UI.HastighedsUI
{
    public class HastighedsMenu
    {

        public static void HastighedsValg()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hvad vil du beregne?\n");
                Console.WriteLine("1. km/t til knob");
                Console.WriteLine("2. knob til km/t");
                Console.WriteLine("3. Gå tilbage");

                try
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            KmtUI.KmtMenu();
                            break;

                        case ConsoleKey.D2:
                            KnobUI.KnobMenu();
                            break;

                        case ConsoleKey.D3:
                            UI.MainMenu.menu();
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
