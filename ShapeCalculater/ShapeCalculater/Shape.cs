using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculater
{
    // This is the Shape class, which is the base of all different shapes
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
