using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRockPaperSizer.Entities
{
    class Player2
    {
        public string Hand { get; set; }

        public Player2() { }

        public void AddHand(string H)
        {
            Hand = H;
        }

    }
}
