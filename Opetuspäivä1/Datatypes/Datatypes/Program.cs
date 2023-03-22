using System;

namespace Datatypes
{ // ctrl-alt-7 
    class Program
    {
        static void Main(string[] args)
        {
            // -Koodi tulee tänne-

            // Termi: Syntax - syntaksi. Syntaksi määrittelee säännöt, kuinka koodia kirjoitetaan ja tietokone sen ymmärtää.

            // Tämä on kommentti, rivin alussa kaksi / merkkiä tekee rivistä kommentin. Kommentit eivät suorita mitään
            // Kommentteja käytetään muistiinpanoja varten ja selventämään koodin toimintaa.

            // Datatyypit - Datatypes
            // Data on keskeinen osa ohjelmien toimintaa. Kaikki sovellukset koostuu seuraavista perus datatyypeistä:

            // 1. Kokonaisluvut - Integer - int
            // 2. Desimaaluvut - Floating point number. Kolme eri koko luokkaa, double yleisin.
            //      - float, 4 tavua / 32 bittiä
            //      - double, 8 tavua / 64 bittiä
            //      - decimal, 16 tavua / 128 bittiä. Enemmän bittejä on tarkempi, mutta hitaampi suorittaa.
            // 3. Merkki - Character - char
            // 4. Merkkijono - string
            // 5. Totuusarvomuuttuja - boolean
            // 6. Ei mitään - null

            // Esimerkkejä arvoista:

            // int: -384 / 0 / 5 / 250000 - Ilmaisevat vain kokonaisluvun, ei pilkun jälkeisiä arvoja.
            // double: -8.254 / 0.001 / 3.14 / 599.99 - Ilmaisevat luvun, mukaan lukien pilkun jälkeiset desimaali numerot.
            // char: 'r' / '%' / '7' / '"' - Ilmaisee yhden merkin, heittomerkkien välissä.
            // string: "Hello" / "Number 7" / "gTsB6"!n(?#v" - Ilmaisee sarjan merkkejä yhtenä kokonaisuutena. String arvo on lainausmerkkien välissä.
            // bool: true / false - Ilmaisee onko jokin asia tai ei. Käytetään usein ilmaisemaan jokin vertailun lopputulos.
            // null: null     - Ilmaisee, että arvo puuttuu (vain referenssi datatyypit). Esimerkiksi string voi olla null.

            // Termi: Literaalit - Literals
            // Tämä termi viittaa datan konkreettiseen arvoon. Yllä olevia arvoja voidaan ilmaista termeillä: string literal "moi" tai int literal 7.


            // Ohjelmointi syntaksi vaatii paljon erilaisia välimerkkejä. Termistöön voi tutustua:
            // https://fi.wikipedia.org/wiki/V%C3%A4limerkki
            // https://fi.wikipedia.org/wiki/Sulkeet#Kaarisulkeet

            // Datatyypit itsessään ei riitä, vaan niiden lisäksi tarvitaan rakenne
            // jossa literaali arvot ovat tallessa ja niitä voi käyttää toistuvasti eri kohdissa koodia.
            // Rakenne on nimeltään: Muuttuja - Variable
            // Muuttujan syntaksi C# kielessä on seuraava: <data_type> <variable_name>
            // Esim: string name;    Huom. jokainen rivi koodia päättyy puolipisteeseen ;

            int age; // Tässä -int- on <data_type> ja -age- on <variable_name>
            age = 31; // Muuttujan arvo määritetään = merkillä. Oikealla puolella on uusi arvo.

            int newAge = 32; // Muuttujalle voidaan antaa arvo samalla, kun luodaan muuttuja
            age = newAge; // Muuttujaan voidaan tallentaa myös toisen muuttujan arvo. Nyt age muuttuja on 32.

            double temperature = 5.4; // double, desimaaliluku. Esimerkiksi lämpötila.
            
            char stopAt = ','; // Yksittäinen merkki. Jos tarvitaan käyttää jotakin merkkiä johonkin tarkoitukseen. Esimerkiksi pysäytetään merkkijonon luku kun kohdataan merkki ,

            string name = "Teemu"; // Merkkijono, eli useita merkkejä peräkkäin. Tallennetaan monipuolisesti tekstiä eri käyttöön.

            bool isUserLoggedIn = false; // Totuusarvomuuttuja, ilmaistaan onko jokin asia totta vai ei. Tällä muuttujalla voisi seurata, onko käyttäjä kirjautunut sisään.


            // Seuraavaksi, kuinka käyttäjä voi kommunikoida sovelluksen kanssa.
            // Konsolissa voidaan näyttää käyttäjälle tekstiä, sekä voidaan lukea käyttäjän syöte.

            Console.WriteLine(); // Syntaksi: <Class_Name>.<Method_Name>();  Tässä kohtaa ei tarvitse ymmärtää luokkaa tai metodia. Muista sulkeet() metodin jälkeen.
                                 // Tämä kirjoittaa konsoliin tekstin, joka on sulkeiden välillä(tässä tapauksessa ei ole tekstiä). Metodin Line-osa viittaa siihen, että
                                 // loppuun lisätään rivin vaihto.

            Console.ReadLine();  // Tällä metodilla voidaan lukea käyttäjän syöttämää tekstiä. Sovellus pysähtyy tähän kohtaa ja odottaa käyttäjän syötettä,
                                 // kunnes hän painaa "Enter".

            Console.WriteLine("Hello"); // Tämä kirjoittaa konsoliin string-literaali arvon "Hello".
            Console.WriteLine(name);    // Tämä kirjoittaa konsoliin muuttujan -name- arvon, eli "Teemu". Muuttuja oli luotu rivillä 61.

            string userName = Console.ReadLine(); // Kun luetaan käyttäjän syöttämää tekstiä, se täytyy tallentaa johonkin muuttujaan.
                                                  // Tässä luodaan uusi muuttuja -userName- ja siihen tallennetaan käyttäjän syöttämä arvo.

            // Harjoitus: luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"
            string message = "Hello";
            Console.WriteLine(message);

            // Seuraavaksi harjoitellaan muuttujan lisäämistä osaksi merkkijonoa.
            string input = Console.ReadLine();  // Ensin luodaan muuttuja ja luetaan siihen käyttäjän syöte.

            // Seuraavaksi on kolme eri tapaa lisätä muuttuja merkkijonoon https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine("Vastasit {0}", input); // Composite formaatti. Merkkijonon sekaan lisätään aaltosulkujen väliin indeksejä(0..1..2..3) alkaen nollasta.
                                                      // merkkijonon jälkeen pilkulla eroteltuna muuttujien nimet.
            Console.WriteLine($"Interpolating {input} voi jatkaa tekstiä"); // Interpolating formaatti on ehkä kätevin. Ennen merkkijonoa $-merkki, jolloin
                                                                            // merkkijonoon voi lisätä muuttujia aaltosulkujen sisällä.
            Console.WriteLine("Vastasit " + input + " lisää tekstiä");  // Lisäksi voidaan yhdistää erillisiä merkkijonoja ja muuttujia + merkillä.
                                                                        // Merkkijonot täytyy ensin sulkea lainausmerkillä ennen muuttujan lisäämistä.

            // matemaattiset operaatiot, toimivat kokonaisluku ja liukuluku muuttujilla.
            // + summataan luvut
            // - vähennetään luku toisesta luvusta
            // * kerrotaan luvut
            // / jaetaan luvut
            // % jakojäännös, eli mitä lukujen jakamisesta jää yli. Esimerkiksi 4/3 = 1, eli luku 3 menee lukuun 4 yhden kerran ja yli jää luku 1. Jakojäännös on 1.
            //                                                      Esimerkiksi 13/5 = 3, luku 5 menee lukuun 13 kaksi kertaa ja yli jää 3. Jakojäännös on 3
            int x = 5;
            int y = 2;

            int sum = x + y; // 5 + 2 = 7
            sum = sum - x;  // 7 - 5 = 2
            sum += y; // 2 + 2 = 4

            int multiply = x * y; // = 5 * 2 = 10
            multiply = multiply * x; // 10 * 5 = 50

            int divided = y / 2; // 2 / 2 = 1

            int modular = x % y; // 5 % 2 = 1


            // Tässä on käytetty region-ominaisuutta. Sillä ei ole vaikutusta sovelluksen toimintaan.
            // Voidaan käyttää koodin jäsentelyyn, luettavuuden kannalta.
            // Visual Studio editorin vasemmassa laidassa on painike, jolla osion voi pienentää tai laajentaa.
            #region 3 C# Perus: Ikä-tehtävä 

            Console.Write("Anna ikäsi: "); // Ilmaistaan käyttöliittymässä, mitä tietoa käyttäjältä halutaan. Huomioi .Write-metodi
            string userInput = Console.ReadLine(); // Luetaan käyttäjän syöte, joka tallennetaan string-muuttujaan.
            int userAge = int.Parse(userInput); // Oletetaan, että käyttäjä on syöttänyt ikänsä numeerisessa muodossa.
                                                // Tällöin int.Parse-metodi pystyy muokkaamaan tekstin(string) integer(int) muotoon.
            
            Console.WriteLine($"Olet {userAge} vuotta!"); // Näytetään käyttäjän syöttämä arvo takaisin käyttäjälle.
                                                          // On käytetty Interpolating syntaksia, jolla voi helposti lisätä muuttujan osaksi string-arvoa.
                                                          // Huomioi '$' ennen tekstiä.

            // userInput muokattiin integer muotoon muuttujaan userAge, joka on hieman turha jos sillä ei suoriteta matemaattisia operaatioita.
            // Lisätään ominaisuus, että käyttäjän ikä ilmoitetaan myös kuukausissa.

            int monthsPerYear = 12;
            Console.WriteLine($"Olet {userAge * monthsPerYear} vuotta!");

            #endregion

            #region 4 C# Perus: Palkan lasku
            // Tämä tehtävä käydään yhdessä maanantaina, mutta voitte yrittää ratkaista itse.
            // Pyydä käyttäjältä 4 eri arvoa ja suorita lasku.
            #endregion

        }
    }
}
