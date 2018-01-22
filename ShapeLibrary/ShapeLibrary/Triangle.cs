using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        private readonly double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetShapeArea()
        {
            var s = (_sideA + _sideB + _sideC) / 2.0;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }

    }
}
