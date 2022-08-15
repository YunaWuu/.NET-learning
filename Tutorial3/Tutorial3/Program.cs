using System;

namespace Tutorial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student number");
            int number = Int32.Parse(Console.ReadLine());

            printGrade(number);
           
        }   
        
        static void printGrade(int number)
        {
            string grade = "Invalid input, try again";
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter student mark");
                int mark = Int32.Parse(Console.ReadLine());
                switch (mark)
                {
                    case < 60:
                        grade = "E";
                        break;
                    case >= 60 and < 70:
                        grade = "D";

                        break;
                    case >= 70 and < 80:
                        grade = "C";

                        break;
                    case >= 80 and < 90:
                        grade = "B";

                        break;
                    case >= 90 and < 100:
                        grade = "A";
                        break;
                    default:
                        grade = "Invalid input, try again";
                        break;

                }
                Console.WriteLine(grade);
            }
        }



           /* int scorePlayer = 0;
            int scoreComputer = 0;

            bool exit = false;

            while (!exit)
            {
                Console.Write("Enter a command: ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "play":
                        Random rnd = new Random();
                        int rndNumber = rnd.Next(1, 3);
                        Console.WriteLine("Guess a number");
                        int guessNumber = Int32.Parse(Console.ReadLine());
                        if (guessNumber == rndNumber)
                        {
                            Console.WriteLine("You win!");
                            scorePlayer++;
                        }
                        else
                        {
                            Console.WriteLine("You lose...");
                            scoreComputer++;
                        }
                        break;

                    case "show":
                        Console.WriteLine($"Your score is {scorePlayer}: {scoreComputer} VS computer");
                        break;

                    case "reset":
                        scorePlayer = 0;
                        scoreComputer = 0;
                        break;

                    case "help":
                        Console.WriteLine("play – start a new game.");
                        Console.WriteLine("show - scores will be displayed for both player and computer.");
                        Console.WriteLine("exit - program finished.");
                        Console.WriteLine("help - display all supported commands.");
                        Console.WriteLine("reset - reset all numbers.");
                        break;

                    case "exit":
                        Console.WriteLine("Bye Bye");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command! Try again");
                        break;
                }
            }*/



            /* Random rnd = new Random();
             int rndNumber = rnd.Next(1, 10);

             int total = 5;

             for (int round = 0; round < total; round++)
             {
                 Console.WriteLine("Guess what the number is?");
                 int guessNumber = Int32.Parse(Console.ReadLine());

                 if (guessNumber == rndNumber)
                 {
                     Console.WriteLine("You win! Game ends");

                     break;
                 }
                 else if (guessNumber < rndNumber)
                     {
                         Console.WriteLine("Guess again, your numer is too small");
                     }
                 else
                     {
                         Console.WriteLine("Guess again, your number is too big");
                     }


             }*/






            /* int scoreA = 0;
             int scoreB = 0;
             int total = 5;
             int round = 1;
             while (round <= total)
             {
                 Console.WriteLine("Game round - " + round);

                 Console.WriteLine("1-Rock, 2-Paper, 3-scissors");
                 Console.Write("player A: ");
                 string playerA = Console.ReadLine();
                 Console.Write("player B: ");
                 string playerB = Console.ReadLine();

                 if (playerA == "1" && playerB == "1")
                 {
                     Console.WriteLine("Tie game");
                 }
                 else if (playerA == "1" && playerB == "2")
                 {
                     Console.WriteLine("B wins");
                 }
                 else if (playerA == "1" && playerB == "3")
                 {
                     Console.WriteLine("A wins");
                 }
                 else if (playerA == "2" && playerB == "1")
                 {
                     Console.WriteLine("A wins");
                 }
                 else if (playerA == "2" && playerB == "2")
                 {
                     Console.WriteLine("Tie game");
                 }
                 else if (playerA == "2" && playerB == "3")
                 {
                     Console.WriteLine("B wins");
                 }
                 else if (playerA == "3" && playerB == "1")
                 {
                     Console.WriteLine("B wins");
                 }
                 else if (playerA == "3" && playerB == "2")
                 {
                     Console.WriteLine("A wins");
                 }
                 else if (playerA == "3" && playerB == "3")
                 {
                     Console.WriteLine("Tie game");
                 }
                 else
                 {
                     Console.WriteLine("invalid input, we should be not here.");
                 }

                 round++;
             }

             Console.WriteLine("Final score");
             Console.WriteLine("A - " + scoreA);
             Console.WriteLine("B - " + scoreB); */



            /* int total = 5;
             int round = 1;
             int scoreA = 0;
             int scoreB = 0;
            while (round <= total)
            {

                Console.WriteLine("1 - rock, 2 - paper, 3 - scissors");
                Console.WriteLine("playerA:");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("playerB:");
                int B = Convert.ToInt32(Console.ReadLine());
                string result;
                if (A == B)
                {
                    Console.WriteLine("Tie");
                }
                else if (A == 1)
                {
                    if (B == 2)
                    {
                        Console.WriteLine("B wins");
                        scoreB++;
                    }
                    else if (B == 3)
                    {
                        Console.WriteLine("A wins");
                        scoreA++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (A == 2)
                {
                    if (B == 1)
                    {
                        Console.WriteLine("A wins");
                        scoreA++;
                    }
                    else if (B == 3)
                    {
                        Console.WriteLine("B wins");
                        scoreB++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }

                }
                else if (A == 3)
                {
                    if (B == 1)
                    {
                        Console.WriteLine("B wins");
                        scoreB++;
                    }
                    else if (B == 2)
                    {
                        Console.WriteLine("A wins");
                        scoreA++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                round++;
            }

             Console.WriteLine("Final score");
             Console.WriteLine("A - " + scoreA);
             Console.WriteLine("B - " + scoreB); */






            /*Console.WriteLine("Input number of row");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input number of seat");
            int n = Int32.Parse(Console.ReadLine());

            int i = 1;
            while (i <= m)
            {
                int j = 1;
                while (j <= n)
                {
                    Console.Write(i + "." + j + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }*/





            /* int m = 4;
             int n = 6;

             int i = 0;
             while (i < n)
             {
                 int j = 0;
                 while (j < m)
                 {
                     Console.Write("*");
                         j++;
                 }
                 Console.WriteLine();
                 i++;
             }*/



            /* Console.WriteLine("How many numbers would you like to be showed?");
             int showNumber = Int32.Parse(Console.ReadLine());

             int numberOfItems = 0;
             while (numberOfItems < showNumber)
             {
                 Random rnd = new Random();
                 int rndNumber = rnd.Next(1, 10);
                 Console.WriteLine(rndNumber);
                 numberOfItems++;
             }*/

        }
    }

