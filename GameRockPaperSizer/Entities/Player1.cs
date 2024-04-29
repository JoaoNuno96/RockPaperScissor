using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRockPaperSizer.Entities
{
    class Player1
    {
        public string Hand { get; set; }

        public Player1() { }

        public int RNG()
        {
            Random r = new Random();

            return r.Next(1, 3);
        }

        public void ProcessHand(int number)
        {

            if (number == 1)
            {
                Hand = "ROCK";
            }
            else if (number == 2)
            {
                Hand = "PAPER";
            }
            else if (number == 3)
            {
                Hand = "SCISSOR";
            }

        }
    }
}
