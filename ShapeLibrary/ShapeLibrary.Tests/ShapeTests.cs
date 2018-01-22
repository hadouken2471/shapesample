using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class ShapeTests
    {
        #region Тесты фигур

        [TestMethod]
        public void TestTriangleWithSides243()
        {
            const double sideA = 2, sideB = 4, sideC = 3;
            var testTriangle = new Triangle(sideA, sideB, sideC);       
            var triangleArea = testTriangle.GetShapeArea();

            Assert.AreEqual(GetTriangleArea(sideA, sideB, sideC), triangleArea);
        }

        [TestMethod]
        public void TestCircleWithRadius2()
        {
            const double radius = 2;
            var testCircle = new Circle(radius);
            var circleArea = testCircle.GetShapeArea();

            Assert.AreEqual(GetCircleArea(radius), circleArea);
        }

        #endregion // Тесты для фигур

        #region Логика для тестирования
        private static double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var s = (sideA + sideB + sideC) / 2.0;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        private static double GetCircleArea(double radius)
        {
            return (3.14) * radius * radius;
        }
        #endregion // Логика для тестирования
    }
}
