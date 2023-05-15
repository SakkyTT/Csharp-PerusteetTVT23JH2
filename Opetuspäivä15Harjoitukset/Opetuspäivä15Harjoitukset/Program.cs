using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä15Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ShoppingList> order = new List<ShoppingList>();

            Console.Write("Mihin kauppaan tehdään ostoslista: ");
            string shop = Console.ReadLine();

            ShoppingList newOrder = new ShoppingList(shop);

            // Waterfall - Agile Waterfall (scrum) - Agile(pari ohjelmointi)

            do // Käyttäjä lisää ostoksia
            {
                Console.Clear();
                Console.WriteLine($"Valittu kauppa on {newOrder.ShopName}");
                Console.WriteLine();

                Console.Write("Syötä tuote ja lukumäärä(maito, 3): ");
                string input = Console.ReadLine();
                string[] splitInput = input.Split(',');
                int amount = int.Parse(splitInput[1].Trim());

                // Lisätään tuote listaan käyttäjän syöttämän luvun verran
                for (int i = 1; i <= amount; i++)
                {
                    newOrder.AddProduct(splitInput[0]);
                }

            } while (true); // TODO this condition





















            Dice noppa1 = new Dice(6);
            Dice noppa2 = new Dice(6, 1);

            noppa1.Roll();
            //Console.ReadKey();
            noppa2.Roll();

            Console.WriteLine($"Nopan 1 silmäluku on: {noppa1.Value}");
            Console.WriteLine($"Nopan 2 silmäluku on: {noppa2.Value}");


            // Tallennetaan erikseen data objektiin
            // null reference on yleinen sovelluksen kaatumissyy

            Console.ReadKey();
        }
    }

    // Luokan voi laittaa tänne
}
