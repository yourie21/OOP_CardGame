using System; using System.Collections.Generic;

namespace cards
{
    class Players
    {
        public string name { get; set; }
        public List<Cards> hand { get; set; } = new List<Cards>();
        public Players(string n){
            name = n;
        }
        public Cards Draw(Decks deck){
            Cards oneCard = deck.Deal();
            hand.Add(oneCard);
            return oneCard;
        }
        public Cards Discard(int i) {
            if (i < hand.Count){
                Cards oneCard = hand[i];
                hand.Remove(oneCard);
                return oneCard;
            } else { //if indext doesn't exist
                return null;

            }
        }
      
    }
}
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.