using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Rob
{
    internal class Deck
    {
        /*
         * int deckSize = 52;
            int suitNumber = 4;
        for (int i = 1; i <= deckSize / suitNumber; i++)
        {
         Console.WriteLine(i);
        }
         */
        public int deckSize;
        public int suitNumber;
        string[] Suits = { "Apples", "Oranges" };
        List<Card> Cards = new List<Card>(); // calls the card class in list form
        //string[] Suits2 = { "Unicorn", "Gryphon", "Spector", "Demon" };
        Random  r = new Random();
        public Deck()
        {
            this.deckSize = 26;
            this.suitNumber = Suits.Length; //+ Suits2.Length;
            
        }

        public void MakeDeck()
        {
            for (int i=1; i <= deckSize / Suits.Length; i++)
            {
                // Apples cards
                Cards.Add(new Card()
                {
                    Value = i,
                    Suit = Suits[0]
                });
                // Orange cards
                Cards.Add(new Card()
                {
                    Value = i,
                    Suit = Suits[1]
                });
                
                
                    /*for (int j = 0; j < Suits2.Length; j++)
                    {
                        Cards.Add(new Card()
                        {
                            Value = i,
                            Suit = Suits2[j]
                        }
                        );
                    }*/
                
            }
        }
        public void Shuffle()
        {
            Cards = GetShuffled();
        }

        public void Shuffle(int howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                Cards = GetShuffled();
            }
        }
        public Card DrawCard()
        {
            Card card;
            if (Cards.Count == 0)
            {
                throw new Exception("No cards left to draw.");
            }
            card = Cards[0];
            Cards.Remove(card);
            return card;
        }
        // get the random to "Shuffle" the deck.
        public List<Card> GetShuffled()
        {
            int selectedCardIndex;
            Card selectedCard;
            List<Card> original, shuffled;
            shuffled = new List<Card>();
            original = Cards;
            while (original.Count > 0)
            {
                selectedCardIndex = r.Next(1, 13);
                selectedCard = original[selectedCardIndex];
                original.Remove(selectedCard);
                shuffled.Add(selectedCard);
            }
            return shuffled;
        }

        public List<Card> DrawCards(int howMany)
        {
            List<Card> drawnCards = Cards.Take(howMany).ToList();
            foreach (Card drawCard in drawnCards)
            {
                Cards.Remove(drawCard);
            }
            return drawnCards;
        }
        public string AboutDeck()
        {
            string about = string.Empty;
            foreach (Card card in Cards)
            {
                about += card.AboutCard() + "\n";
            }
            return about.Trim();
        }
    }
}
