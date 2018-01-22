using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetShapeArea()
        {
            return (3.14) * _radius * _radius;
        }

    }
}
