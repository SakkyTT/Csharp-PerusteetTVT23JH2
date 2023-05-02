using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä12Harjoitukset
{
    class Program
    {
        static void Main(string[] args) // Main funktio alkaa
        {
            // Find out whether the shape is a cube
            // https://www.codewars.com/kata/58d248c7012397a81800005c/train/csharp
            Console.WriteLine(IsCube(125, 6));

            // Remove First and Last Character
            Console.WriteLine(Remove_char("testaus"));


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } // Main funktio päättyy

        // Find out whether the shape is a cube
        // https://www.codewars.com/kata/58d248c7012397a81800005c/train/csharp
        public static bool IsCube(double volume, double side)
        {
            // Tarkistetaan, että parametrin ovat suurempia kuin nolla.
            if (volume <= 0 && side <= 0)
            {
                return false;
            }

            // Kokeillaan mikä olisi tilavuus, jos side on kuution sivu.
            // Tässä lasketaan kuution tilavuus
            double testedVolume = side * side * side; // Math.Pow(side, 3); - toinen vaihtoehto

            // Testataan täsmääkö parametrin volume muuttujan arvo
            // Metodissa lasketun kuution arvoa.
            if (volume == testedVolume)
            {
                return true; // Palautetaan true ja metodi päättyy.
            }

            return false;
        }

        // Remove First and Last Character
        // https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
        public static string Remove_char(string s)
        {
            // "testi" -> "est"
            // "testaus" -> "estau"

            string result = "";

            // Silmukka jättää välistä merkkijonon ensimmäisen ja viimeisen indeksin,
            // koska i alkaa indeksistä 1 ja päättyy Length - 1.
            for (int i = 1; i < s.Length - 1; i++)
            {
                result += s[i]; // Lisätään merkki uuteen string muuttujaan.
            }

            // Your Code
            return result;
        }

    }
}
