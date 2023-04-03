using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä4Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14 C# Valinta: Parillinen vai pariton
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159612
            #region

            //// 1. Pyydetään käyttäjää antamaan luku
            //Console.Write("Anna luku: ");

            //// 2. Luetaan luku ja tallennetaan muuttujaan
            //int userNumber = int.Parse(Console.ReadLine());

            //// 3. Ehto rakenne, jossa verrataan muuttujan arvoa
            //// if-else
            //// %-operaatio, eli jakojäännös. Jos jakojäännös == 0, luku meni tasan kahdella.
            //if (userNumber % 2 == 0) // Onko jaollinen kahdella
            //{
            //    Console.WriteLine($"Numero {userNumber} on parillinen.");
            //}
            ////else if (userNumber % 2 == 1)
            //else // Pelkkä else riittää, koska jos luku ei ole parillinen sen täytyy olla pariton
            //{
            //    Console.WriteLine($"Numero {userNumber} on pariton.");
            //}

            // switch
            //// 1. Pyydetään käyttäjää antamaan luku
            //Console.Write("Anna luku: ");

            //// 2. Luetaan luku ja tallennetaan muuttujaan
            //int userNumber = int.Parse(Console.ReadLine());

            //switch (userNumber % 2) // Suoritetaan jakojäännöksen laskeminen
            //{
            //    case 0: // Verrataan jakojäännöksen tulosta. Jakojäännös on 0, eli parillinen
            //        Console.WriteLine($"Numero {userNumber} on parillinen.");
            //        break;
            //    // case 1: // Jakojäännökseen jäi 1, eli pariton
            //    default:  // Voi käyttää myös defaulttia, koska luku on pariton, jos se ei ollut parillinen.
            //        Console.WriteLine($"Numero {userNumber} on pariton.");
            //        break;
            //}

            // ternary
            // 1. Pyydetään käyttäjää antamaan luku
            Console.Write("Anna luku: ");

            // 2. Luetaan luku ja tallennetaan muuttujaan
            //int userNumber = int.Parse(Console.ReadLine());
            //                     ehto            ?         arvo jos true                 :      arvo jos false
            //string message = (userNumber % 2 == 0) ? $"Numero {userNumber} on parillinen." : $"Numero {userNumber} on pariton.";
            //                                                                              Tässä kohtaa voi ketjuttaa uuden ternary operaation
            //Console.WriteLine(message); // Näytetään tulos käyttäjälle
            #endregion

            // 16 C# Valinta: Kuukaudet (yhdessä 3.4.)
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159614
            #region

            // if-else version

            //Console.Write("Anna kuukausi: ");
            //string monthIF = Console.ReadLine();

            //// Muokataan teksti pieniksi kirjaimiksi
            //monthIF = monthIF.ToLower(); // ToLower() muokkaa kirjaimet pieniksi

            //// tarkistetaan saman vuodenajan kuukaudet samassa if ehdossa
            //if (monthIF == "tammikuu" || monthIF == "helmikuu" || monthIF == "marraskuu" || monthIF == "maaliskuu" || monthIF == "joulukuu")
            //{
            //    Console.WriteLine("Kuuluu talveen.");
            //}
            //else if (monthIF == "huhtikuu" || monthIF == "toukokuu")
            //{
            //    Console.WriteLine("Kuuluu kevääseen.");
            //}
            //else if (monthIF == "kesäkuu" || monthIF == "heinäkuu" || monthIF == "elokuu")
            //{
            //    Console.WriteLine("Kuuluu kesään.");
            //}
            //else if (monthIF == "syyskuu" || monthIF == "lokakuu")
            //{
            //    Console.WriteLine("Kuuluu syksyyn.");
            //}
            //else // Jos käyttäjä ei syöttänyt hyväksyttävää kuukautta
            //{
            //    // Virhe ilmoitus
            //    Console.WriteLine("Syöttämääsi kuukautta ei löytynyt.");
            //}

            // switch versio

            //Console.Write("Anna kuukausi numerona: ");
            //int monthSwitch = int.Parse(Console.ReadLine());

            //switch (monthSwitch)
            //{
            //    case 11:
            //    case 12:
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Talvi kuukausi.");
            //        break;
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Kevät kuukausi");
            //        break;
            //    // C# 7 versiossa voidaan ilmaista myös tietty numero alue.
            //    case int xyz when (xyz >= 6 && xyz <= 8):
            //        Console.WriteLine("Kesä kuukausi");
            //        break;
            //    case int xyz when (xyz >= 9 && xyz <= 10):
            //        Console.WriteLine("Syys kuukausi");
            //        break;
            //    default:
            //        Console.WriteLine("Virheellinen numero!");
            //        break;
            //}

            // ternary versio

            Console.Write("Syötä kuukausi numerona: ");
            int monthTernary = int.Parse(Console.ReadLine());

            string message = "";

            // ternary vertailu
            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" :
                monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
                monthTernary >= 6 && monthTernary <= 8 ? "Kesä" :
                monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
                "Virheellinen arvo";


            Console.WriteLine(message);

            #endregion


            #region


            #endregion


            #region


            #endregion


            Console.ReadKey();
        }
    }
}
