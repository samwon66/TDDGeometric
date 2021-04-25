using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDGeometric.GeometricThings.GeoShapes
{
    public class Square : GeometricShape
    {
        public float Side { get; set; }

        public Square(float side) { this.Side = side; }

        /// <summary>
        /// Räkna ut area på en kvadrat
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            if (Side <= 0) { return 0; }
            return (float)Math.Round((Side * Side), 2); 
        }

        /// <summary>
        /// Räkna ut omkrets på en kvadrat
        /// </summary>
        /// <returns></returns>
        public override float GetPerimiter()
        {
            if (Side <= 0) { return 0; }
            return (float)Math.Round((Side * 4), 2);
        }
    }
}
