using System;

namespace cards
{
    class Cards
    {
        public string sVal, suits;
        public int val { get; set; }

        public Cards(string sv, string s, int v){
            sVal = sv;
            suits = s;
            val = v;
        }
    }
}

// Give the Card class a property "letter" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.

// Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).

// Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.