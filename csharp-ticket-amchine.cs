using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrkartenautomat
{
    class Fahrkartenautomat
    {
        static void Main(string[] args)
        {
            int km;
            int wahl;
            double preis;
            int[] wechselgeld = new int[4] { 5, 10, 15, 20 };


            do
            {
                Console.WriteLine("Bitte geben Sie die Kilometer ein:");
                km = Convert.ToInt32(Console.ReadLine());
                if (km < 50) {
                    Console.WriteLine("Bitte zahlen Sie 15 Euro");
                }
                else if (km > 50 && km <= 100) {
                    preis = 15 + (km - 50)*0.5;
                    Console.WriteLine("Bitte zahlen Sie {0} Euro", preis);
                }
                else if (km > 100 && km < 200) {
                    Console.WriteLine("Bitte zahlen Sie 30 Euro");
                }
                else if (km >= 200 && km <= 329)
                {
                    Console.WriteLine("Bitte zahlen Sie 40 Euro");
                }
                else if (km > 329)
                {
                    Console.WriteLine("Diese Strecke steht leider nicht zur Verfügung");
                }
                Console.WriteLine("Wählen Sie 1 für eine neue Karte oder 0 zum Beenden");
                wahl= Convert.ToInt32(Console.ReadLine());
            } while (wahl != 0);

            Console.WriteLine("Drücken Sie eine beliebige Taste");
            Console.ReadKey();

        }
    }
}
