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

            // Generoidaan datarakenne valittavissa olevan täyteet
            // Yleisesti luetaan tietokannasta. (Jota voidaan päivittää)
            // Voi olla toinen sovellus, joka ylläpitää kaupan täytteitä

            List<Topping> allToppings = new List<Topping> { 
                new Topping("Jauheliha"), // 1
                new Topping("Pepperoni"), // 2
                new Topping("Herkkusieni"), // 3
                new Topping("Oliivi"), // 4
                new Topping("Tonnikala") // 5
            };
            // allToppings.Add("Oliivi"); <- toinen vaihtoehto

            // Datarakenne käyttäjän valitsemille täytteille
            // Tässä luodaan List-luokasta objekti, nimeltä userToppings
            List<string> userToppings = new List<string>(); // Korvataan pitsa luokalla

            // Luodaan pizza ennen silmukkaa, koska silmukassa tarvitaan pizza objektia
            Pizza userPizza = new Pizza();

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
                for (int i = 0; i < userPizza.Toppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {userPizza.Toppings[i].Name}");
                }

                //for (int i = 0; i < userToppings.Count; i++)
                //{
                //    Console.WriteLine($"{i+1}. {userToppings[i]}");
                //}

                Console.WriteLine();

                // Vaihtoehdot
                Console.WriteLine("Vaihtoehdot:");
                for (int i = 0; i < allToppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {allToppings[i].Name}");
                }
                //Console.WriteLine("1. Pepperoni"); ctrl-k + ctrl-c
                //Console.WriteLine("2. Herkkusieni");
                //Console.WriteLine("3. Oliivi");
                //Console.WriteLine("4. Jauheliha");
                //Console.WriteLine("5. Tonnikala");

                Console.WriteLine();

                // Käyttäjän valinta
                Console.WriteLine($"Syötä täyte (1-{allToppings.Count} tai e): ");
                string input = Console.ReadLine();

                if (input == "e")
                {
                    userIsDoneOrdering = true;
                }
                else // Käyttäjä syöttänyt sopivan indeksin
                {
                    // Sovellus katuu, jos käyttäjä ei syötä sopivaa numeroa.

                    int indexOfTopping = int.Parse(input) - 1;

                    Topping tempTopping = allToppings[indexOfTopping]; // <- viittaus täyte objektiin

                    // Referenssi tyyppi, ei luo uutta kopiota täyteestä
                    // Vaan käyttää samaa objektia allToppings listan kanssa.
                    userPizza.Toppings.Add(tempTopping);
                    
                }

                //switch (input)
                //{
                //    case "1":
                //        userToppings.Add("Pepperoni");
                //        break;
                //    case "2":
                //        userToppings.Add("Herkkusieni");
                //        break;
                //    case "3":
                //        userToppings.Add("Oliivi");
                //        break;
                //    case "4":
                //        userToppings.Add("Jauheliha");
                //        break;
                //    case "5":
                //        userToppings.Add("Tonnikala");
                //        break;
                //    case "e":
                //        userIsDoneOrdering = true;
                //        break;
                //    default:
                //        // Jokin virheilmoitus
                //        break;
                //}

            } // while päättyy

            // Lasketaan pitsan hinta
            //int price = 15;

            //if (userToppings.Count > 3)
            //{
            //    price += userToppings.Count - 3;
            //}

            int price = userPizza.CalculatePrice();

            // Näytetään käyttäjän tilaus ja hinta
            Console.Clear();
            Console.WriteLine("Tilaus:");

            // Silmukka käy läpi kaikki elementit listassa
            // Tämä koodi voisi olla metodissa
            //for (int i = 0; i < userToppings.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {userToppings[i]}");
            //}
            for (int i = 0; i < userPizza.Toppings.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {userPizza.Toppings[i].Name}");
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
                string address = Console.ReadLine();
                Console.WriteLine("Tilaus lähetetty!");
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
