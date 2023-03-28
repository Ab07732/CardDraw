using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDraw
{
    public class Card
    {
        private string card;

        public Card(string cards)
        {
            card = cards;
        }
        public override string ToString()
        {
            return card;
        }
    }
}
