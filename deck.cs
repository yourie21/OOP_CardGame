using System; using System.Collections.Generic;

namespace cards
{
    class Decks
    {
        List<Cards> cards { get; set; } = new List<Cards>();
        string[] suits = { "Diamonds", "Hearts", "Clubs", "Spades" };
        string[] sVal = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        public Decks() {
            foreach (string s in suits){
                int num = 1;
                foreach (string sv in sVal){
                    Cards temp = new Cards (sv, s, num);
                    cards.Add(temp);
                    num++;
                }
            } 
            System.Console.WriteLine(cards);
        }
        // public List<Cards> Deal (){
        public Cards Deal (){
            Cards oneCard = cards[cards.Count-1];
            cards.Remove(oneCard);
            return oneCard;
            // return cards;
        }
        public Decks Reset() {
            cards = new List<Cards>();
            foreach (string s in suits){
                int num = 1;
                foreach (string sv in sVal){
                    Cards temp = new Cards (sv, s, num);
                    cards.Add(temp);
                    num++;
                }
            }
            return this;
        }
        public Decks Shuffle() {
            Random rand = new Random();
            // Cards oneCard = new Cards();
            for(int i = 0; i < cards.Count; i++) {
                int idx = rand.Next(cards.Count);
                Cards oneCard = cards[i];
                cards[i] = cards[idx];
                cards[idx] = oneCard;
            }
            return this;
        }
    }
}
// Give the Deck a reset method that resets the cards property to contain the original 52 cards.

// Give the Deck a shuffle method that randomly reorders the deck's cards.
