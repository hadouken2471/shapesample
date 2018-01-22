using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        protected Shape() { }

        public abstract double GetShapeArea();
    }
}
