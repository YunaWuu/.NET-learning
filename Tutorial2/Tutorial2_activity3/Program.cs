using System;

namespace Tutorial2_activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Code the given flowchart with nested if … else structure */

            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c");
            int c = Convert.ToInt32(Console.ReadLine());
            int max;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }
            else
            {
                if (b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }

            Console.WriteLine($"max is {max}");
        }
    }
}
