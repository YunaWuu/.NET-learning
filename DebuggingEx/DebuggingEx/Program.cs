using System;

namespace DebuggingEx
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // test the Sum1To5 function
            int sum1To5 = Sum1To5();
            Console.WriteLine($"sum 1-5 is: ${sum1To5}");
            // test the Max function
            int max = Max(8, 5, 3);
            Console.WriteLine($"max is: ${max}");
            // test the Sum1ToN function
            int sum = Sum1ToN(100);
            Console.WriteLine($"sum 1 to 100 is: ${sum}");
        }
        public static int Sum1To5()
        {
            int result = 0;
            result += 1;
            result += 2;
            result += 3;
            result += 4;
            result += 5;
            return result;
        }
        public static int Max(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                { // a <= c
                    max = c;
                }
            }
            else
            { // a <= b
                if (b > c)
                {
                    max = b;
                }
                else
                { // b <= c
                    max = c;
                }
            }
            return max;
        }
        public static int Sum1ToN(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;

        }
    }
}
