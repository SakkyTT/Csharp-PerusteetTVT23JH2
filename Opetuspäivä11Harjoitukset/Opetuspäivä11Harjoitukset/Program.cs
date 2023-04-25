using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EriNimi;

namespace Opetuspäivä11Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //

            #region

            // Pyydetään arvot käyttäjältä

            List<Trip> trips = new List<Trip>();

            bool userEndsLoop = false;

            while (userEndsLoop == false)
            {
                Console.Write("Syötä matkan nimi: ");
                string name = Console.ReadLine();

                Console.Write("Syötä matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Syötä keskikulutus(l/100km): ");
                double averageConsumption = double.Parse(Console.ReadLine());

                Console.Write("Syötä polttoaineenhinta(€/l): ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new Trip(name, distance, averageConsumption, fuelPrice));

                Console.Write("Syötetään uusi matka(y): ");
                string input = Console.ReadLine();

                if (input != "y")
                {
                    userEndsLoop = true;
                }
            }

            foreach (Trip t in trips)
            {
                // Lasku toimituksen voisi toteuttaa täällä käyttämällä objektien arvoja,
                // mutta yleensä luokan dataan liittyvät toiminnallisuudet
                // ovat osana itse luokkaa.
                // double test = t.AverageConsumption * t.FuelPrice * t.FuelPrice;
                Console.WriteLine($"Matkan {t.Name} hinta on:{t.CalculateCost()}");
            }



            #endregion

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
