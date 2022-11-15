using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set the value for integer X: ");
            string input = Console.ReadLine();
            int x;

            try
            {
                x = Int32.Parse(input);
                Console.WriteLine($"X = {x}");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNull Exception: {ex.Message}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Format Exception: {ex.Message}");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"Overflow Exception: {ex.Message}");
            }
                
                




            /*int a = 10, b = 0;
            int result;

            try
            {
                Console.WriteLine($"Trying {a} / {b}");
                result = a / b;
                Console.WriteLine($"Result = {result}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }*/
        }
    }
}
