using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Deck_Rob
{
    internal class Person
    {
        // Create a hand for the player
        public List<Card> Hand = new List<Card>();
        Game Game;

        public Person(Game game)
        {
            this.Game = game;
        }

        public void DrawCard()
        {
            Hand.Add(this.Game.deck.DrawCard());
        }

        public void DrawCards(int howMany)
        {
            List<Card> drawnCards = this.Game.deck.DrawCards(howMany);
            foreach (Card card in drawnCards) { Hand.Add(card); }
        }

        public string About()
        {
            string playerAbout = $"Player \n";
            playerAbout += "---------------------------------\n";
            playerAbout += "Hand\n";
            foreach (Card card in Hand)
            {
                playerAbout += card.AboutCard() + "\n";
            }
            playerAbout += "---------------------------------\n";
            Console.WriteLine(this.Game.deck.AboutDeck());
            return playerAbout;
        }
    }
}
