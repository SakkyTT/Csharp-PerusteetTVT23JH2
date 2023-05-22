using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä17Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kokeen alussa, toiminnallisuuta suoraan Main-funktioon.

            // Datarakenne käyttäjän valitsemille täytteille
            // Tässä luodaan List-luokasta objekti, nimeltä userToppings
            List<string> userToppings = new List<string>();

            bool userIsDoneOrdering = false;

            // Käyttöliittymän tulostus
            // Jatketaan, kunnes käyttäjä on valmis tilauksen kanssa
            while (userIsDoneOrdering == false)
            {
                Console.Clear(); // Tyhjentää konsolin
                 
                // Otsikko

                Console.WriteLine("Pitsan tilaus:");
                Console.WriteLine();

                // Valitut täytteet
                Console.WriteLine("Valitut täytteet:");

                // Silmukka käy läpi kaikki elementit listassa
                for (int i = 0; i < userToppings.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {userToppings[i]}");
                }

                Console.WriteLine();

                // Vaihtoehdot
                Console.WriteLine("Vaihtoehdot:");
                Console.WriteLine("1. Pepperoni");
                Console.WriteLine("2. Herkkusieni");
                Console.WriteLine("3. Oliivi");
                Console.WriteLine("4. Jauheliha");
                Console.WriteLine("5. Tonnikala");
                Console.WriteLine();

                // Käyttäjän valinta
                Console.WriteLine("Syötä täyte (1-5 tai e): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        userToppings.Add("Pepperoni");
                        break;
                    case "2":
                        userToppings.Add("Herkkusieni");
                        break;
                    case "3":
                        userToppings.Add("Oliivi");
                        break;
                    case "4":
                        userToppings.Add("Jauheliha");
                        break;
                    case "5":
                        userToppings.Add("Tonnikala");
                        break;
                    case "e":
                        userIsDoneOrdering = true;
                        break;
                    default:
                        // Jokin virheilmoitus
                        break;
                }

            } // while päättyy

            // Lasketaan pitsan hinta
            int price = 15;

            if (userToppings.Count > 3)
            {
                price += userToppings.Count - 3;
            }

            // Näytetään käyttäjän tilaus ja hinta
            Console.Clear();
            Console.WriteLine("Tilaus:");

            // Silmukka käy läpi kaikki elementit listassa
            // Tämä koodi voisi olla metodissa
            for (int i = 0; i < userToppings.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {userToppings[i]}");
            }
            Console.WriteLine();

            // Näytetään hinta
            Console.WriteLine($"Summa: {price} euroa");

            // Käyttäjä hyväksyy
            Console.Write("Hyväksy tilaus (k): ");
            string userOrders = Console.ReadLine();
            Console.WriteLine();

            if (userOrders == "k") // Käyttäjä tilaa
            {
                Console.Write("Syötä osoite: ");
                // Tallennetaan tilaus palvelin (tietokanta)
                // Palvelin lähettää tilauksen pitserian työntekijälle
            }
            else // Käyttäjä peruu tilauksen
            {
                Console.WriteLine("Tilaus peruttu.");
            }


            Console.ReadKey();
        } // Main päättyy

        // Lisätään funktioita
    }

    // Lisätään luokkia
}
