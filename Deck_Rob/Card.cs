using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Rob
{
    internal class Card
    {
        public int Value;
        public string Suit;

        public virtual string AboutCard()
        {
            if(Value == 1)
            {
                return $"Ace of {Suit}";
            }
            if(Value == 11)
            {
                return $"Jack of {Suit}";
            }
            if(Value == 12)
            {
                return $"Queen of {Suit}";
            }
            if (Value == 13)
            {
                return $"King of {Suit}";
            }
            else
            {
                return $"{Value} of {Suit}";
            }
            
        }
    }
}
