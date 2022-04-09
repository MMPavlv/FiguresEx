using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresEx;

namespace FiguresTest
{
    [TestClass]
    public class FiguresTest
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            Calculation calc = new Calculation();
            Circle c = new Circle(10);

            double expected = 314.159;

            double actual = calc.CalculateArea<Circle>(c);

            Assert.AreEqual(expected, actual, 0.001, "Wrong Calculated Area of Circle");
        }

        [TestMethod]
        public void CircleisImpossibleTest()
        {
            Calculation calc = new Calculation();
            Circle c = new Circle(-10);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.CalculateArea<Circle>(c));
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            Calculation calc = new Calculation();
            Triangle t = new Triangle(3, 4, 5);

            double expected = 6;

            double actual = calc.CalculateArea<Triangle>(t);

            Assert.AreEqual(expected, actual, 0.001, "Wrong Calculated Area of Triangle");
        }

        [TestMethod]
        public void TriangleRightTest()
        {
            Calculation calc = new Calculation();
            Triangle t1 = new Triangle(5, 5, 5);
            Triangle t2 = new Triangle(3, 4, 5);

            bool actual1 = t1.IsRight();
            bool actual2 = t2.IsRight();

            Assert.IsFalse(actual1, "Triangle is not Right");
            Assert.IsTrue(actual2, "Triangle is Right");
        }

        [TestMethod]
        public void TriangleisImpossibleTest()
        {
            Calculation calc = new Calculation();
            Triangle t1 = new Triangle(1, 3, 5);
            Triangle t2 = new Triangle(4, 2, 2);
            Triangle t3 = new Triangle(-3, -4, -2);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.CalculateArea<Triangle>(t1));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.CalculateArea<Triangle>(t2));
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.CalculateArea<Triangle>(t3));
        }
    }
}
