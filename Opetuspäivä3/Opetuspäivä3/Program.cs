using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 C# Perus: Kolmion pinta-ala(yhdessä 27.3.)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159590

            //// Ilmoitetaan käyttäjälle, mitä tietoa pyydetään
            //Console.Write("Anna kolmion kanta: ");
            //// Luetaan käyttäjältä arvo string muodossa
            //// Ja muokataan string -> double muotoon
            //double triangleBase = double.Parse(Console.ReadLine());

            //Console.Write("Anna kolmion korkeus: ");
            //double triangleHeigth = double.Parse(Console.ReadLine());

            //// Voidaan näyttää laskutoimituksen lopputulos suoraan osana tekstiä. Huomioi "Magic Number" -2-
            //Console.WriteLine($"Kolmion pinta-ala on: {triangleBase* triangleHeigth / 2}");

            //// Pysäytetään sovellus
            //Console.WriteLine();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            // Uusi aihe: Ohjausrakenne - Control structure
            // 1. if - rakenne

            // if (ehto - condition) // lopputulos true / false
            // { <- start of if code block
            // if condition == true
            // Suoritetaan if blokin koodi
            // } <- end of if code block
            // jos condition == false
            // hypätään koodi blokin yli

            Console.WriteLine("Ennen if");
            if (50 > 10) // true
            {
                Console.WriteLine("sisällä if");
            }
            Console.WriteLine("Jälkeen if");
            Console.WriteLine();
            // 2. if - else
            // Joko suoritetaan if code block
            // Tai suoritetaan else code block

            Console.WriteLine("before if-else");
            if ("moi" != "terve")
            {
                Console.WriteLine("inside if");
            }
            else
            {
                Console.WriteLine("inside else");
            }
            Console.WriteLine("after if-else");

            Console.WriteLine();

            // 3. if - else if - else
            // Rakenteessa voi olla myös muita vertailuja
            // ainoastaan yksi code block suoritetaan
            // Vaikka useampi kohta olisi oikein

            if (6.5 >= 5.5)
            {
                Console.WriteLine("inside if");
            }
            else if (10 <= 10)
            {
                Console.WriteLine("inside else-if");
            }
            else
            {
                Console.WriteLine("inside else");
            }

            // Vertailuoperaattorit - Comparison operators
            // Vertailujen lopputulos on totuusarvo - boolean
            // true / false

            // ==  samat arvot
            // !=  eri arvot
            // <   vasen pienempi kuin oikea
            // >   vasen isompi kuin oikea
            // <=  vasen pienempi tai yhtä suuri kuin oikea
            // >=  vasen isompi tai yhtä suuri kuin oikea

            // Loogiset operaattorit - Logical operators
            // Voidaan yhdistää useampi vertailuoperaatio

            // && molemmat totta -and-
            // age >= ageLimit && length == targetHeigth

            // || toinen totta -or- ctrl+alt+<
            // age >= ageLimit || length == targetHeigth

            // !  kääntää totuusarvon
            // bool accountDeleted = true;
            // if(!accountDeleted)
            //{
            // Jos EI ole poistettu, voidaan käyttää
            //}

            // if sulkujen sisällä pitää olla true
            // jos vertaillaan arvoa, jonka halutaan olla false
            // ! ennen muuttujaa

            // 4. Silmukat - Loops

            // while(condition)
            // {
            //     Execute done
            //     As long as condition == true
            // }

            // ensin maalataan koodia
            // kommentointi ctrl + k sitten ctrl + c
            // poisto ctrl + k sitten ctrl + u
            while (true)
            {
                Console.Write("moi");
            }

            string input = "";
            while (input != "exit")
            {
                Console.Write("Choose action: ");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");
            }

            // 11 C# Valinta: Luvun vertailuTehtävä 
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159609
            Console.WriteLine(); // tyhjä rivi

            // pyydetään käyttäjältä luku
            Console.Write("Anna luku: ");
            int value = int.Parse(Console.ReadLine());

            if (value == 0)
            {
                Console.WriteLine("Arvo on 0");
            }
            else if (value > 0)
            {
                Console.WriteLine("Arvo on suurempi kuin 0");
            }
            else
            {
                Console.WriteLine("Arvo on pienempi kuin 0");
            }

            // 12 C# Valinta: Iän tarkistus
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159610
            Console.WriteLine(); // tyhjä rivi

            bool ageCorrect = false;

            //while (!ageCorrect)
            while (ageCorrect == false)
            {
                Console.Write("Syötä ikä: ");
                int age = int.Parse(Console.ReadLine());
                int minAge = 0; // 2
                int maxAge = 120;

                // Tarkistetaan, että ikä on sopiva
                if (age >= minAge && age <= maxAge)
                {
                    ageCorrect = true;
                    Console.WriteLine("Tallennus onnistui");
                }
                else
                {
                    Console.WriteLine("Arvo ei ole " +
                        "hyväksyttävällä välillä" +
                        $" ({minAge}-{maxAge})");
                }
            } // ctrl + a , ctrl + k , ctrl + d

            // 13 C# Valinta: Myyntihinnan laskeminen
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159611

            Console.Write("Syötä hinta: ");
            double price = double.Parse(Console.ReadLine());
            double discountedPrice;

            if (price > 100)
            {
                discountedPrice = price * 0.75;
            }
            else
            {
                discountedPrice = price * 0.90;
            }

            Console.WriteLine($"Alennettu hinta on {discountedPrice} euroa");

            // 15 C# Valinta: Luvun arvaus
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159613

            int target = 11;
            bool correctGuess = false;

            while (correctGuess == false)
            {
                Console.Write("Arvaa luku(0-20): ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == target) // oikea arvaus
                {
                    correctGuess = true;
                    Console.WriteLine("Oikea arvaus");
                }
                else if (guess < target) // liian pieni
                {
                    Console.WriteLine("Liian pieni");
                }
                else // liian suuri
                {
                    Console.WriteLine("Liian suuri");
                }
            }


            // Pysäytetään sovellus
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
