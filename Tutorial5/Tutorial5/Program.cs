using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial5
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            bool exit = false;

            List<string> todo = new List<string>();
            List<string> done = new List<string>();

            while (!exit)
            {
                Console.WriteLine("Enter a command");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Add a to-do item: ");
                        string todoItem = Console.ReadLine();
                        todo.Add(todoItem);
                        Console.WriteLine("A new item has been added to the to do list");
                        break;

                    case "done":
                       Console.WriteLine("Enter item index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        string doneItem = todo[index];
                        todo.RemoveAt(index);
                        done.Add(doneItem);
                        Console.WriteLine("The item has been moved to the done list.");
                        break;

                    case "show":
                        foreach (string item in todo)
                        {
                            Console.WriteLine(item);
                        }
                        foreach (string item in done)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "exit":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("invalid input! try again:");
                        break;
                }

            }

            Console.WriteLine("Byebye");
        }*/





        /* static void Main(string[] args)
         {
             Console.WriteLine("Enter number of clients");
             int clientNum = Convert.ToInt32(Console.ReadLine());

             string[] name = new string[clientNum];
             string[] phone = new string[clientNum];
             string[] email = new string[clientNum];

             for (int i = 0; i < clientNum; i++)
             {
                 Console.WriteLine("Enter name:");
                 string clientName = Console.ReadLine();
                 name[i] = clientName;

                 Console.WriteLine("Enter phone:");
                 string clientPhone = Console.ReadLine();
                 phone[i] = clientPhone;

                 Console.WriteLine("Enter email:");
                 string clientEmail = Console.ReadLine();
                 email[i] = clientEmail;

             }

             foreach (string s in name)
             {
                 Console.WriteLine("Client name is " + s);
             }
             foreach (string s in phone)
             {
                 Console.WriteLine("Client phone number is " + s);
             }
             foreach (string s in email)
             {
                 Console.WriteLine("Client email is " + s);
             }

         }*/


        static void Main(string[] args)
        {

            double[] numbers = { 10, 13.2, 14.3, 11, 9.89, 12.98, 15.76, 11.6, 14.21, 10.89, 8, 7.1 };

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
                Console.WriteLine(sum);
            }

            /*
                         Console.WriteLine("The sum of all numbers is " + numbers.Sum());
                         Console.WriteLine("The average of all numbers is " + numbers.Average());
            */



            /*double[] movingAverage = new double[numbers.Length - 2];
            for (int i = 0; i < movingAverage.Length; i++)
            {
                movingAverage[i] = (numbers[i] + numbers[i+1] + numbers[i+2])/3;
            }

            foreach (double j in movingAverage)
            {
                Console.WriteLine(j);
            }





             Console.WriteLine("Enter a number for comparison");
             double compNum = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine($"Displaying all the numbers greater than {compNum}:");
             foreach (double i in numbers)
             {

             if (i > compNum )
             {
                 Console.WriteLine(i);
             }

             }
        }
*/



            /*static void Main(string[] args)
             {
                 int[] F = new int[20];
                 F[0] = 0;
                 F[1] = 1;

                 for (int i = 2; i < 20; i++)
                 {
                     F[i] = F[i - 1] + F[i - 2];
                 }

                 Console.WriteLine("The first 20 Fibonacci numbers:");

                 foreach (int f in F)
                 {
                     Console.Write(f + ", ");
                 }
             }*/

        }
    }
}

