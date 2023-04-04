using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä5Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // 28 C# Toisto: Parillinen Pariton
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159636
            // Tee ohjelma joka kysyy mihin lukuun saakka tulostetaan lukuja.
            // 20 => 1, 2, 3, 4, 5, 6, .... 20
            // Käyttäjältä myös kysytään, tulostetaanko parilliset vai parittomat.
            // "pariton"    "parillinen"
            // Sovellus lopuksi tulostaa joko parittomat tai parilliset luvut, nollasta alkaen.

            // Aloitetaan tekemällä sovellus, joka tulostaa lukuja 1 - käyttäjän syöttämä luku

            // 1. pyydetään käyttäjältä luku
            // 2. Luetaan ja tallennetaan luku muuttujaan
            //Console.Write("Syötä luku, johon asti tulostetaan: ");
            //int number = int.Parse(Console.ReadLine());

            // 3. luodaan silmukka, joka suoritetaan niin monta kertaa kuin 1 - käyttäjä luku on
            //      - while, pitää miettiä jokin sopiva ehto
            //      - jotta voidaan tulostaa numeroita 1 alkaen, tarvitaan muuttuja, joka on alussa 1

            //int i = 1; // iterointi: i++ => i++ => i == 3 jne

            // kysytään käyttäjältä halutaanko parillinen vai pariton
            //Console.Write("Parillinen / Pariton: ");
            //string input = Console.ReadLine();            

            //while (i <= number)
            //{
            //    // Lisätään ehto, joka tulostaa vain parittoman numeron
            //    if (i % 2 != 0 && input == "Pariton")
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else if (i % 2 == 0 && input == "Parillinen")
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++; // suoritetaan iteraatio jokaisella silmukan kierroksella
            //}

            // 4. silmukassa tulostetaan numero 1, jonka muuttuja iteroidaan joka kierros.
            // string EVEN_TEXT = "Parillinen";
            // string ODD_TEXT = "Pariton";

            //Console.Write("Syötä luku, johon asti tulostetaan: ");
            //int number = int.Parse(Console.ReadLine());

            //// while tarkistaa, että käyttäjä syöttää hyväksyttävän arvon
            //string input = ""; // Muuttuja luodaan ennen silmukkaa, jotta sitä voi käyttää ehdossa
            //bool inputFalse = true;

            //while (inputFalse == true) // Silmukka toistetaan, niin kauan kuin käyttäjän input on väärin
            //{               
            //    Console.Write($"{EVEN_TEXT} / {ODD_TEXT}: ");
            //    input = Console.ReadLine();

            //    if (input == EVEN_TEXT)
            //    {
            //        inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka
            //    }
            //    else if (input == ODD_TEXT)
            //    {
            //        inputFalse = false; // kun tämä muuttuja on false, pysähtyy silmukka
            //    }
            //}

            //// Käyttäjän syöte tarkistetaan aiemmin
            //int startingPoint = input == EVEN_TEXT ? 2 : 1;
            //// Parillinen alkaa 2
            //// Pariton alkaa 1

            //for (int i = startingPoint; i <= number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            // 27 C# Toisto: Tähtien tulostus
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159635

            //// 1. Pyydetään käyttäjältä numero ja tallennetaan se muuttujaan
            //Console.Write("Syötä numero: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Syötä merkki: ");
            //char symbol = char.Parse(Console.ReadLine());

            //// 2. Lisätään silmukka, joka suoritetaan käyttäjän syöttämän numeron verran
            //// Tulostetaan yksi tähti, toistetaan käyttäjän syöttämän numeron verran
            //// while / do while
            //// for
            //// foreach

            //// Muokataan sovellus tulostamaan käyttäjän syöttämä merkki

            //// jos number = 5 ja i = 1;  1, 2, 3, 4, 5 => suoritetaan 5 kertaa
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(symbol);
            //}

            // 30C C# Toisto: Kertymä (Yhdessä päivä 5)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159641

            //Console.Write("Syötä kierroslukumäärä: ");
            //int loops = int.Parse(Console.ReadLine());
            //int sum = 0;

            //// Summataan luvut 0:sta käyttäjän lukuun asti
            //for (int i = 0; i < loops; i++)
            //{
            //    // Summataan, tarvitaan muuttuja
            //    sum = sum + i;
            //}

            //Console.WriteLine($"{loops} kierrosta Kertymäksi saatiin: {sum}");



            // 31B C# Toisto: Lukujen summa ja keskiarvo (Yhdessä päivä 5)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159644

            Console.Write("Montako lukua summataan: ");
            int numbersToSum = int.Parse(Console.ReadLine());
            double sum = 0; // luodaan summa muuttuja silmukan ulkopuolella, muuten muuttuja aina resetoituu.

            // k:4, 0, 1, 2, 3 => 4 kierrosta
            for(int i = 0; i < numbersToSum; i++)
            {
                Console.Write($"Anna luku {i}: ");
                sum = sum + int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summa on:{sum} ja summan keskiarvo on:{sum/numbersToSum}");


            Console.ReadKey();
        }
    }
}
