﻿using NUnit.Framework;

namespace StringAverage
{
    [TestFixture]
    public class StringAverageCalculatorTest
    {
        [Test]
        public void Input_empty_string_return_NA()
        {
            var input = string.Empty;
            Assert.AreEqual("n/a", StringAverageCalculator.Calculate(input));
        }

        [Test]
        public void Input_one__return_one()
        {
            var input = "one";
            Assert.AreEqual("one", StringAverageCalculator.Calculate(input));
        }

        [Test]
        public void Input_two__return_two()
        {
            var input = "two";
            Assert.AreEqual("two", StringAverageCalculator.Calculate(input));
        }

        [Test]
        public void Input_two__four_return_three()
        {
            var input = "two four";
            Assert.AreEqual("three", StringAverageCalculator.Calculate(input));
        }

        [Test]
        public void Input_two__four_six_return_six()
        {
            var input = "two four six";
            Assert.AreEqual("four", StringAverageCalculator.Calculate(input));
        }
    }
}