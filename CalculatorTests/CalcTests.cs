using Microsoft.VisualStudio.TestTools.UnitTesting;
using  AplanaCSharp;

namespace CalculatorTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void TestPlus()
        {
            // Arrange
            double x = 5.5;
            double y = 4.5;
            double expected = 10.0;
            Calculator calc = new Calculator(x, y);
            
            // Act and assert
            Assert.AreEqual(expected, calc.plus(), "Plus correctly");
        }
        
        [TestMethod]
        public void TestMinus()
        {
            // Arrange
            double x = -9;
            double y = 4;
            double expected = -13.0;
            Calculator calc = new Calculator(x, y);
            
            // Act and assert
            Assert.AreEqual(expected, calc.minus(), "Minus correctly");
        }
        
        [TestMethod]
        public void TestMultiply()
        {
            // Arrange
            double x = 5.0;
            double y = 5;
            double expected = 25.0;
            Calculator calc = new Calculator(x, y);
            
            // Act and assert
            Assert.AreEqual(expected, calc.multiply(), "Multiply correctly");

        }
        
        [TestMethod]
        public void TestDivide()
        {
            // Arrange
            double x = 6;
            double y = 2.5;
            double expected = 2.4;
            Calculator calc = new Calculator(x, y);
            
            // Act and assert
            Assert.AreEqual(expected, calc.divide(), "Divide correctly");
        }
        
        [TestMethod]
        public void TestDevide_ShouldDivideByZeroException()
        {
            // Arrange
            double x = 5.7;
            double y = 0;
            Calculator calc = new Calculator(x, y);
            
            // Act and assert
            Assert.ThrowsException<System.DivideByZeroException>(() => calc.divide());
            
        }

    }
}