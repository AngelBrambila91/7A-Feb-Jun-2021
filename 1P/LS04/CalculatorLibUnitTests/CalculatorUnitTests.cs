using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class UnitTest1
    {
        // Arrange : Declare variables ,  input and output
        // Act : Call the function to test
        // Assert : Make one or more assertions about the output.
        [Fact] // Annotation
        public void TestAdding2And2()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingAdding2And3()
        {
            // arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
