using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDGeometric.GeometricThings.GeoShapes
{
    public class Rectangle : GeometricShape
    {
        private float Length { get; set; }
        private float Height { get; set; }

        public Rectangle(float length, float height)
        {
            Length = length;
            Height = height;
        }

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
