using System;
using System.Collections.Generic;
using System.Linq;

namespace StringAverage
{
    class StringAverageCalculator
    {
        public static Dictionary<string, int> NumberMapping = new Dictionary<string, int>()
        {
            {"zero",0 },{"one",1 },{"two",2 },{"three",3},{"four",4 },
            {"five",5},{"six",6 },{"seven",7 },{"eight",8 },{"nine",9 },
        };

        public static string Calculate(string input)
        {
            if (String.IsNullOrEmpty(input))
                return "n/a";

            var numberList = input.Split(' ');
            var total = 0;
            foreach (var number in numberList)
            {
                if (!NumberMapping.ContainsKey(number))
                    return "n/a";
                var tmp = NumberMapping[number];
                total += tmp;
            }
            int avgResult = total / numberList.Length;

            return NumberMapping.FirstOrDefault(x => x.Value == avgResult).Key;
        }
    }


    
    
}
