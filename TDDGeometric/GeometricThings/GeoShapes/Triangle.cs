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
        private float Height { get; set; }

        public Triangle(float side, float height) 
        { 
            this.Side = side;
            this.Height = height;
        }

        /// <summary>
        /// Räkna ut arean på en triangel
        /// </summary>
        /// <returns>Area som avrundas till 2 decimaler</returns>
        public override float GetArea()
        {
            if (Side <= 0 || Height <= 0) { return 0; }
            return (float)Math.Round(Side*Height/2, 2);
        }

        /// <summary>
        /// Räkna ut omkretsen till en triangel
        /// </summary>
        /// <returns>Omkrets som avrundas till 2 deicmaler</returns>
        public override float GetPerimiter()
        {
            if (Side <= 0 || Height <= 0) { return 0; }
            return (float)Math.Round(Side * 3, 2);
        }
    }
}
