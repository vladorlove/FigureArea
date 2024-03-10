using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigAreasLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigAreasLib.Tests
{
    [TestClass()]
    public class FigAreasTests
    {
        [TestMethod()]
        public void CircleAreaTest()
        {
            // arrenge
            double r = 1;
            // double expected = 3.14159; // Test failed
            double expected = Math.PI; // Test pased

            // actual
            double actual = new FigAreas().CircleArea(r);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TriangleAreaTest()
        {
            // arrenge
            double a = 3, b = 4, c = 5;
            double expected = 6;

            // actual
            double actual = new FigAreas().TriangleArea(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}