using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria6_function_class_method_struct_enum_
{
    class Program // Luokka
    {
        static void Main(string[] args) // Funktio / Metodi
        {

            // 1. Funktio / Function
            //   Funktio on keino kapsuloida tietty toiminnallisuus, jota voidaan käyttää uudelleen
            //   eri kohdissa projektia.
            #region

            // Funktio ja metodi ovat melkein samoja, erona on niiden sijainti.
            // Metodi on termi funktiolle, joka on osana luokkaa.

            // Olemme kirjoittaneet koodia luokkaan nimeltä "Program" ja sen funktioon / metodiin
            // "Main"

            // Funktion / Metodi koodi tulee tiettyyn kohtaa tiedostoa.

            // Kun lähdemme tekemään uutta metodia, se täytyy kirjoittaa samalle tasolle muiden
            // metodien / funktioiden kanssa, luokan sisälle.

            // Tänne ei voi luoda uutta funktiota, koska olemme jo "Main"-funktion sisällä.
            // Metodi luotiin "Main"-funktion alapuolelle

            // Täällä voidaan käyttää metodia

            // UUSI TERMI: olio / object
            // olio on instanssi luokasta. Esimerkki: https://i.stack.imgur.com/lNUAA.png
            // Oletuksena metodeja voi ainoastaan käyttää, kun luokasta on luotu objekti.
            // Nyt uutta "printText()"-metodia ei voida käyttää, ellei luoda luokasta "Program"
            // uutta objektia.

            Program test = new Program(); // Luodaan tämän tiedoston "Program" luokasta objecti
            test.printText("Hello", 123);
            test.printText("World", 321);

            // Poikkeuksena staattinen metodi
            // Jos metodista luodaan staattinen, sitä ovi käyttää suoraan ilman objektia.

            // Esim:
            Console.WriteLine(""); // Tämä on "Console"-luokan staattinen "WriteLine()"-metodi
            // Program.multiplyNumbers(2, 10); // Viittaus "Program" luokkaan ei ole pakollinen
            // koska olemme sen luokan sisällä.
            // metodi palauttaa arvon, se pitää ottaa talteen.
            int fiveTimesThree = MultiplyNumbers(5, 3);
            // Tai käytetään palautettavaa arvoa suoraan toisessa metodissa.
            // Nyt metodin "multiplyNumbers()" palautetta arvo toimii parametrinä
            // metodille "WriteLine".
            Console.WriteLine(MultiplyNumbers(5, 3));

            #endregion


            // 2. Luokka / Class

            // Olio-ohjelmoinnin pohjimmainen idea on jakaa sovellus pieniin kokonaisuuksiin (luokkiin/olioihin)
            // Idea on jakaa laaja ongelma, pieniin osiin.
            // Sovelluksissa on pääsääntöisesti kahta asiaa: 1. Data (Property) 2. Toiminnallisuus (Method)
            // Luokkien idea on yhdistää oleellinen data ja toiminnallisuus yhteen pakettiin.

            // TODO: luokan lisäämisen omaan tiedostoon
            #region

            // Luokan luomisen sijainti, samalle tasolle muiden luokkien kanssa.
            // Tässä tiedostossa "Program"-luokan kanssa samalle tasolle.

            // Luodaan luokasta objekteja https://phpenthusiast.com/theme/assets/images/articles/classes_and_objects.jpg
            Person personA = new Person();
            personA.Age = 30;
            personA.Name = "Juho";
            Console.WriteLine($"Henkilön A nimi on:{personA.Name} ja ikä on:{personA.Age}");

            Person personB = new Person(25, "Matti", 1.8, new List<Pet>());

            Person personC = new Person(35, "Jesse", 179.6, new List<Pet>());


            // TODO: value type vs reference type

            #endregion


            // 3. struct
            #region
            #endregion


            // 4. enum
            #region
            #endregion


            // Pysäytetään sovellus lopussa.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } // Main function

        // Luodaan uusi metodi, muiden metodien ulkopuolelle, mutta luokan sisälle.

        // [näkyvyys] [palautettavaDatatyyppi] [metodinNimi] ( [parametrit], pilkulla eroteltuna )
        // Tämä funktio ottaa vastaan kaksi arvoa: string message ja int number
        // Metodi kirjoittaa consoliin parametrien sisällön
        private void printText(string message, int number)
        {
            // Private -näkyvyys tarkoittaa, että sitä ei voida käyttää luokan ulkopuolelta. Kirjoitetaan pienellä.
            // void -datatyyppi, ei palauta mitään.
            // parametrit -dataa, joka lähetetään funktioon.
            Console.WriteLine($"Text: {message}{number}");
        }

        // Luodaan staattinen metodi
        // avainsana "static" tulee näkyvyyden ja palautettavan datatyypin väliin.
        // Tämä metodi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen.
        public static int MultiplyNumbers(int number1, int number2)
        {
            // public -näkyy luokan ulkopuolelle, kirjoitetaan nimi isolla kirjaimella
            // static -tekee metodista staattisen (voi käyttää ilman objektia)
            // int - tämä metodi palauttaa int-arvon

            return number1 * number2; // Return avainsanalla palautetaan arvo.
        }

    } // Class Program päättyy

    // class - avainsana
    // Test - oma luokan nimi, isolla kirjaimella
    public class Person // Luokkien idea on mallintaa jotakin todellista asiaa. Tiettyyn pisteeseen saakka.
    {
        // 2a. Property
        // Data
        // kirjoita prop and sen jälkeen sarkain kaksi kertaa
        // Propertyn syntaksi: [Näkyvyys] [datatyyppi] [nimi] [get ja set]
        // [get ja set] get määrittää kuinka arvo luetaan ja set määrittää kuinka arvo tallennetaan
        public int Age { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Location CurrentLocation { get; set; }
        public List<Pet> Pets { get; set; }

        // 2b. Contructor
        // Erityis metodi, jolla tallennetaan objektiin oletusarvoja.
        // [Näkyvyys]
        // [nimi], jonka täytyy olla täysin sama kuin luokan nimi

        public Person() // Constructoria voi olla monta eri versiota.
        {

        }
        public Person(int age, string name, double length, List<Pet> pets)
        {
            Age = age;
            Name = name;
            Length = length;
            Pets = pets;
        }

        // 2c. Metodi / Method
        // Toiminnallisuus

        // Metodi palauttaa matkan pituuden uuden ja vanhan sijainnin välillä.
        public int Walk(Location newLocation)
        {
            int result = CurrentLocation.CoordinateX - newLocation.CoordinateX;

            CurrentLocation = newLocation; // Päivitetään uusi sijainti

            return result;
        }
    }

    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Location
    {
        public int CoordinateX { get; set; }
    }


} // Namespace
