using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using GameRockPaperSizer.Entities;

namespace GameRockPaperSizer
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "ROCK/PAPER/SCISSOR GAME";
            string beginingMessage = "Please select your hand(Rock/Paper/Scissor)";

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (name.Length / 2)) + "}", name));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (beginingMessage.Length / 2)) + "}", beginingMessage));
            bool Execute = true;
            Player1 First = new Player1();
            Player2 Second = new Player2();
            List<string> ListMatch = new List<string>();
            Match Match = new Match();

            while (Execute)
            {
                if(ListMatch.Count() < 6)
                {
                    string MessageSelect = "Select";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (MessageSelect.Length / 2)) + "}", messageSelect));

                    Console.CursorLeft = (Console.WindowWidth / 2) - 3;
                    string Choice = Console.ReadLine();
                    Choice = Choice.ToUpper();

                    Second.AddHand(Choice);
                    Match.AddDepencies(First, Second, ListMatch);

                    First.ProcessHand(First.RNG());
                    Match.Play(Choice);
                }
                else
                {
                    Match.CountList();
                    Console.WriteLine();
                    Execute = false;
                    
                }     

            }
            
        }
    }
}