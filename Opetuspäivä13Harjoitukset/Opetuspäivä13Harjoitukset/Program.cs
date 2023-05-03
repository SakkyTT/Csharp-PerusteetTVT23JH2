using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä13Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {

            // Kokeillaan metodia
            int[] testArray = new int[] {-5, 4, -8 };
            InvertValues(testArray);

            Console.ReadKey();
        }

        // Invert values
        // https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/train/csharp
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            // Silmukka, jossa suoritetaan alla oleva operaatio kaikille
            // taulukon arvoille.
            // Käänteinen arvo: arvo[i] = arvo[i] * -1;

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * -1;
            }

            return input;
        }


        // The Feast of Many Beasts
        // https://www.codewars.com/kata/5aa736a455f906981800360d/train/csharp

        public static bool Feast(string beast, string dish)
        {
            if (beast[0] != dish[0])
            {
                return false;
            }

            if (beast[beast.Length-1] != dish[dish.Length-1])
            {
                return false;
            }

            return true;
        }

        // Thinkful - Logic Drills: Traffic light
        // https://www.codewars.com/kata/58649884a1659ed6cb000072/train/csharp
        public static string UpdateLight(string current)
        {
            string result = "";

            switch (current)
            {
                case "green":
                    result = "yellow";
                    break;
                case "yellow":
                    result = "red";
                    break;
                case "red":
                    result = "green";
                    break;
            }

            return result;
        }
    }
}
