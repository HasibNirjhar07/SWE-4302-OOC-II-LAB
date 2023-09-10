using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeDrawerApp;
using System;

namespace ShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calculateCircleAreaTest()
        {

            //Arrange
            Circle circle = new Circle(0, 0, 5);
            double expected = 78.53981633974483;
            //Act
            double actual = circle.calculateArea();
            //Assert
            Assert.AreEqual(expected, actual);
            


        }
        [TestMethod]
        public void calculateSquareAreaTest()
        {
            //Arrange
            Square square = new Square(0, 0, 5);
            double expected = 25;
            //Act
            double actual = square.calculateArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void calculateRectangleAreaTest()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(0, 0, 5, 5);
            double expected = 25;
            //Act
            double actual = rectangle.calculateArea();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
