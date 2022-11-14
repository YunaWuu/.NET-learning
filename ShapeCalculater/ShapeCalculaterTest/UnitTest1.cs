using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculater;

namespace ShapeCalculaterTest
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestCase1()
        {
            // Arrange
            var circle = new Circle(-15);
            double except = 0;
            // Act
            double result = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase2()
        {
            // Arrange
            var circle = new Circle(-0.0001);
            double except = 0;
            // Act
            double result = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase3()
        {
            // Arrange
            var circle = new Circle(0);
            double except = 0;
            // Act
            double result = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase4()
        {
            // Arrange
            var circle = new Circle(0.0001);
            double except = 0.000628;
            // Act
            double result = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except, 0.000001);
        }

        [TestMethod]
        public void TestCase5()
        {
            // Arrange
            var circle = new Circle(20);
            double except = 125.66;
            // Act
            double result = circle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except, 0.01);
        }

        [TestMethod]
        public void TestCase6()
        {
            // Arrange
            var circle = new Circle(-100);
            double except = 0;
            // Act
            double result = circle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase7()
        {
            // Arrange
            var circle = new Circle(-0.00001);
            double except = 0;
            // Act
            double result = circle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase8()
        {
            // Arrange
            var circle = new Circle(0);
            double except = 0;
            // Act
            double result = circle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase9()
        {
            // Arrange
            var circle = new Circle(0.0001);
            double except = 0.00000003;
            // Act
            double result = circle.GetArea();
            // Assert
            Assert.AreEqual(result, except, 0.00000001);
        }

        [TestMethod]
        public void TestCase10()
        {
            // Arrange
            var circle = new Circle(30);
            double except = 2827.43;
            // Act
            double result = circle.GetArea();
            // Assert
            Assert.AreEqual(result, except, 0.01);
        }
    }

    [TestClass]
    public class UnitTestRectangle
    {
        [TestMethod]
        public void TestCase11()
        {
            // Arrange
            var rectangle = new Rectangle(-10, -5);
            double except = 0;
            // Act
            double result = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase12()
        {
            // Arrange
            var rectangle = new Rectangle(-0.001, -0.00001);
            double except = 0;
            // Act
            double result = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase13()
        {
            // Arrange
            var rectangle = new Rectangle(0, 3);
            double except = 0;
            // Act
            double result = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase14()
        {
            // Arrange
            var rectangle = new Rectangle(0.0001, 0.00001);
            double except = 0.00022;
            // Act
            double result = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except, 0.000001);
        }

        [TestMethod]
        public void TestCase15()
        {
            // Arrange
            var rectangle = new Rectangle(20, 15);
            double except = 70;
            // Act
            double result = rectangle.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase16()
        {
            // Arrange
            var rectangle = new Rectangle(-3, -50);
            double except = 0;
            // Act
            double result = rectangle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase17()
        {
            // Arrange
            var rectangle = new Rectangle(-0.00001, -0.0001);
            double except = 0;
            // Act
            double result = rectangle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase18()
        {
            // Arrange
            var rectangle = new Rectangle(0, 100);
            double except = 0;
            // Act
            double result = rectangle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase19()
        {
            // Arrange
            var rectangle = new Rectangle(0.00001, 0.0001);
            double except = 0.000000001;
            // Act
            double result = rectangle.GetArea();
            // Assert
            Assert.AreEqual(result, except, 0.000000001);
        }

        [TestMethod]
        public void TestCase20()
        {
            // Arrange
            var rectangle = new Rectangle(25, 20);
            double except = 500;
            // Act
            double result = rectangle.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }
    }

    [TestClass]
    public class UnitTestTrapezoid
    {
        [TestMethod]
        public void TestCase21()
        {
            // Arrange
            var trapezoid = new Trapezoid(-6, -2, -30, -15, -100);
            double except = 0;
            // Act
            double result = trapezoid.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase22()
        {
            // Arrange
            var trapezoid = new Trapezoid(-0.0000001, -0.00001, -0.0001, -0.001, -0.000001);
            double except = 0;
            // Act
            double result = trapezoid.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase23()
        {
            // Arrange
            var trapezoid = new Trapezoid(0, 20, 0, 0, 3);
            double except = 0;
            // Act
            double result = trapezoid.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase24()
        {
            // Arrange
            var trapezoid = new Trapezoid(0.0001, 0.00001, 0.00002, 0.0001, 0.00001);
            double except = 0.00024;
            // Act
            double result = trapezoid.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except, 0.00001);
        }

        [TestMethod]
        public void TestCase25()
        {
            // Arrange
            var trapezoid = new Trapezoid(13, 18, 10, 20, 11);
            double except = 61;
            // Act
            double result = trapezoid.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase26()
        {
            // Arrange
            var trapezoid = new Trapezoid(-100, -110, -3, -56, -10);
            double except = 0;
            // Act
            double result = trapezoid.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase27()
        {
            // Arrange
            var trapezoid = new Trapezoid(-0.00001, -0.000001, -0.0001, -0.00001, -0.00002);
            double except = 0;
            // Act
            double result = trapezoid.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase28()
        {
            // Arrange
            var trapezoid = new Trapezoid(0, 0, 20, 85, 0);
            double except = 0;
            // Act
            double result = trapezoid.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase29()
        {
            // Arrange
            var trapezoid = new Trapezoid(0.00001, 0.00001, 0.00002, 0.0000001, 0.0001);
            double except = 0.000000001;
            // Act
            double result = trapezoid.GetArea();
            // Assert
            Assert.AreEqual(result, except, 0.000000001);
        }

        [TestMethod]
        public void TestCase30()
        {
            // Arrange
            var trapezoid = new Trapezoid(23, 27, 19, 30, 20);
            double except = 500;
            // Act
            double result = trapezoid.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }
    }

    [TestClass]
    public class UnitTestSquare
    {
        [TestMethod]
        public void TestCase31()
        {
            // Arrange
            var square = new Square(-300);
            double except = 0;
            // Act
            double result = square.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase32()
        {
            // Arrange
            var square = new Square(-0.00001);
            double except = 0;
            // Act
            double result = square.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase33()
        {
            // Arrange
            var square = new Square(0);
            double except = 0;
            // Act
            double result = square.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase34()
        {
            // Arrange
            var square = new Square(0.0001);
            double except = 0.0004;
            // Act
            double result = square.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except, 0.00000001);
        }

        [TestMethod]
        public void TestCase35()
        {
            // Arrange
            var square = new Square(13.2);
            double except = 52.8;
            // Act
            double result = square.GetPerimeter();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase36()
        {
            // Arrange
            var square = new Square(-10);
            double except = 0;
            // Act
            double result = square.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase37()
        {
            // Arrange
            var square = new Square(-0.00001);
            double except = 0;
            // Act
            double result = square.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase38()
        {
            // Arrange
            var square = new Square(0);
            double except = 0;
            // Act
            double result = square.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }

        [TestMethod]
        public void TestCase39()
        {
            // Arrange
            var square = new Square(0.0001);
            double except = 0.00000001;
            // Act
            double result = square.GetArea();
            // Assert
            Assert.AreEqual(result, except, 0.00000001);
        }

        [TestMethod]
        public void TestCase40()
        {
            // Arrange
            var square = new Square(2.5);
            double except = 6.25;
            // Act
            double result = square.GetArea();
            // Assert
            Assert.AreEqual(result, except);
        }
    }
}
