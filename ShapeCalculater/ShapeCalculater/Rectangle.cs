using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    public class Rectangle : Shape
    {
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
        public override double GetArea()
        {
            return Length * Height;
        }
        public override double GetPerimeter()
        {
            return 2 * (Length + Height);
        }
    }
    }
