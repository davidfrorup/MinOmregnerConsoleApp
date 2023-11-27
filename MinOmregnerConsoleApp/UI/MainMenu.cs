using MinOmregnerConsoleApp.UI.HastighedsUI;
using MinOmregnerConsoleApp.UI.OhmUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MinOmregnerConsoleApp.UI
{
    public class MainMenu
    {
        
        public static void menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Velkommen til omregneren!");
                Console.WriteLine("Hvad vil du omregne?\n");
                Console.WriteLine("1. Ohm omregner");
                Console.WriteLine("2. Knob / kmt omregner");
                Console.WriteLine("3. Afslut");
                

                char userInput = Console.ReadKey(true).KeyChar;

                try
                {
                    int choice = int.Parse(userInput.ToString());

                    switch (choice)
                    {
                        case 1:
                            OhmMenu.OhmValg();
                            break;

                        case 2:
                            HastighedsMenu.HastighedsValg();
                            break;

                        case 3:
                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Ugyldigt valg. Prøv igen.");
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
