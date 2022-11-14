using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    // This is the Rectangle class which derives from Shape
    public class Rectangle : Shape
    {
        // A rectangle is defined by a length and a height value
        public double Length;
        public double Height;
        public Rectangle()
        {
            Length = 0;
            Height = 0;
        }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        // Area = length * height
        public override double GetArea()
        {
            if (Length > 0 && Height > 0)
                return Length * Height;
            else
                return 0;
        }

        // Perimeter = 2 * (length + height)
        public override double GetPerimeter()
        {
            if (Length > 0 && Height > 0)
                return 2 * (Length + Height);
            else
                return 0;
        }
    }
    }
