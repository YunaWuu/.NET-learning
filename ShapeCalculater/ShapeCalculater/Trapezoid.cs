using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    public class Trapezoid : Shape
    {
        public double Base1;
        public double Base2;
        public double Side1;
        public double Side2;
        public double Height;
        public Trapezoid()
        {
            Base1 = 0;
            Base2 = 0;
            Side1 = 0;
            Side2 = 0;
            Height = 0;
        }
        public Trapezoid(double base1, double base2, double side1, double side2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Side1 = side1;
            Side2 = side2;
            Height = height;
        }
        public override double GetArea()
        {
            return (Base1 + Base2) * Height / 2;
        }
        public override double GetPerimeter()
        {
            return Base1 + Base2 + Side1 + Side2;
        }
    }
}
