using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    public class Square : Shape
    {
        public double Length;

        public Square()
        {
            Length = 0;
        }
        public Square(double length)
        {
            Length = length;
        }
        public override double GetArea()
        {
            return Length * Length;
        }
        public override double GetPerimeter()
        {
            return Length * 4;
        }
    }
}
