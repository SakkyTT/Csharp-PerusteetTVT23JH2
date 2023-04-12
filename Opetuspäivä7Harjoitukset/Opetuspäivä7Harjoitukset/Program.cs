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

            //int[] userValues = new int[3];

            //// Silmukka, jossa pyydetään 3 arvoa. 1 per kierros.
            //// Silmukan ehto on se, että päätetään suoritus silloin,
            //// kun i-muuttujan arvo on taulukon indeksien ulkopuolelle.
            //// Jos pituus on 3, indeksi ovat 0 1 2

            //Console.WriteLine("Syötä 3 lukua: ");

            //for (int i = 0; i < userValues.Length; i++)
            //{
            //    userValues[i] = int.Parse(Console.ReadLine());
            //}

            //// Myöhemmin tarvitaan summa

            //Console.WriteLine($"Lukujen summa on: {userValues.Sum()}");

            //int sum = 0;

            //// Silmukka, jossa summataan kaikkien indeksien arvot.
            //// Voi olla myös foreach
            //for (int i = 0; i < userValues.Length; i++)
            //{
            //    sum = sum + userValues[i];
            //}

            //Console.WriteLine($"Lukujen summa on: {sum}");


            // Lista versio
            // Tässä versiossa käyttäjä voi tallentaa niin monta lukua kuin haluaa.

            //Console.WriteLine("Syötä lukuja (e to exit): ");
            //List<int> values = new List<int>();
            //bool userIsDone = false;

            //// Silmukka, jossa käyttäjä voi syöttää haluamansa verran lukuja.
            //while (userIsDone == false) // tai do while
            //{
            //    string userInput = Console.ReadLine();

            //    if (userInput == "e") // Tarkistetaan, jos käyttäjä lopettaa lukujen syötön
            //    {
            //        userIsDone = true;
            //    }
            //    else // Muuten lisätään luku listaan.
            //    {
            //        values.Add(int.Parse(userInput));
            //    }
            //}

            //// Listan summaus
            //Console.WriteLine($"Listan lukujen summa on: {values.Sum()}");

            //int sumList = 0;

            //foreach (int number in values)
            //{
            //    sumList += number;
            //}

            //Console.WriteLine($"Listan lukujen summa on: {sumList}");

            #endregion




            // 34D C# String: Etsi kirjaimia merkkijonosta (Yhdessä päivä 7)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159657
            #region

            Console.Write("Syötä sana 1: ");
            string word1 = Console.ReadLine(); // Esim: "kuppi"

            Console.Write("Syötä sana 2: ");
            string word2 = Console.ReadLine(); // Esim: "kauppa"

            // Taulukon käytön ongelmat:
            // 1. Ei voi tietää kuinka pitkä sana on
            // 2. Ei voi tietää montako merkkiä ovat samoja

            // Toistaiseksi luodaan taulukko, jonka pituus on sama kuin word1 pituus.
            // Se aiheuttaa sen, että taulukosta tulee liian pitkä
            // TODO: Luo taulukkon pituus tarkalleen oikein.

            // charsTested sisältää merkit, jotka ilmenevät molemmissa sanoissa ja montako kertaa ne ilmenee
            // Tässä datatyyppi on "Tuple" johon voi tallentaa kaksi eri datatyyppiä yhdessä
            (char charValue, int intValue)[] charsInCommon = new (char, int)[word1.Length];

            // Tähän otetaan talteen word1 muuttujassa tarkistetut merkit
            string charsTested = "";

            // Luodaan silmukka, joka käy läpi kaikki word1 merkit ja tarkistetaan ilmeneekö se word2-muuttujassa
            for (int i = 0; i < word1.Length; i++) // word1 indeksi == i
            {
                int numberOftimesFound = 0;

                for (int j = 0; j < word2.Length; j++) // word2 indeksi == j
                {
                    // Onko sanan 1 indeksissä i sama kirjain kuin sanan 2 indeksissä j
                    // Ja tarkistetaan, että ei ole vielä tallennettu kirjainta taulukkoon => estää saman kirjaimen tallennuksen uudestaan
                    if (word1[i] == word2[j] && charsTested.Contains(word1[i]) == false)
                    {
                        numberOftimesFound++;
                        charsInCommon[i] = (word1[i], numberOftimesFound);
                    }
                }

                // Lisätään tutkittu merkki, vasta sisemmän silmukan jälkeen.
                charsTested += word1[i];
            }

            // Silmukka, jossa käydään läpi taulukko löydetyistä kirjaimista
            foreach ((char, int) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.Item1} löytyi {pair.Item2} kerran/kertaa");
            }


            #endregion



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
