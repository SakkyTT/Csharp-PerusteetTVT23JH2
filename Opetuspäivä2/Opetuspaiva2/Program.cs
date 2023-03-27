using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspaiva2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Harjoitus 22.3.

            int age = 31; // Integer - kokonaisluku
            age = 32;  // Muokataan muuttujan arvo
            // " = shift+2
            // { = ctrl + alt + 7
            // } = ctrl + alt + 0
            // $ = ctrl + alt + 4
            Console.WriteLine($"{age} on käyttäjän ikä");

            double height = 1.78; // Double - liukuluku(desimaalit)            
            height = 1.8;
            Console.WriteLine($"{height} on käyttäjän pituus");

            string name = "Teemu"; // Merkkijono
            name = "Pekka";
            Console.WriteLine($"{name} käyttäjän nimi.");

            bool loggedIn = true; // boolean - totuusarvomuuttuja
            loggedIn = false;
            Console.WriteLine($"Käyttäjä on kirjautunut: {loggedIn}");

            // ' -> Ä oikealla puolella
            char replaceWith = 't'; // char, yksi merkki
            replaceWith = 'T';
            Console.WriteLine($"Korvataan kirjaimella {replaceWith}");

            // Harjoitus 23.3.
            string userInput; // Tallennetaan käyttäjän syöttämä arvo
            Console.WriteLine();
            Console.WriteLine("Harjoitus 23.3.");
            Console.Write("Anna pituus metreinä: ");
            userInput = Console.ReadLine(); // Käyttäjän syöttämä luku tallessa
            
            // Muokataan string arvo double dataksi
            double length = double.Parse(userInput);

            Console.Write("Anna leveys metreinä: ");
            userInput = Console.ReadLine();
            double width = double.Parse(userInput);

            double area = length * width;
            Console.WriteLine($"Alueen pinta-ala: {area}");


            // 4 C# Perus: Palkan lasku (yhdessä 27.3.)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159587
            Console.WriteLine(); // Tyhjä rivi, erotellaan edelliset koodit

            // Muuttujat
            string input; // Tallennetaan käyttäjän arvot

            // Tuntipalkka
            double hourlySalary;

            // Tunnit, joista maksetaan 100% palkka
            double normalHours;

            // Tunnit, joista maksetaan 150% palkka
            double plus50PercentHours;

            // Tunnit, joista maksetaan 200% palkka
            double plus100PercentHours;

            // Laskettu kuukausipalkka
            double totalSalary;

            Console.Write("Anna tuntipalkka: ");
            input = Console.ReadLine();
            hourlySalary = double.Parse(input);
            
            Console.Write("Anna normaalit tunnit: ");
            // Käyttäjän arvon lukeminen ilman -input- muuttujan käyttöä
            normalHours = Double.Parse(Console.ReadLine());

            Console.Write("Anna 50% korotetut tunnit: ");
            plus50PercentHours = double.Parse(Console.ReadLine());

            Console.Write("Anna 100% korotetut tunnit: ");
            input = Console.ReadLine();
            plus100PercentHours = double.Parse(input);

            // Laskuoperaatio
            // Laskuoperaation voi jakaa usealle riville
            // Laskukaavassa arvot 1.5 ja 2 käytetään termiä "Magic number"
            // ratkaisu olisi tallentaa arvot sopivan nimisiin muuttujiin.
            // Erityisesti jos arvoa käytetään useaan kertaan.
            totalSalary = hourlySalary * normalHours + 
                       hourlySalary * 1.5 * plus50PercentHours +
                       hourlySalary * 2 * plus100PercentHours;

            Console.WriteLine($"Kuukausi palkka on {totalSalary}");

            // 5 C# Perus: Keskiarvo (yhdessä 27.3.)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159588
            Console.WriteLine(); // Tyhjä rivi

            Console.Write("Anna luku 1: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku 2: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku 3: ");
            int value3 = int.Parse(Console.ReadLine());

            double resultError = (value1 + value2 + value3) / 3; // Tässä lasketaan integer arvojen kanssa, lopputulos on integer, jolloin desimaalit eivät jää talteen
            double result = (value1 + value2 + value3) / 3d; // Lisätään luvun 3 perään d, tällöin arvo on double muotoa. Laskuoperaation int ja double välillä lopputulos on double, eli desimaalit jäävät talteen.
            Console.WriteLine($"Keskiarvo: {resultError} - Virhe");
            Console.WriteLine($"Keskiarvo: {result}");

            // 6 C# Perus: Kolmion pinta-ala(yhdessä 27.3.)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159590
            Console.WriteLine(); // Tyhjä rivi

            // Viimeinen harjoitus
            // Kun valmista harjoitellaan myös GitHub
            // Lopetellaan 20:00

            // Ruokailu
            //  - aika 15:45 - 16:15
            //  - TE-opiskelijat, maksaa itse
            // Opintotoimisto -infot

            // Aiheista vielä Moodle viestit






            // Koodin lopussa, jota sovellus ei sammu automaattisesti
            Console.ReadKey();
        }
    }
}
