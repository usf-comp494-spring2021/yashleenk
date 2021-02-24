using System;
using HW3;
using Xunit;

namespace CalcuLibTest
{
    public class xUnitTest1
    {
        [Fact]
        public void TestAdd2and4()
        {
            double a = 2;
            double b = 4;
            double expected = 6;
            var calc = new Calc();

            double actual = calc.add(a, b);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestSubstract10and8()
        {
            double a = 10;
            double b = 8;
            double expected = 2;
            var calc = new Calc();

            double actual = calc.sub(a, b);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestMultiply5and5()
        {
            double a = 5;
            double b = 5;
            double expected = 25;
            var calc = new Calc();

            double actual = calc.mult(a, b);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestDivide10and2()
        {
            double a = 10;
            double b = 2;
            double expected = 5;
            var calc = new Calc();

            double actual = calc.divi(a, b);
            Assert.Equal(expected, actual);

        }
    }
}
