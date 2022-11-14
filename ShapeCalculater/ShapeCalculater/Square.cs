using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    // This is the Square class which derived from Shape
    public class Square : Shape
    {
        // A square is defined by a length value
        public double Length;

        public Square()
        {
            Length = 0;
        }
        public Square(double length)
        {
            Length = length;
        }

        // Area = length * length
        public override double GetArea()
        {
            if (Length > 0)
                return Length * Length;
            else
                return 0;
        }

        // Perimeter = length * 4
        public override double GetPerimeter()
        {
            if (Length > 0)
                return Length * 4;
            else
                return 0;
        }
    }
}
