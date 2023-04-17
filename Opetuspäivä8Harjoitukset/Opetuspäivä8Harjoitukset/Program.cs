using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä8Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34B C# Vokaalit taulukkoon
            // https://moodle.sakky.fi/mod/assign/view.php?id=1164552
            #region

            // 1.Lue käyttäjältä sana talteen

            Console.Write("Syötä sana: ");
            string userInput = Console.ReadLine();

            // 2.Luo taulukko sanan vokaaleille

            // Taulukon pituus täytyy määrittää, sitä luodessa
            // Luodaan taulukon pituudeksi sama, kuin sanan pituus, silloin ainakin riittää tila

            // datatyyppi [] taulukonNimi = new datatyyppi[taulukon pituus];
            char[] vocalsInWord = new char[userInput.Length]; // Taulukko

            // List<datatyyppi> nimi = new List<datatyyppi>();
            List<char> vocalsUsingList = new List<char>(); // Lista
                                                           // Lista on oletuksena tyhjä ja sen pituus/Count on 0
                                                           // vocalsUsingList[0] = 'n'; // Kaatuu, ArgumentOutOfRangeException, koska lista on tyhjä
                                                           // Sen elementtejä ei voida vielä käyttää



            // 3.Käy sanan merkit läpi silmukassa

            // foreach olisi toinen vaihtoehto, mutta siinä on hankala saada indeksi,
            // jota tarvitaan taulukossa

            // indeksi (int i = 0) alkaa arvosta 0, koska indeksit alkavat nollasta,
            //         indeksi muuttujaa käytetään taulukossa
            // Silmukan ehtona on taulukon pituus / indeksien lukumäärä. Kun iteroitava muuttuja i
            //          on taulukon indeksien ulkopuolella, silmukka päättyy.
            //          Esim: "test".Length == 4, jonka indeksit ovat 0, 1, 2, 3. Kun i saapuu arvoon 4,
            //          eli 4 < 4 ei ole enää totta, silmukka päättyy
            // Iterointi, i++

            for (int i = 0; i < userInput.Length; i++)
            {
                // Kirjoitetaan merkit yksi kerrallaan, merkkiä voi käyttää syntaksilla
                // muuttujanNimi[indeksi]
                // Console.WriteLine(userInput[i]);

                // 4.Tallenna merkki taulukkoon, jos se on vokaali.
                // Lisätään merkin tallennus ehdon sisälle, joka tarkistaa, että merkki on vokaali
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' ||
                     userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'y'
                     || userInput[i] == 'ä' || userInput[i] == 'ö')
                {
                    vocalsInWord[i] = userInput[i];
                    vocalsUsingList.Add(userInput[i]); // Listaan lisätään elementti .Add()-metodilla
                }
            }

            // 5.Luo silmukka, jossa tulostetaan vokaalit taulukosta käyttäjälle.

            // for olisi toinen vaihtoehto
            foreach (char symbol in vocalsInWord) // Taulukko
            {
                // Ei tulosteta tyhjiä elementtejä
                // char taulukon oletusarvo on 0, jos symbol on muutakuin 0 (symbol != 0)
                // tulostetaan merkki
                if (symbol != 0)
                {
                    Console.WriteLine(symbol);
                }
            }

            // Myös foreach toimisi
            for (int i = 0; i < vocalsUsingList.Count; i++) // Lista
            {
                Console.WriteLine("Lista: " + vocalsUsingList[i]);
            }
            #endregion


            // 37 C# String: Lämpötilan seuranta
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159662
            #region

            // 1.Luo taulukko ja lista arvoille.

            string[] measurementTimes = { "6:00", "12:00", "18:00", "24:00" };            

            double[] temperaturesArray = new double[measurementTimes.Length]; // Taulukko
            List<double> temperaturesList = new List<double>(); // Lista

            // 2.Lue silmukka, jossa käyttäjän arvot luetaan ja tallennetaan taulukkoon
            // ja listaan. (Arvo luetaan vain kerran per kierros ja se
            // tallennetaan sekä taulukkoon ja listaan)
            
            for (int i = 0; i < measurementTimes.Length; i++ )
            {
                Console.Write($"Syötä kello {measurementTimes[i]} lämpötila: ");
                double input = double.Parse(Console.ReadLine());
                temperaturesArray[i] = input; // Taulukko
                temperaturesList.Add(input); // Lista
            }

            // 3a.Ilmoita suurin, pienin ja keskilämpötila käyttämällä valmiita metodeja.
            // 4.Tulosta suurin, pienin ja keskilämpötila käyttäjälle.
            Console.WriteLine($"Taulukon suurin lämpötila on: {temperaturesArray.Max()}");
            Console.WriteLine($"Taulukon pienin lämpötila on: {temperaturesArray.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on: {temperaturesArray.Average()}");

            Console.WriteLine($"Listan suurin lämpötila on: {temperaturesList.Max()}");
            Console.WriteLine($"Listan pienin lämpötila on: {temperaturesList.Min()}");
            Console.WriteLine($"Listan keskilämpötila on: {temperaturesList.Average()}");

            // 3b.Suorita arvojen etsiminen omalla koodilla. (Kysy esim ChatGPT:
            // How to find the smallest value in an array using for loop)


            // Algoritmi, termi koodille, joka suorittaa jonkin asian
            // Tässä algoritmi, joka laskee keskiarvon.
            int count = 0;
            double sum = 0;

            foreach (double temp in temperaturesArray)
            {
                sum += temp;
                count++;
            }

            Console.WriteLine($"Taulukon keskiarvo on: {sum/count}");

            // Tässä algoritmi, joka hakee listasta suurimman arvon.

            double value = 0; // Tästä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo.

            for (int i = 0; i < temperaturesList.Count; i++)
            {
                // Korvataan oletusarvo 0, ensimmäisellä kierroksella
                if (i == 0)
                {
                    value = temperaturesList[i];
                }

                // Onko uusi arvo suurempi kuin vanha arvo
                if (temperaturesList[i] > value)
                {
                    value = temperaturesList[i]; // Otetaan talteen isompi arvo
                }
            }

            Console.WriteLine($"Listan Suurin arvo on: {value}");

            // Tee algoritmi, joka hakee taulukosta pienimmän arvon

            double valueMin = 0; // Tästä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo.

            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                // Korvataan oletusarvo 0, ensimmäisellä kierroksella
                if (i == 0)
                {
                    valueMin = temperaturesArray[i];
                }

                // Onko uusi arvo pienempi kuin vanha arvo
                if (temperaturesArray[i] < valueMin)
                {
                    valueMin = temperaturesArray[i]; // Otetaan talteen pienempi arvo
                }
            }

            Console.WriteLine($"Listan pienin arvo on: {valueMin}");

            #endregion


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
