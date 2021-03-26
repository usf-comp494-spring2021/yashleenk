using System;
using HW3;
using Xunit;

namespace CalcuLibTest
{

    /// <summary>
    /// Testing the methods in Calc class
    /// </summary>
    public class xUnitTest1
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestAdd2and4()
        {
            // Arrange
            double a = 2;
            double b = 4;
            double expected = 6;
            var calc = new Calc();

            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestSubstract10and8()
        {
            // Arrange
            double a = 10;
            double b = 8;
            double expected = 2;
            var calc = new Calc();

            double actual = calc.Substract(a, b);
            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestMultiply5and5()
        {
            // Arrange
            double a = 5;
            double b = 5;
            double expected = 25;
            var calc = new Calc();

            double actual = calc.Multiply(a, b);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestDivide10and2()
        {
            //Arrange
            double a = 10;
            double b = 2;
            double expected = 5;
            var calc = new Calc();

            double actual = calc.Divide(a, b);
            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestMean()
        {
            // Arrange
            double[] a = { 1, 3, 8, 2, 7, 5, 8, 6};
            int n = a.Length;
            double expected = 5;
            var calc = new Calc();

            double actual = (double)calc.FindMean(a, n);
            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestMedian()
        {
            // Arrange
            double[] a = { 1, 3, 8, 2, 7, 5, 8, 6 };
            int n = a.Length;
            double expected = 5.5;
            var calc = new Calc();

            double actual = (double)calc.FindMedian(a, n);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
