using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Rob
{
    internal class Game
    {
        // CREATE PLAYER
       public  Person Player;
        // create deck for the game
        public Deck deck;

        public bool isPlaying;

        public Game()
        {
            Player = new Person(this);
            deck = new Deck();
           setupGame();
        }

        protected virtual void setupGame()
        {
            deck.Shuffle();
            Player.DrawCards(5);
        }
        // start of game
        public virtual void Play()
        {
            isPlaying = true;
            do
            {
                this.PlayHand();
            } while (isPlaying);
        }
        // stops the game
        public virtual void Stop()
        {
            isPlaying=false;
        }
        // playing the game
        public virtual void PlayHand()
        {
            deck.MakeDeck();
            Console.WriteLine(deck.AboutDeck());
            Console.WriteLine(Player.About());
            Console.ReadKey();
            //Console.Clear();
        }
    }
}
