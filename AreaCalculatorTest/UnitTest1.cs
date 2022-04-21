using Area_Calc_Gabriel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WholeIntSquareArea()
        {     
            Assert.AreEqual(400, AreaCalculator.getSquareArea(20));
        }
        [TestMethod]
        public void StringSquareArea()
        {
            Assert.AreEqual(100, AreaCalculator.getSquareArea("ten"));
        }
        [TestMethod]
        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        public void StringSquareAreaFail()
        {
            Assert.AreEqual(10, AreaCalculator.getSquareArea("aaa"));
        }
        [TestMethod]
        public void getRectangleArea()
        {
            Assert.AreEqual(500, AreaCalculator.getRectangleArea(10,50));
        }
        [TestMethod]
        public void getTriangleArea()
        {
            Assert.AreEqual(35, AreaCalculator.getTriangleArea(7, 10));
        }
        [TestMethod]
        public void getParallelogramArea()
        {
            Assert.AreEqual(70, AreaCalculator.getParallelogramArea(7, 10));
        }
        [TestMethod]
        public void getCircleRadius()
        {
            Assert.AreEqual(5, AreaCalculator.getCircleRadius(10));
        }
        [TestMethod]
        public void getCircleDiameter()
        {
            Assert.AreEqual(20, AreaCalculator.getCircleDiameter(10));
        }
    }
}