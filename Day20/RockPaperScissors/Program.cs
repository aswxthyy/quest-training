using System;

namespace RockPaperScissors
{
    internal class Program
    {
        private static Random rnd = new Random();

        private static string ComputerMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            int move = rnd.Next(3);
            return moves[move];
        }

        static void Main(string[] args)
        {
            var pscore = 0;
            var cscore = 0;
            System.Console.WriteLine("Let's Play Rock, Paper, Scissors!");
            
            while (pscore < 10 && cscore < 10)
            {
                System.Console.Write("Enter your move :");
                string pmove = Console.ReadLine().ToLower();
                string cmove = ComputerMove();

                System.Console.WriteLine($"Computer's Move : {cmove}");

                if (pmove == cmove)
                {
                    System.Console.WriteLine("Tie");
                }
                else if ((pmove == "rock" && cmove == "scissors") ||
                         (pmove == "scissors" && cmove == "paper") ||
                         (pmove == "paper" && cmove == "rock"))
                {
                    System.Console.WriteLine("Player Scores!");
                    pscore += 1;
                }
                else
                {
                    System.Console.WriteLine("Computer Scores!");
                    cscore += 1;
                }

                System.Console.WriteLine($"PLAYER : {pscore}     COMPUTER : {cscore}");
            }

            if (pscore == 10)
            {
                System.Console.WriteLine("PLAYER WINS!");
            }
            else
            {
                System.Console.WriteLine("COMPUTER WINS!");
            }
        }

    }
}