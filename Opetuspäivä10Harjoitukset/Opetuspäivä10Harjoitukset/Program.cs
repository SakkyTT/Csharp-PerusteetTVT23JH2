using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä10Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Bensankulutus
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159675

            #region

            Console.Write("Syötä ajettu matka(km): ");
            decimal distance = decimal.Parse(Console.ReadLine());

            Console.Write("Syötä ajeneuvon keskikulutus(l/100km): ");
            decimal averageConsumption = decimal.Parse(Console.ReadLine());

            Console.Write("Syötä polttoaineen hinta(€/l): ");
            decimal fuelPrice = decimal.Parse(Console.ReadLine());

            decimal tripCost = carTripCostCalculator(distance, averageConsumption, fuelPrice);

            Console.WriteLine(); // Tyhjä rivi
            Console.WriteLine($"Ajetun matkan hinta on: {tripCost} euroa.");

            #endregion


            Console.ReadKey();
        }

        // C# Funktiot: Bensankulutus
        // https://moodle.sakky.fi/mod/assign/view.php?id=1159675

        #region

        // Parametrien yksiköt joko kommentoidaan tai lisätään parametrien nimiin.
        private static decimal carTripCostCalculator(decimal distanceInKilometers, decimal averageConsumption, decimal fuelCost)
        {
            decimal result = 0;

            result = distanceInKilometers * averageConsumption * fuelCost / 100;

            return result;
        }

        #endregion
    }
}
