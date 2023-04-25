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
                Console.Write("Syötä matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Syötä keskikulutus(l/100km): ");
                double averageConsumption = double.Parse(Console.ReadLine());

                Console.Write("Syötä polttoaineenhinta(€/l): ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new Trip(distance, averageConsumption, fuelPrice));
            }

            #endregion


        }
    }
}
