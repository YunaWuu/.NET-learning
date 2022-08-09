using System;

namespace Tutorial4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int x = ReadInt();
            Console.WriteLine($"x = {x}");
        }

        static int ReadInt()
        {
            while (true)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    return input;
                }
                catch
                {
                    Console.WriteLine("Invalid format, enter an integer");
                }
            }
        }







        // Method
        //     RockPaperScissors
        // Parameters
        //     player1: int. 1-Rock, 2-Paper, 3-Scissors, anything else is invalid input
        //     player1: int. 1-Rock, 2-Paper, 3-Scissors, anything else is invalid input
        // Return value
        //     int: 0 - a tie game
        //          1 - if player 1 wins
        //          2 - if player 2 wins
        //         -1 - invalid input


/*        static int RockPaperScissors(int player1, int player2)
        {
            if (player1 < 1 || player1 > 3 || player2 < 1 || player2 > 3)
            {
                // invalid input
                return -1;
            }

            int result;
            if (player1 == 1 && player2 == 1)
            {
                result = 0;
            }
            else if (player1 == 1 && player2 == 2)
            {
                result = 2;
            }
            else if (player1 == 1 && player2 == 3)
            {
                result = 1;
            }
            else if (player1 == 2 && player2 == 1)
            {
                result = 1;
            }
            else if (player1 == 2 && player2 == 2)
            {
                result = 0;
            }
            else if (player1 == 2 && player2 == 3)
            {
                result = 2;
            }
            else if (player1 == 3 && player2 == 1)
            {
                result = 2;
            }
            else if (player1 == 3 && player2 == 2)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            return result;
        }

            static void Main(string[] args)
            {
                bool exit = false;
                int score1 = 0;
                int score2 = 0;
                while (!exit)
                {
                    Console.WriteLine("Enter a command");

                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "play":
                        Console.WriteLine("How many rounds would you like to play");
                        int round = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < round; i++)
                        {
                            Console.WriteLine("1-Rock, 2-Paper, 3-Scissors, anything else is invalid input");
                            Console.WriteLine("Player1: ");
                            int player1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Player2: ");
                            int player2 = Int32.Parse(Console.ReadLine());
                            int result = RockPaperScissors(player1, player2);

                            if (result == 1)
                            {
                                Console.WriteLine("Player1 wins!");
                                score1++;
                            }
                            else if (result == 2)
                            {
                                Console.WriteLine("Player2 wins!");
                                score2++;
                            }
                            else if (result == 0)
                            {
                                Console.WriteLine("Tie game");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                        break;
                            
                        case "show":
                            Console.WriteLine("The currant score is Player1 " + score1 + ": player2 " + score2);
                            break;
                        case "reset":
                            score1 = 0;
                            score2 = 0;
                            Console.WriteLine("The currant score is 0 : 0");
                            break;
                        case "help":
                            Console.WriteLine("Enter play to start a new game.");
                            Console.WriteLine("Enter show to display the currant score for both players.");
                            Console.WriteLine("Enter reset to reset the scores to 0.");
                            Console.WriteLine("Enter help to display the supported commands.");
                            Console.WriteLine("Enter exit to quit the game.");
                            break;
                        case "exit":
                            Console.WriteLine("Bye bye");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again");
                            break;

                    }
                }
            }*/





            /* static double Addition(double num1, double num2)
             {
                 return num1 + num2;
             }

             static double Subtraction(double num1, double num2)
             {
                 return num1 - num2;
             }

             static double Multiplication(double num1, double num2)
             {
                 return num1 * num2;
             }

             static double Division(double num1, double num2)
             {
                 return num1 / num2;
             }

             static void Main(string[] args)
             {
                 bool exit = false;
                 while (!exit)
                 {
                     Console.WriteLine("Enter the first number");
                     int num1 = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("Enter the second number");
                     int num2 = Int32.Parse(Console.ReadLine());

                     Console.WriteLine("Enter a command");
                     string command = Console.ReadLine();

                 switch (command)
                     {
                         case "exit":
                             Console.WriteLine("Bye bye");
                             exit = true;
                             break;
                         case "+":
                             Console.WriteLine("Addition is " + Addition(num1, num2));
                             break;
                         case "-":
                             Console.WriteLine("Subtraction is " + Subtraction(num1, num2));
                             break;
                         case "*":
                             Console.WriteLine("Multiplication is " + Multiplication(num1, num2));
                             break;
                         case "/":
                             Console.WriteLine("Division is " + Division(num1, num2));
                             break;
                         default:
                             Console.WriteLine("Invalid input, try again");
                             break;


                     }




             }
             }*/
        }
    }
