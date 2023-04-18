using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä9Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Funktiot: Keskiarvo metodi (Yhdessä päivä 9)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1165933
            #region

            // Lisää tähän tiedostoon uusi metodi, joka ottaa vastaan parametrinä taulukon
            // int lukuja ja palauttaa taulukon keskiarvon.
            int[] someValues = new int[4];
            someValues[0] = 5;
            someValues[1] = 8;
            someValues[2] = 6;
            someValues[3] = 100;

            Console.WriteLine(average(someValues));

            #endregion



            // C# Funktiot: Kolmion pinta ala (Yhdessä päivä 9)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159673
            #region

            Console.Write("Syötä korkeus: ");
            double heigthTriangle = double.Parse(Console.ReadLine());

            Console.Write("Syötä kanta: ");
            double baseTriangle = double.Parse(Console.ReadLine());

            //double area = heigthTriangle * baseTriangle / 2;
            //area = heigthTriangle * baseTriangle / 2;
            //area = heigthTriangle * baseTriangle / 2;
            //area = heigthTriangle * baseTriangle / 2;

            double area = triangleArea(heigthTriangle, baseTriangle);
            area = triangleArea(heigthTriangle, baseTriangle);
            area = triangleArea(heigthTriangle, baseTriangle);
            area = triangleArea(heigthTriangle, baseTriangle);

            Console.WriteLine($"Kolmion pinta-ala: {area}");

            #endregion

            // C# Funktiot: Verolaskuri (Yhdessä päivä 9)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159678&forceview=1
            #region

            Console.Write("Syötä bruttopalkka: ");
            decimal grossSalary = decimal.Parse(Console.ReadLine());

            Console.Write("Syötä veroprosentti: ");
            decimal taxPercentage = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nettopalkka on: {netSalary(grossSalary, taxPercentage)}");

            #endregion


            // Pysäytetään sovellus lopussa.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } // Main

        // C# Funktiot: Keskiarvo metodi (Yhdessä päivä 9)
        // https://moodle.sakky.fi/mod/assign/view.php?id=1165933
        #region
        private static double average(int[] numbers)
        {

            // Algoritmi, joka laskee keskiarvon
            int count = 0;
            double sum = 0;

            foreach (double temp in numbers)
            {
                sum += temp;
                count++;
            }

            return sum / count;
        }
        #endregion


        // C# Funktiot: Keskiarvo metodi (Yhdessä päivä 9)
        // https://moodle.sakky.fi/mod/assign/view.php?id=1165933
        #region

        private static double triangleArea(double heigthTriangle, double baseTriangle)
        {
            return heigthTriangle * baseTriangle / 2;
        }

        #endregion


        // C# Funktiot: Verolaskuri (Yhdessä päivä 9)
        // https://moodle.sakky.fi/mod/assign/view.php?id=1159678&forceview=1
        #region
        
        private static decimal netSalary(decimal grossSalary, decimal taxPercentage)
        {
            decimal result = 0;

            // Tässä välissä lasketaan lopputulos
            result = (grossSalary / 100) * (100 - taxPercentage);

            return result;
        }

        #endregion
    }
}
