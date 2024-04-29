using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using GameRockPaperSizer.Entities;

namespace GameRockPaperSizer.Entities
{
    class Match
    {
        public Player1 First { get; set; }
        public Player2 Second { get; set; }
        public List<string> MatchCount { get; set; } = new List<string>();
        public Match() { }

        public Match(Player1 f, Player2 s, List<string> match)
        {
            First = f;
            Second = s;
            MatchCount = match;
        }

        public void AddDepencies(Player1 f, Player2 s, List<string> match)
        {
            First = f;
            Second = s;
            MatchCount = match;
        }

        public void Play(string otherPlayersHand)
        {

            if (First.Hand == "ROCK")
            {
                if (otherPlayersHand == "PAPER")
                {
                    MatchCount.Add("2");
                    Console.WriteLine("I used Rock and you used Paper.....You WIN!");

                }
                else if (otherPlayersHand == "SCISSOR")
                {
                    MatchCount.Add("1");
                    Console.WriteLine("You used Scissor and I used Rock....I WIN!");

                }
                else //if(OtherPlayersHand == "ROCK")
                {
                    Console.WriteLine("We both used Rock...It's a draw");
                }
            }
            else if (First.Hand == "PAPER")
            {
                if (otherPlayersHand == "PAPER")
                {
                    Console.WriteLine("We both used Paper.....It's a draw");
                }
                else if (otherPlayersHand == "SCISSOR")
                {
                    MatchCount.Add("2");
                    Console.WriteLine("I used Paper and you Scissor.....You Win!");
                }
                else// if (OtherPlayersHand == "ROCK")
                {
                    MatchCount.Add("1");
                    Console.WriteLine("You used Rock and I used Paper.....I Win!");
                }
            }
            else //if(Simbol == "SCISSOR")
            {
                if (otherPlayersHand == "PAPER")
                {
                    MatchCount.Add("1");
                    Console.WriteLine("You used Paper and I used Scissor...I Win!");
                }
                else if (otherPlayersHand == "SCISSOR")
                {
                    Console.WriteLine("We both used Scissor......It's a draw");
                }
                else // if (OtherPlayersHand == "ROCK")
                {
                    MatchCount.Add("2");
                    Console.WriteLine("I used Scissor and you used Rock.....You Win!");
                }
            }
        }

        public void CountList()
        {
            var f = MatchCount.Where(x => x == "1").Count();
            var s = MatchCount.Where(x => x == "2").Count();

            if (f > s)
            {
                Console.WriteLine("I win, this is a good start for my plan to exterminate the human race! :)");
            }
            else
            {
                Console.WriteLine("You win...but only this time, you miserable Human...");
            }
        }


    }
}
