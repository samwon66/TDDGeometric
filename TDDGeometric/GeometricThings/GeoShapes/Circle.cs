using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDGeometric.GeometricThings.GeoShapes
{
    public class Circle : GeometricShape
    {
        private float Radius { get; set; }

        public Circle(float radius) { Radius = radius; }

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
