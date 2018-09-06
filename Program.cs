using System;
using System.Linq;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Decks newDeck = new Decks();
            newDeck.Deal();
            newDeck.Reset();
            System.Console.WriteLine(newDeck.Reset().Deal());
            // System.Console.WriteLine(newDeck.Reset());
            // System.Console.WriteLine(newDeck.Deal());
            newDeck.Shuffle();

            Players sky = new Players("yourie");
            sky.Draw(newDeck);
            sky.Draw(newDeck);
            sky.Draw(newDeck);
            sky.Discard(4);
            sky.Discard(0);
            var order = sky.hand.OrderByDescending(c => c.sVal);

            foreach (var card in order){
                Console.WriteLine(card);
            }

        }
    }
}
