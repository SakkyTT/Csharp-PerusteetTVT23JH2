using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä4Teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ehtolauseet
            // 2. Silmukat
            // 3. Vertailu operaattorit
            // 4. Loogiset operaattorit
            // 5. Lisäys / Vähennys operaattorit


            // 1.
            // Conditional statements
            // Ehtolauseet

            // Ehtolauseita käytetään, kun on tarve suorittaa eri koodi erilaisissa tilanteissa.
            // Esim: Tulostetaan kaupan aukiolo aika kyseisenä päivänä.
            //      1. Tarkistetaan mikä viikonpäivä on ja tallennetaan se muuttujaan.
            //      2. Käydään läpi ehtorakenne, joka vertailee muuttujassa olevaa tämän hetken viikonpäivää kaikkin eri vaihtoehtoihin "maanantain - sunnuntai".
            //      3a. Kun löytyy oikea vaihtoehto, suoritetaan koodi vain sen vaihtoehdon koodi osiossa.
            //      3b. Jos jostakin syystä ei löydy ehtoa, jonka arvoksi tulee "true", voidaan suorittaa oletus koodi osio.
            #region
            // 1. if - else if - else operator

            // Haetaan tämän hetken viikonpäivä
            DayOfWeek currentDayOfWeekIF = DateTime.Now.DayOfWeek;


            if (currentDayOfWeekIF == DayOfWeek.Saturday) // Verrataan onko nyt lauantai
            {
                Console.WriteLine("Aukioloaika: 10:00 - 21:00");
            }
            else if (currentDayOfWeekIF == DayOfWeek.Sunday) // Verrataan onko nyt sunnuntai
            {
                Console.WriteLine("Aukioloaika: 10:00 - 20:00");
            }
            else
            { // Oletuksena on lopuksi arkipäivä ja normaali aukioloaika
                Console.WriteLine("Aukioloaika: 7:00 - 21:00");
            }

            // 2. switch operator

            // Haetaan tämän hetken viikonpäivä
            DayOfWeek currentDayOfWeekSWITCH = DateTime.Now.DayOfWeek;

            switch (currentDayOfWeekSWITCH) // Muuttuja, jota verrataan
            {
                case DayOfWeek.Saturday: // Arvo, johon muuttujaa verrataan. Onko nyt lauantai.
                    Console.WriteLine("Aukioloaika: 10:00 - 21:00");
                    break;
                case DayOfWeek.Sunday: // Verrataan onko nyt sunnuntai
                    Console.WriteLine("Aukioloaika: 10:00 - 20:00");
                    break;
                default: // Oletuksena on lopuksi arkipäivä ja normaali aukioloaika
                    Console.WriteLine("Aukioloaika: 7:00 - 21:00");
                    break;
            }

            // 3. ternary operator

            // Ternary operaatio on hieman erikoistapaus. Sitä käytetään määrittämään muuttujalle tietty arvo, jonkin ehdon perusteella.
            // Tämä rakenne ei pysty suorittamaan useaa riviä koodia.
            // Ternary pystyy suorittamaan funktioita, mutta niitä ei tarvitse vielä käyttää.

            // Syntaksi: (condition) ? (value if true) : (value if false)

            // Haetaan tämän hetken viikonpäivä
            DayOfWeek currentDayOfWeekTERNARY = DateTime.Now.DayOfWeek;

            string message = currentDayOfWeekTERNARY == DayOfWeek.Saturday ? "Aukioloaika: 10:00 - 21:00" : // Arvo, jos launtai
                             currentDayOfWeekTERNARY == DayOfWeek.Sunday ? "Aukioloaika: 10:00 - 20:00" : // Arvo, jos sunnuntai
                             "Aukioloaika: 7:00 - 21:00"; // Oletusarvo

            Console.WriteLine(message); // Koska ternary operaatio ainoastaan määrittää arvon muuttujalle. WriteLine suoritetaan erikseen.

            #endregion


            // 2.
            // Loops
            // Silmukat

            // Silmukoita käytetään, kun jokin osa koodia halutaan suorittaa useaan kertaan.
            // Eri silmukoilla on hieman eri käyttötarkoitukset.
            #region


            // 1. while / do-while
            // Tätä silmukkaa käytetään, kun ei ole ennalta määritelty montako kertaa koodi suoritetaan.

            // Esim: Käyttäjä pystyy syöttämään lukuja, jotka summataan yhteen. Kun käyttäjä on valmis, hän syöttää merkin 'e'.

            // -- Esimerkin koodi ilman silmukkaa --
            int sumNoLoop = 0;

            Console.WriteLine("Anna summattavia lukuja: ");
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());
            sumNoLoop += int.Parse(Console.ReadLine());

            Console.WriteLine($"Summa: {sumNoLoop}");
            // Ilman silmukkaa, pyydettävien numeroiden määrä täytyy olla ennalta määritelty koodissa
            // Lisäksi käyttäjä ei pysty lopettamaan lukujen syöttämistä antamalla merkkiä 'e'.


            // -- Esimerkki while silmukalla --
            int sumWhileLoop = 0;
            bool continueLoop = true; // Muuttuja, jota käytetään while silmukan ehtona. Kun käyttäjä syöttää merkin 'e', annetaan muuttujan arvoksi false ja silmukka päättyy.
            string input = "";
            Console.WriteLine("Anna summattavia lukuja: ");
            while (continueLoop)
            {
                input = Console.ReadLine();
                if (input == "e")
                {

                }
                else
                {
                    sumWhileLoop += int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Summa: {sumWhileLoop}");

            // do-while on muuten sama kuin while, mutta koodi aina suoritetaan yhden kerran. Ehto tarkistetaan vasta lopussa.
            // -- Esimerkki do-while silmukalla --

            continueLoop = true;

            do // Koodi suoritetaan kerran, ilman ehdon tarkistusta.
            {
                input = Console.ReadLine();
                if (input == "e")
                {

                }
                else
                {
                    sumWhileLoop += int.Parse(Console.ReadLine());
                }
            } while (continueLoop); // Ehto tarkistetaan lopuksi.
            Console.WriteLine($"Summa: {sumWhileLoop}");

            //

            // 2. for
            // Käytetään tilanteissa, kun toistojen määrä on ennalta määritelty.
            // Syntaksi:

            // initialization == luodaan muuttuja, jota iteroidaan silmukassa
            // condition == silmukan ehto
            // iteration == kuinka muuttujaa iteroidaan
            // for (initialization; condition; iteration)
            // {
                    // code block to be executed
            // }

            // Esim: Pyydetään käyttäjältä 3 lukua ja lasketaan niiden keskiarvo.

            const int numberOfValues = 3; // Number of values asked from user.
            double sum = 0;

            for (int i = 1; i <= numberOfValues; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Keskiarvo on: {sum/ numberOfValues}");


            // 3. foreach
            // Käytetään tilanteissa, kun käydään läpi kaikki kohteet jossakin kokoelmassa.
            // Usein kokoelmat ovat taulukko (array) tai lista (list)

            // Syntaksi:
            // foreach (type variable in collection)
            // {
            //     // code block to be executed
            // }

            // Esim: Käydään läpi kaikki merkit (char) string muuttujassa.

            string word = "Bird";

            foreach (char c in word)
            {
                Console.WriteLine(c);
            }

            #endregion


            // 3. 
            // Vertailu operaattorit
            #region
            // 1. while / do-while
            // 2. for
            // 3. foreach
            #endregion


            // 4. 
            // Loogiset operaattorit
            #region
            // 1. while / do-while
            // 2. for
            // 3. foreach
            #endregion


            // 5. 
            // Lisäys / Vähennys operaattorit
            #region
            // 1. while / do-while
            // 2. for
            // 3. foreach
            #endregion




            // EXTRA: switch with ranges

            //int i = 73;

            //switch (i)
            //{
            //    case int n when (n >= 100):
            //        Console.WriteLine($"I am 100 or above: {n}");
            //        break;

            //    case int n when (n < 100 && n >= 50):
            //        Console.WriteLine($"I am between 99 and 50: {n}");
            //        break;

            //    case int n when (n < 50):
            //        Console.WriteLine($"I am less than 50: {n}");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
