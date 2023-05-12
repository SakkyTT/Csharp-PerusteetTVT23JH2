using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä14Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet funktiota pitää itse testata jollakin arvoilla.
            Console.WriteLine(Greet("Toni"));

            // Jos haluaa koodissa verrata arvoja (metodin toimivuus)
            if(Greet("Ryan") == "Hello, Ryan how are you doing today?")
            {
                Console.WriteLine("Metodi toimii!");
            }
            else
            {
                Console.WriteLine("Metodi ei toimi!");
            }


            Console.ReadKey();

        }
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }
    }
}
