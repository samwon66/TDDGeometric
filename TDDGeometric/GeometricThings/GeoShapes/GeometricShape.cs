using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDGeometric.GeometricThings.GeoShapes
{
    public abstract class GeometricShape
    {
        /// <summary>
        /// Beräkna objektets area
        /// </summary>
        /// <returns>float Area</returns>
        public virtual float GetArea() { return default; }

        /// <summary>
        /// Beräkna objektets omkrets
        /// </summary>
        /// <returns>float Perimiter</returns>
        public virtual float GetPerimiter() { return default; }
    }
}
