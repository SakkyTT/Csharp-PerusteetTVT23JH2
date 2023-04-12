using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Päivän6Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# for ja switch
            //https://moodle.sakky.fi/mod/assign/view.php?id=1163232
            #region
            //double initialValue = 12d;

            //// Luodaan for silmukka, joka tapahtuu 4 kertaa
            //// 1 - 2 - 3 - 4
            //for (int i = 1; i < 5; i++)
            //{
            //    switch (i) // Sulkujen sisällä tutkittava arvo
            //    {
            //        case 1:
            //            // Koodi
            //            initialValue += i;
            //            break; // Päättää switch rakenteen suorituksen
            //        case 2:
            //            initialValue = initialValue * i;
            //            break;
            //        case 3:
            //            initialValue /= i;
            //            break;
            //        case 4:
            //            initialValue = initialValue - i;
            //            break;
            //    }
            //}

            //Console.WriteLine($"Lopputulos: {initialValue}");

            #endregion


            // 33 C# String: Merkkien tulostus
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159653&forceview=1
            #region
            //// Esimerkki käyttäjän syötteestä: "Lattia A" "Seinä L"

            //// merkki " - voidaan näyttää käyttäjälle kenoviilalla \ ennen "-merkkiä. ctrl+alt+?
            //Console.Write("Syötä sana ja tulostus suunta (\"Lattia A\"): ");
            //string input = Console.ReadLine();
            //string[] inputSplit = input.Split(' ');
            //// inputSplit[0] == "terve"
            //// inputSplit[1] == "L"

            //// Tarvitaan valintarakenne, jolla tutkitaan tulostuksen suuntaa
            //// Ehtorakenne kääntää string merkkien järjestyksen
            //if (inputSplit[1] == "A") // Alusta
            //{
            //    // Tätä ei periaatteessa tarvita
            //}
            //else if (inputSplit[1] == "L") // Lopusta
            //{
            //    char[] chars = inputSplit[0].ToCharArray(); // "Testi" => ['T', 'e', 's', 't', 'i']
            //    Array.Reverse(chars);                       // => ['i', 't', 's', 'e', 'T']
            //    string test = new string(chars);            // => "itseT"
            //    inputSplit[0] = test;                       // Tallennetaan uusi "itseT"-string taulukon indeksiin 0
            //}

            //foreach (char jokinNimi in inputSplit[0])
            //{
            //    Console.WriteLine(jokinNimi);
            //}
            #endregion


            // 34C C# String: Poista kirjaimia alusta ja lopusta
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159656
            #region
            string input = "";
            string[] splitInput = new string[1]; // Placeholder taulukko
            bool inputHasErrors = true;

            while (inputHasErrors == true)
            {
                Console.Write("Syötä sana ja poistettavien merkkien määrä(\"Omena\" 1): ");
                input = Console.ReadLine();

                splitInput = input.Split(' ');
                // Tällä taulukolla on indeksit 0 ja 1

                // Muokataan "inputHasErrors"-totuusmuuttujan arvo false, jos käyttäjän syöte on OK.
                // Tällöin silmukka päättyy.
                // TODO: error checking and place ReadLine inside a loop until passes error checking
                // [ luku > 0 ] JA [ luku * 2 < sana.Length ]

                // splitInput[0] == käyttäjän syöttämä sana
                // splitInput[1] == käyttäjän syöttämä numero
                // 0 == vähintään poistettavien merkkien määrä
                // 2 == lasketaan yhteensä poistettavien merkkien määrä kertomalla poistettavat merkit kahdella
                //      alusta ja lopusta == kertaa 2
                if (int.Parse(splitInput[1]) > 0 && int.Parse(splitInput[1]) * 2 < splitInput[0].Length)
                {
                    inputHasErrors = false;
                }

            }



            // Vaihtoehto 1
            // Otetaan käyttäjän sanasta Substring
            // Substring vaatii aloitus indeksin ja montako merkkiä otetaan talteen aloituskohdasta lähtien.

            //               0123456 <- string arvon indeksit
            // Esimerkiksi: "testaus" 2
            // Tarvittavat arvot Substring-metodiin alla:
            // Nämä indeksit on itse sen string merkkijonon indeksejä.
            // Aloitusindeksi: 2
            // Tallennettavien merkkien määrä: 3 => sanan pituus - alun poisto - lopun poisto = merkkien määrä
            //                                  splitInput[0].Length - poistettavat merkit * 2 = merkkien määrä

            // UUSI TERMI: parametri, on metodin sulkujen sisälle syötetyt arvot.
            //             overload, metodi voi ottaa vastaan eri määrän parametrejä. Overload ilmaisee montako vaihtoehtoa on.
            //             Hiiri metodin päällä: ctrl+K sitten ctrl+P, voi käydä läpi kaikki eri overload vaihtoehdot.
            string result1 = splitInput[0].Substring(int.Parse(splitInput[1]), splitInput[0].Length - (int.Parse(splitInput[1]) * 2));
            Console.WriteLine(result1);
            // Vaihtoehto 1



            // Vaihtoehto 2
            // Tehdään silmukka, jossa tallennetaan merkkejä yksi kerrallaan
            // "testaus 2" Aloitetaan silmukka kolmannesta merkistä ja jatketaan viimeiseen kopioitavaan indeksiin.
            // => "sta"

            string result2 = ""; // Tähän lisätään merkkejä yksi kerrallaan
            // StringBuilder => jos suorityskyky ongelmia

            // Silmukka alkaa ensimmäisen tallennettavan merkin indeksistä ja loppuu viimeiseen tallennettavaan indeksiin.
            for (int i = int.Parse(splitInput[1]); i < splitInput[0].Length - int.Parse(splitInput[1]); i++)
            {
                result2 += splitInput[0][i]; // kopioidaan merkki käyttäjän sanan tietystä indeksistä.
                // splitInput[0] viittaa käyttäjän sanaan eli => "testaus"[i]
            }
            Console.WriteLine(result2);
            // Vaihtoehto 2

            #endregion


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
