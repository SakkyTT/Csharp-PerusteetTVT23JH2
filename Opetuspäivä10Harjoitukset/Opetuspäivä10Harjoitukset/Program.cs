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

            bool userEndsLoop = false;

            // List<(decimal, decimal, decimal)> test = new List<(decimal, decimal, decimal)>(); // Tuple
            List<decimal> userDistances = new List<decimal>();
            List<decimal> userAverageConsumption = new List<decimal>();
            List<decimal> userFuelPrice = new List<decimal>();
            // Kun käytetään useaa eri listaa tai taulua, täytyy hallita indeksien käyttö oikein eri listojen välillä.

            decimal[] test = new decimal[1];
            (decimal, decimal, decimal)[] trips = new(decimal, decimal, decimal)[1];

            // Kohta 5, lisätään koko koodi silmukkaan
            while (userEndsLoop == false)
            {
                Console.Write("Syötä ajettu matka(km): ");
                decimal distance = decimal.Parse(Console.ReadLine());
                userDistances.Add(distance);

                Console.Write("Syötä ajeneuvon keskikulutus(l/100km): ");
                decimal averageConsumption = decimal.Parse(Console.ReadLine());
                userAverageConsumption.Add(averageConsumption);

                Console.Write("Syötä polttoaineen hinta(€/l): ");
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                userFuelPrice.Add(fuelPrice);

                trips[trips.Length - 1] = (distance, averageConsumption, fuelPrice);

                //decimal tripCost = carTripCostCalculator(distance, averageConsumption, fuelPrice);

                // Console.WriteLine(); // Tyhjä rivi
                // Console.WriteLine($"Ajetun matkan hinta on: {tripCost} euroa.");
                // Console.WriteLine(); // Tyhjä rivi

                Console.Write("Calculate another trip? (y/n): ");
                string input = Console.ReadLine();

                if (input == "n") // Käyttäjä lopettaa sovelluksen
                {
                    userEndsLoop = true; // Kun tämä muuttuja on true, silmukka päättyy
                }
                else // Laajennetaan taulukko
                {
                    //test = expandArray(test);
                    //test = expandArray(test);
                    trips = expandArray(trips); // expandArray palauttaa uuden taulukon, joka on yhtä suurempi kuin
                                                // Alkuperäinen taulukko, joka annetaan parametrinä                                 
                }
            }

            // Käydään listat läpi ja tulostetaan matkojen hinnat.
            for (int i = 0; i < userDistances.Count; i++)
            {
                Console.WriteLine($"Matkan {i+1} hinta on:" +
                    $" {carTripCostCalculator(userDistances[i], userAverageConsumption[i], userFuelPrice[i])}");
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("Press any key to exit..");
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

        private static (decimal, decimal, decimal)[] expandArray((decimal, decimal, decimal)[] originalArray)
        {
            // Luodaan uusi taulukko, joka on yhtä suurempi kuin alkuperäinen taulukko
            (decimal, decimal, decimal)[] newArray = new (decimal, decimal, decimal)[originalArray.Length + 1];

            // Kopioidaan arvot vanhasta taulukosta uuteen taulukkoon
            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }

            return newArray;
        }

        #endregion
    }
}
