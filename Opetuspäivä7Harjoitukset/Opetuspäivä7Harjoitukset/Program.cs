using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä7Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {

            // 32B C# String: Luvut taulukkoon (Yhdessä päivä 7)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1164163
            #region

            int[] userValues = new int[3];

            // Silmukka, jossa pyydetään 3 arvoa. 1 per kierros.
            // Silmukan ehto on se, että päätetään suoritus silloin,
            // kun i-muuttujan arvo on taulukon indeksien ulkopuolelle.
            // Jos pituus on 3, indeksi ovat 0 1 2

            Console.WriteLine("Syötä 3 lukua: ");

            for (int i = 0; i < userValues.Length; i++)
            {
                userValues[i] = int.Parse(Console.ReadLine());
            }

            // Myöhemmin tarvitaan summa

            Console.WriteLine($"Lukujen summa on: {userValues.Sum()}");

            int sum = 0;

            // Silmukka, jossa summataan kaikkien indeksien arvot.
            // Voi olla myös foreach
            for (int i = 0; i < userValues.Length; i++)
            {
                sum = sum + userValues[i];
            }

            Console.WriteLine($"Lukujen summa on: {sum}");


            // Lista versio
            // Tässä versiossa käyttäjä voi tallentaa niin monta lukua kuin haluaa.

            Console.WriteLine("Syötä lukuja (e to exit): ");
            List<int> values = new List<int>();
            bool userIsDone = false;

            // Silmukka, jossa käyttäjä voi syöttää haluamansa verran lukuja.
            while (userIsDone == false) // tai do while
            {
                string userInput = Console.ReadLine();

                if (userInput == "e") // Tarkistetaan, jos käyttäjä lopettaa lukujen syötön
                {
                    userIsDone = true;
                }
                else // Muuten lisätään luku listaan.
                {
                    values.Add(int.Parse(userInput));
                }
            }

            // Tauko, jatketaan 18:00


            #endregion



            #region


            #endregion



            #region


            #endregion



            #region


            #endregion




            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
