using System;

namespace ShapeCalculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a Shape reference
            Shape shape = null;

            bool exit = false;

            while (!exit)
            {
                // Menu to select a shape
                Console.WriteLine("Select a shape or end");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Trapezoid");
                Console.WriteLine("'exit' to end");
                string type = Console.ReadLine();
                try
                {
                    switch (type)
                    {
                        case "1":
                            // If rectangle, get length and height
                                Console.WriteLine("Set rectangle length");
                                double l = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Set rectangle height");
                                double h = Double.Parse(Console.ReadLine());
                                shape = new Rectangle(l, h);
                            break;

                        case "2":
                            // If circle, get radius
                            Console.WriteLine("Set circle radius");
                            double r = Double.Parse(Console.ReadLine());
                            shape = new Circle(r);
                            break;

                        case "3":
                            // If square, get length
                            Console.WriteLine("Set square length");
                            double s = Double.Parse(Console.ReadLine());
                            shape = new Square(s);
                            break;

                        case "4":
                            //If trapezoid, get two base length, two side length, and height
                            Console.WriteLine("Set trapezoid base1 length");
                            double a = Double.Parse(Console.ReadLine());
                            Console.WriteLine("set trapezoid base2 length");
                            double b = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Set trapezoid side1 length");
                            double c = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Set trapezoid side2 length");
                            double d = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Set trapezoid height");
                            double e = Double.Parse(Console.ReadLine());
                            shape = new Trapezoid(a, b, c, d, e);
                            break;

                        case "exit":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Wrong selection. Bye");
                            return;
                    }
                }
                catch (Exception) {
                    Console.WriteLine("Invalid input. Bye!");
                    Environment.Exit(1);
                }

                if (shape != null)
                {
                    // Menu to select what to calculate
                    Console.WriteLine("Solve for");
                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Perimeter");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "1":
                            // calculate area
                            Console.WriteLine("Area is: " + shape.GetArea());
                            break;
                        case "2":
                            // calculate perimeter
                            Console.WriteLine("Perimeter is: " + shape.GetPerimeter());
                            break;
                        default:
                            Console.WriteLine("Wrong selection. Bye");
                            return;
                    }
                }
            }
        }
    }
}
