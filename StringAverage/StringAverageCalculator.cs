using System;

namespace StringAverage
{
    class StringAverageCalculator
    {
        public static string Calculate(string input)
        {
            if (String.IsNullOrEmpty(input))
                return "n/a";
            return input;
        }
    }
}
