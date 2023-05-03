using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisätään koodi, joka generoi pakkaan kortit
            // Lisätään pakalle metodi, jolla nostetaan yksi kortti pakasta.
            // Pakan sekoitus metodi

            // Tässä on pelin kaikki kortit
            Deck deck = new Deck();
            // Tässä on pelaajan käsi
            Deck playerDeck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();

            playerDeck.Cards.Add(deck.Draw());
            playerDeck.Cards.Add(deck.Draw());

            Console.ReadKey();
        }
    }
}
