using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Rob
{
    internal class ApplicationUI
    {
        Game CurrentGame;

        public ApplicationUI() 
        {
        this.CurrentGame = new Game();
        }

        public void Start()
        {
            CurrentGame.Play();
        }
    }
}
