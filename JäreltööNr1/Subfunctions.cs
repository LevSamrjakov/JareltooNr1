using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JäreltööNr1
{
    public class Subfunctions
    {
        public static void PiletiHindKalkulaator()
        {
            Console.WriteLine("Sisesta pileti täishind:");
            double Täishind = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisesta mitu täiskasvanuid on:");
            int Täiskasvanud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta mitu last on:");
            int Lapsed = Convert.ToInt32(Console.ReadLine());

            //Täishinnaga piletite kogusumma
            double TäishinnagaPiletit = Täishind * Täiskasvanud;

            //Soodushinnaga pilet kogusumma
            double SodushinnagaPiletit = Lapsed * (Täishind / 2);

            //Kõik piletit kogusumma
            double PiletiKogusumma = SodushinnagaPiletit + TäishinnagaPiletit;

            Console.WriteLine($"Kõigi täishinnaga piletite koguhind oli: {TäishinnagaPiletit}");
            Console.WriteLine($"Kõigi sodushinnaga piletite koguhind oli: {SodushinnagaPiletit}");
            Console.WriteLine($"Kõigi piletite koguhind oli: {PiletiKogusumma}");
        }

        public static void HindaKuupäeva()
        {
            string Sünniaasta = "";
            string Sünnikuu = "";
            string Sünnipäev = "";
            Console.WriteLine("Sisesta kuupäeva teksti kujul: \"YYYY-MM-DD\" (näiteks \"2005-12-24\").");
            string sünnipäev = Console.ReadLine();

            if (sünnipäev.Length == 10)
            {
                Sünniaasta = sünnipäev.Substring(0, 4);
                Sünnikuu = sünnipäev.Substring(startIndex: 5, length: 2);
                Sünnipäev = sünnipäev.Substring(startIndex: 8, length: 2);
            }
            else
            {
                Console.WriteLine("Sünnipäev ei saa olla rohkem või vähem kui 10");
            }

            Console.WriteLine($"Sündisid {Sünnipäev}. päeval, {Sünnikuu}. kuul aastal {Sünniaasta}.");
        }

        public static void MundiMang()
        {
            ArrayList Results = new ArrayList();
            Random Coin = new Random();
            int Loops = 10;
            int HeadsCount = 0;
            int TailsCount = 0;
            for (int I = 0; I < Loops; I++)
            {
                int Side = Coin.Next(0, 2);
                if (Side == 0)
                {
                    Results.Add("Heads");
                    HeadsCount++;
                }
                else
                {
                    Results.Add("Tails");
                    TailsCount++;
                }
            }
            foreach (string Result in Results)
            {
                Console.WriteLine(Result);
            }
            Console.WriteLine($"In total Heads came up {HeadsCount} times.");
            Console.WriteLine($"In total Tails came up {TailsCount} times.");
        }

        //public static Tuple<double, double> CalculateRectangle(double Length, double Width)
        //{
        //    double Area = Length * Width;
        //    double Perimeter = 2 * (Length + Width);

        //    return
        //}
    }
}
