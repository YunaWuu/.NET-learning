using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    // This is the Circle class which derives from Shape
    public class Circle : Shape
    {
        // A circle is defined by a radius value
        public double Radius;
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Area = PI * radius * radius
        public override double GetArea()
        {
            if (Radius > 0)
                return Math.PI * Radius * Radius;
            else
                return 0;
        }

        // Perimeter = 2 * PI * radius
        public override double GetPerimeter()
        {
            if (Radius > 0)
                return 2 * Math.PI * Radius;
            else
                return 0;
        }
    }
}
