using System;

namespace Tutorial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Class activity 1
            Two people are playing the rock paper scissors game, build a program for the game. 
            You may use numbers to represent the “rock”, “paper”, “scissors” states.
            E.g. 1 - rock, 2 - paper, 3 - scissors */

            Console.WriteLine("1 - rock, 2 - paper, 3 - scissors");
            Console.WriteLine("playerA:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("playerB:");
            int B = Convert.ToInt32(Console.ReadLine());
            string result;
            if (A == B)
            {
                result = "Tie";
            }
            else if (A == 1)
            {
                if (B == 2)
                {
                    result = "B wins";
                }
                else
                {
                    result = "A wins";
                }
            }
            else if (A == 2)
            {
                if (B == 1)
                {
                    result = "A wins";
                }
                else
                {
                    result = "B wins";
                }

            }
            else
            {
                if (B == 1)
                {
                    result = "B wins";
                }
                else
                {
                    result = "A wins";
                }
            }
            Console.WriteLine(result);
        }

    }

}
