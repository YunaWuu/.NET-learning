using System;

namespace Tutorial2_activity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Student’s assessment is graded based on the mark received. 
             Build a program to convert a mark input to grade
             •	F – 0~60
             •	E – 60~70
             •	D – 70~80
             •	C – 80~90
             •	B – 90~95
             •	A – 95~100
            Note, your program should be able to handle invalid mark value inputs, 
            such as mark< 0 or mark > 100. */

            Console.WriteLine("mark");
            int mark = Convert.ToInt32(Console.ReadLine());
            string result;
            if (mark < 0 || mark >100)
            {
                result = "invalid"; 
            }
            else if (mark >= 0 && mark < 60)
            {
                result = "F";
            }
            else if (mark >= 60 && mark < 70)
            {
                result = "E";
            }
            else if (mark >= 70 && mark < 80)
            {
                result = "D";
            }
            else if (mark >= 80 && mark < 90)
            {
                result = "C";
            }
            else if (mark >= 90 && mark < 95)
            {
                result = "B";
            }
            else
            {
                result = "A";
            }

            Console.WriteLine($"Your grade is {result}");
        }
    }
}
