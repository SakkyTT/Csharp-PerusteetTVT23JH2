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


            // C# Funktiot: MeterConverter
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159680

            Console.Write("Syötä mitta(m): ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine($"{meters}m sentteinä on:{MeterConverter.ToCentimeter(meters)}");
            Console.WriteLine($"{meters}m kilometreinä on:{MeterConverter.ToKilometer(meters)}");


            // last digits of a number
            // https://www.codewars.com/kata/5cd5ba1ce4471a00256930c0/train/csharp
            // Testaus
            LastDigit(1, 1);
            LastDigit(123767, 4);
            LastDigit(0, 1);
            LastDigit(34625647867585, 10);
            LastDigit(1234, 0);
            LastDigit(24134, -4);
            LastDigit(1343, 5);


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

        // last digits of a number
        // https://www.codewars.com/kata/5cd5ba1ce4471a00256930c0/train/csharp
        public static int[] LastDigit(long n, int d)
        {
            // Jos d on negatiivinen, palautetaan tyhjä taulukko
            if (d < 0)
            {
                return new int[] { };
            }

            // n == 123456
            // d == 4
            // return == [3, 4, 5, 6]

            // Ensin n -> ToString(), jotta voidaan käsitellä numeroita yksi
            // kerrallaan. 123456 -> "123456"

            string asText = n.ToString();

            // Jos pyydetään enemmän numeroita kun luvussa on,
            // Päivitetään parametrin d pituus
            if (d > asText.Length)
            {
                d = asText.Length;
            }


            int[] result = new int[d];
            // Aloitetaan taulukon viimeisestä indeksistä
            int arrayIndex = result.Length - 1;

            // Kopioidaan uudesta string muuttujasta arvot lopusta alkua kohti
            // Aloitetaan viimeisestä indeksistä
            // ja suoritetaan d(parametri) kertaa
            // Length == 6
            // d == 4
            // 6 - 4 == 2
            for (int i = asText.Length - 1; i >= asText.Length - d; i--)
            {
                result[arrayIndex] = int.Parse(asText[i].ToString());
                arrayIndex--;
            }

            return result;
        }

        // Is he gonna survive?
        // https://www.codewars.com/kata/59ca8246d751df55cc00014c/train/csharp
        public static bool Hero(int bullets, int dragons)
        {
            // 4, 5 * 2
            // Tarvittavien luotien määrä on kaksi kertaa dragons
            // Testataan, onko bullets >= tarvittavien luotien määrä
            //Do Some Magic...
            return dragons * 2 <= bullets ? true : false;
        }

        // C# CodeWars - Find the index of the second occurrence of a letter in a string
        // https://moodle.sakky.fi/mod/assign/view.php?id=1169035&forceview=1
        public static int SecondSymbol(string str, char symbol)
        {
            int foundInstances = 0; // Otetaan talteen montako kertaa symbol on löytynyt

            for (int i = 0; i < str.Length; i++) // Käydään läpi merkkijono parametri str
            {
                if (str[i] == symbol) // Onko merkki sama kuin symboli, jota haetaan
                {
                    if (foundInstances < 1) // Ensimmäinen löytö
                    {
                        // Otetaan talteen, että symbol on löytynyt
                        foundInstances++;
                    }
                    else // toinen löytö, palautetaan heti indeksi
                    {
                        return i;
                    }

                }
            }
            return -1; // Jos ei löydy kahta kertaa
        }
    }
}
