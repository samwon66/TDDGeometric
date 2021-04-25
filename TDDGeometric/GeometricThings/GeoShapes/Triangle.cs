using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDGeometric.GeometricThings.GeoShapes
{
    public class Triangle : GeometricShape
    {
        private float Side { get; set; }

        public Triangle(float side) { Side = side; }

        public override float GetArea()
        {
            return base.GetArea();
        }

        public override float GetPerimiter()
        {
            return base.GetPerimiter();
        }
    }
}
