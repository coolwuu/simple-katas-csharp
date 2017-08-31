using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

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
    }
}