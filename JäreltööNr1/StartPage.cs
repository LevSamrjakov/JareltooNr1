using System;
using System.Collections.Generic;
using System.Text;

namespace JäreltööNr1
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            bool Töötab = true;
            while (Töötab)
            {
                Console.WriteLine("Vali mida funktsioon sa tahad kasutada:");
                Console.WriteLine("1 - Kinopiletite kalkulaator");
                Console.WriteLine("2 - Kuupäeva eraldaja");
                Console.WriteLine("3 - Mündimäng");
                Console.WriteLine("4 - Ristküliku arvutused");
                Console.WriteLine("0 - Välju");
                string Valik = Console.ReadLine();
                switch (Valik)
                {
                    case "1":
                        Subfunctions.PiletiHindKalkulaator();
                        break;

                    case "2":
                        Subfunctions.HindaKuupäeva();
                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "0":
                        Töötab = false;
                        break;

                    default:
                        Console.WriteLine("Viga.");
                        break;
                }
            }
        }
    }
}



