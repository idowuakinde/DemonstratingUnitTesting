using NUnit.Framework;
using System;
using DemonstratingUnitTesting;

namespace DemonstratingUnitTestingTests
{
    [TestFixture()]
    public class CalculatorTest
    {
        [Test()]
        public void TestAddition()
        {
            // arrange
            Calculator calculator = new Calculator();
            double X = 15;
            double Y = 25;
            double result = 0;

            // act
            result = calculator.Add(X, Y);

            // assert
            Assert.AreEqual(40, result);
        }

        [Test()]
        public void TestSubtraction()
        {
            // arrange
            Calculator calculator = new Calculator();
            double X = 50;
            double Y = 25;
            double result = 0;

            // act
            result = calculator.Subtract(X, Y);

            // assert
            Assert.AreEqual(25, result);
        }

        [Test()]
        public void TestMultiplication()
        {
            // arrange
            Calculator calculator = new Calculator();
            double X = 5;
            double Y = 20;
            double result = 0;

            // act
            result = calculator.Multiply(X, Y);

            // assert
            Assert.AreEqual(100, result);
        }

        [Test()]
        public void TestDivision()
        {
            // arrange
            Calculator calculator = new Calculator();
            double X = 50;
            double Y = 25;
            double result = 0;

            // act
            result = calculator.Divide(X, Y);

            // assert
            Assert.AreEqual(2, result);
        }
    }
}
