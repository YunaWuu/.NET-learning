using System;

namespace ShapeCalculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test

            /*Rectangle r1 = new Rectangle(4, 5);
            Console.WriteLine("r1 area: " + r1.GetArea());
            Console.WriteLine("r1 perimeter: " + r1.GetPerimeter());

            Circle c1 = new Circle(5);
            Console.WriteLine("c1 area: " + c1.GetArea());
            Console.WriteLine("c1 perimeter: " + c1.GetPerimeter());

            Console.Read();*/


            Shape shape;

            bool exit = false;

            while (!exit)
            {

                Console.WriteLine("Select a shape or end");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Circle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Trapezoid");
                Console.WriteLine("'exit' to end");
                string type = Console.ReadLine();

                switch (type)
                {
                    case "1":
                        Console.WriteLine("Set rectangle length");
                        double l = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Set rectangle height");
                        double h = Double.Parse(Console.ReadLine());
                        shape = new Rectangle(l, h);
                        break;

                    case "2":
                        Console.WriteLine("Set circle radius");
                        double r = Double.Parse(Console.ReadLine());
                        shape = new Circle(r);
                        break;

                    case "3":
                        Console.WriteLine("Set square length");
                        double s = Double.Parse(Console.ReadLine());
                        shape = new Square(s);
                        break;

                    case "4":
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
                        shape = null;
                        break;

                    default:
                        Console.WriteLine("Wrong selection. Bye");
                        return;
                }


                if (shape != null)
                {
                    Console.WriteLine("Solve for");
                    Console.WriteLine("1. Area");
                    Console.WriteLine("2. Perimeter");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "1":
                            Console.WriteLine("Area is: " + shape.GetArea());
                            break;
                        case "2":
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
