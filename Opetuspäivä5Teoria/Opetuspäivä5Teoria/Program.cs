using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä5Teoria
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1. Merkkijono
            // string - immutable == arvoa ei pysty muokkaamaan muistissa
            #region

            // Merkkijonoa voi ajatella kokoelmana yksittäisiä merkkejä. "monitor" => ['m', 'o', 'n', 'i', 't', 'o', 'r']

            // Yleisiä string datatyypin metodeja:
            //  - Length: palauttaa merkkijonon pituuden. Esim: "word".Length == 4
            //  - IndexOf: palauttaa merkin tai merkkijonon sijainnin merkkijonossa. Esim: "Tuesday".IndexOf("e") == 2 tai "wednesday".IndexOf("day") == 6
            //  - ToUpper ja ToLower: luo uuden string arvon, jossa kirjaimet ovat joko isoilla tai pienillä. Esim: "Cat".ToLower() == "cat".ToUpper() == "CAT"
            //  - Substring: palauttaa osan merkkijonosta. Esim: "Potato".Substring(2) == "tato" tai "Potato".Substring(2, 2) == "ta"
            //  - Replace: palauttaa merkkijonon, johon on korvattu tietyt merkit. Esim: "honday".Replace("h", "m") == "monday"
            //  - Trim: palauttaa merkkijonon, josta on poistettu merkkijonon alusta ja lopusta välilyönnit. Esim: "  Hello World!  ".Trim() == "Hello World!"

            // string muuttujaa voidaan käsitellä silmukassa samalla tavalla kuin taulukoita.

            //string text = "Hello";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine(text[i]); 
            //}


            // Huomioitavaa, että string on immutable datatyyppi. Kun string muuttujan arvoa muokataan, se korvataan muistissa uudella arvolla.
            // Eli alkuperäistä arvoa ei muokata, vaan luodaan uusi muokattu kopio.
            // Tämän vuoksi jossakin tilanteissa kun muokataan toistuvasti string muuttujaa, suorituskyvyn vuoksi käytetään StringBuilder datatyyppiä sen sijaan.
            // StringBuilder on mutable datatyyppi, jolloin editoitaan muistissa olevaan dataa suoraan.

            // Esim: Tämä koodi lisää string muuttujaan text arvon i, miljoona kertaa. Tämä koodi luo miljoona uutta string muuttujaa muistiin.
            // Tässä tilanteessa StringBuilder olisi parempi vaihtoehto.

            //string text = "";
            //for (int i = 0; i < 1_000_000; i++)
            //{
            //    text += i;
            //}

            #endregion


            // 2. Taulukko
            // Array - mutable = arvoa pystytään muokkaamaan muistissa
            #region

            // Taulukkoa käytetään säilyttämään saman datatyypin arvoja.
            // Taulukko on muuttuja, jossa on tallessa useampi arvo.
            // Taulukoiden syntaksi:

            int[] myArrayA; // luodaan int taulukko
            int[] myArrayB = new int[5];
            int[] myArrayC = { 1, 2, 3, 4, 5 };
            int firstElement = myArrayC[0];

            int length = myArrayC.Length; // 
            Array.Sort(myArrayC);  // Järjestää arvot pienimmästä suurimpaan
            Array.Reverse(myArrayC); // Kääntää arvot lopusta alkuun



            // Ei taulukkoa vs taulukko

            // Pyydä käyttäjältä 3 lukua talteen

            // ei taulukkoa
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Syötä 3 lukua: ");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            // taulukko
            int[] nums = new int[3];

            Console.WriteLine("Syötä 3 lukua: ");

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            // Pyydä käyttäjältä 100 lukua talteen



            // ei talukkoa
            int num1b; int num2b; int num3b; int num4; int num5; int num6; int num7; int num8; int num9; int num10;
            int num11; int num12; int num13; int num14; int num15; int num16; int num17; int num18; int num19; int num20;
            int num21; int num22; int num23; int num24; int num25; int num26; int num27; int num28; int num29; int num30;
            int num31; int num32; int num33; int num34; int num35; int num36; int num37; int num38; int num39; int num40;
            int num41; int num42; int num43; int num44; int num45; int num46; int num47; int num48; int num49; int num50;
            int num51; int num52; int num53; int num54; int num55; int num56; int num57; int num58; int num59; int num60;
            int num61; int num62; int num63; int num64; int num65; int num66; int num67; int num68; int num69; int num70;
            int num71; int num72; int num73; int num74; int num75; int num76; int num77; int num78; int num79; int num80;
            int num81; int num82; int num83; int num84; int num85; int num86; int num87; int num88; int num89; int num90;
            int num91; int num92; int num93; int num94; int num95; int num96; int num97; int num98; int num99; int num100;

            Console.WriteLine("Syötä 100 lukua: ");

            num1 = int.Parse(Console.ReadLine()); num2 = int.Parse(Console.ReadLine()); num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine()); num5 = int.Parse(Console.ReadLine()); num6 = int.Parse(Console.ReadLine());
            num7 = int.Parse(Console.ReadLine()); num8 = int.Parse(Console.ReadLine()); num9 = int.Parse(Console.ReadLine());
            num10 = int.Parse(Console.ReadLine()); num11 = int.Parse(Console.ReadLine()); num12 = int.Parse(Console.ReadLine());
            num13 = int.Parse(Console.ReadLine()); num14 = int.Parse(Console.ReadLine()); num15 = int.Parse(Console.ReadLine());
            num16 = int.Parse(Console.ReadLine()); num17 = int.Parse(Console.ReadLine()); num18 = int.Parse(Console.ReadLine());
            num19 = int.Parse(Console.ReadLine()); num20 = int.Parse(Console.ReadLine()); num21 = int.Parse(Console.ReadLine());
            num22 = int.Parse(Console.ReadLine()); num23 = int.Parse(Console.ReadLine()); num24 = int.Parse(Console.ReadLine());
            num25 = int.Parse(Console.ReadLine()); num26 = int.Parse(Console.ReadLine()); num27 = int.Parse(Console.ReadLine());
            num28 = int.Parse(Console.ReadLine()); num29 = int.Parse(Console.ReadLine()); num30 = int.Parse(Console.ReadLine());
            num31 = int.Parse(Console.ReadLine()); num32 = int.Parse(Console.ReadLine()); num33 = int.Parse(Console.ReadLine());
            num34 = int.Parse(Console.ReadLine()); num35 = int.Parse(Console.ReadLine()); num36 = int.Parse(Console.ReadLine());
            num37 = int.Parse(Console.ReadLine()); num38 = int.Parse(Console.ReadLine()); num39 = int.Parse(Console.ReadLine());
            num40 = int.Parse(Console.ReadLine()); num41 = int.Parse(Console.ReadLine()); num42 = int.Parse(Console.ReadLine());
            num43 = int.Parse(Console.ReadLine()); num44 = int.Parse(Console.ReadLine()); num45 = int.Parse(Console.ReadLine());
            num46 = int.Parse(Console.ReadLine()); num47 = int.Parse(Console.ReadLine()); num48 = int.Parse(Console.ReadLine());
            num49 = int.Parse(Console.ReadLine()); num50 = int.Parse(Console.ReadLine()); num51 = int.Parse(Console.ReadLine());
            num52 = int.Parse(Console.ReadLine()); num53 = int.Parse(Console.ReadLine()); num54 = int.Parse(Console.ReadLine());
            num55 = int.Parse(Console.ReadLine()); num56 = int.Parse(Console.ReadLine()); num57 = int.Parse(Console.ReadLine());
            num58 = int.Parse(Console.ReadLine()); num59 = int.Parse(Console.ReadLine()); num60 = int.Parse(Console.ReadLine()); num61 = int.Parse(Console.ReadLine());
            num62 = int.Parse(Console.ReadLine()); num63 = int.Parse(Console.ReadLine()); num64 = int.Parse(Console.ReadLine()); num65 = int.Parse(Console.ReadLine());
            num66 = int.Parse(Console.ReadLine()); num67 = int.Parse(Console.ReadLine()); num68 = int.Parse(Console.ReadLine()); num69 = int.Parse(Console.ReadLine());
            num70 = int.Parse(Console.ReadLine()); num71 = int.Parse(Console.ReadLine()); num72 = int.Parse(Console.ReadLine()); num73 = int.Parse(Console.ReadLine());
            num74 = int.Parse(Console.ReadLine()); num75 = int.Parse(Console.ReadLine()); num76 = int.Parse(Console.ReadLine()); num77 = int.Parse(Console.ReadLine());
            num78 = int.Parse(Console.ReadLine()); num79 = int.Parse(Console.ReadLine()); num80 = int.Parse(Console.ReadLine()); num81 = int.Parse(Console.ReadLine());
            num82 = int.Parse(Console.ReadLine()); num83 = int.Parse(Console.ReadLine()); num84 = int.Parse(Console.ReadLine()); num85 = int.Parse(Console.ReadLine());
            num86 = int.Parse(Console.ReadLine()); num87 = int.Parse(Console.ReadLine()); num88 = int.Parse(Console.ReadLine()); num89 = int.Parse(Console.ReadLine());
            num90 = int.Parse(Console.ReadLine()); num91 = int.Parse(Console.ReadLine()); num92 = int.Parse(Console.ReadLine()); num93 = int.Parse(Console.ReadLine());
            num94 = int.Parse(Console.ReadLine()); num95 = int.Parse(Console.ReadLine());



            // taulukko
            int[] nums100 = new int[100];

            Console.WriteLine("Syötä 100 lukua: ");

            for (int i = 0; i < nums100.Length; i++)
            {
                nums100[i] = int.Parse(Console.ReadLine());
            }

            #endregion

            // 3. Lista
            // List - mutable
            #region

            // Lista on kooltaan dynaaminen ja ominaisuuksiltaan laajempi kuin taulukko
            // Lista on hieman hitaampi ja vie enemmän muistia. Mutta sillä on merkitystä vasta kun käsitellään suurta määrää dataa ja sovelluksella on suorituskyky vaatimuksia.

            // Listan luonti

            List<int> myListA; // Luodaan muuttuja listaa varten, mutta siihen ei ole vielä tallennettu listaa.
            List<int> myListB = new List<int>(); // Luodaan lista muuttuja siihen tallennetaan tyhjä lista objecti.
            List<int> myListC = new List<int> { 1, 2, 3, 4, 5 }; // Luodaan lista muuttuja ja objekti, jossa on valmiiksi arvoja
            int firstElementList = myListC[0]; // Listan elementtien haku indeksillä


            // Listan metodeja == objektin toiminnallisuutta

            int count = myListC.Count; // Poikkeus: tämä on property, jossa on tallessa listan elementtien lukumäärä.
            myListC.Add(6); // Lisätään listan loppuun uusi arvo 6
            myListC.Insert(0, 9); // Lisätään listan indeksiin tietty arvo. Tässä tallennetaan indeksiin 0, arvo 9
            myListC.Remove(3); // Poistetaan listasta ensimmäinen esiintymä arvosta 3
            myListC.RemoveAt(4); // Poistetaan listasta elementti indeksistä 4
            bool containsThree = myListC.Contains(3); // Palauttaa totuusarvomuuttujan, löytyykö listasta arvo 3 tai ei. true / false
            myListC.Sort(); // Järjestää pienimmästä suurimpaan
            myListC.Reverse(); // Kääntää listan elementit toisin päin

            #endregion



            // 4. Datarakenteet
            // Data structures
            #region

            // Dataa tallennetaan ja käsitellään monessa eri muodossa.
            // Datarakenteet ovat oleellisia tilanteissa, kun käsitellään suurta määrää data ja suorituskyvyllä on merkitystä.

            // Array
            // List
            // Stack
            // Queue
            // HashSet
            // SortedSet
            // Dictionary
            // SortedDictionary
            // Hashtable
            // SortedList
            // LinkedList
            // CircularBuffer
            // Deque
            // Double - ended priority queue
            // Graph
            // Binary Tree
            // Binary Search Tree
            // Heap
            // Priority Queue
            // Trie

            #endregion





            Console.ReadKey();
        }
    }
}
