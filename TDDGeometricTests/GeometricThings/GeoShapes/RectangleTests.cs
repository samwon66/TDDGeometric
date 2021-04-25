using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDGeometric.GeometricThings.GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDGeometric.GeometricThings.GeoShapes.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void GetAreaTest(float height, float length, float expected)
        {
            var rectangle = new Rectangle(height, length);
            var actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        }
    }
}