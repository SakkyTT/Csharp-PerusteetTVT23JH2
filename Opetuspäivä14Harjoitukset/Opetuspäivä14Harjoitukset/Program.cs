using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä14Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet funktiota pitää itse testata jollakin arvoilla.
            Console.WriteLine(Greet("Toni"));

            // Jos haluaa koodissa verrata arvoja (metodin toimivuus)
            if (Greet("Ryan") == "Hello, Ryan how are you doing today?")
            {
                Console.WriteLine("Metodi toimii!");
            }
            else
            {
                Console.WriteLine("Metodi ei toimi!");
            }

            // Testaus
            if (CountPositivesSumNegatives(new int[] { 5, 3, 8, -5, -9, 3 })
                == new int[] {4, -99 })
            {
                // Kun verrataan objekteja "== vertailu", ainoastaan tarkistaa
                // viittaako muuttujat samaan objektiin muistissa.
                // Se ei tutki objektien sisältöä.
                Console.WriteLine("Metodi toimii!");
            }


            Console.ReadKey();

        }
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            // Jos taulukko "input" on tyhjä tai taulukko "input" on null
            // palautetaan tyhjä taulukko
            if (input.Length == 0 || input == null)
            {
                return new int[0];
            }

            // Luodaan uusi taulukko, johon tallennetaan palautettavat arvot.
            int[] result = new int[2];

            // Lasketaan input-taulukosta positiivisien arvojen lukumäärä.
            // for silmukka toimii myös
            //foreach (int number in input)
            //{
            //    // Tarkistetaan, että arvo on positiivinen
            //    if (number > 0)
            //    {
            //        result[0]++;
            //    }
            //    else
            //    {
            //        result[1] += number;
            //    }
            //}

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0) // Positiiviset arvot
                {
                    // Kasvatetaan positiivisien arvojen lukumäärän laskua.
                    result[0]++;
                }
                else // Negatiiviset arvot
                {
                    // Summataan negatiiviset arvot.
                    result[1] = result[1] + input[i];
                }
            }

            //return an array with count of positives and sum of negatives
            return result;
        }
    }
}
