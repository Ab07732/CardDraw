using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CardDraw
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;

        private const int NUMBER_OF_CARDS = 8;
        private ArrayList Num;

        public Deck()
        {
            string[] card = {"King of Hearts", "2 of Hearts", "Queen of Diamonds", "9 of Diamonds", "Queen of Clubs", "4 of Clubs","Jack of Spades","Ace of Spades",};
            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            Num = new ArrayList();  
            for(int count = 0; count < deck.Length; count++)
                deck[count] = new Card(card[count % 4]);
        }

        public void Shuffle()
        {
            currentCard = 0;
            for(int first = 0; first < deck.Length; first++)
            {
                int second = Num.IndexOf( NUMBER_OF_CARDS);
                Card temp = deck[first];
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }
    }
}
