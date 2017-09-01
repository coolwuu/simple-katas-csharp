using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {


        public static Dictionary<string, int> Count(string input)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            List<string> appearedWord = new List<string>();
            if (String.IsNullOrEmpty(input))
                return new Dictionary<string, int>();

            var wordList = input.Split(' ');
            foreach (string word in wordList)
            {
                if (appearedWord.Contains(word))
                    continue;
                var count = wordList.Count(t => t == word);
                result.Add(word, count);
                appearedWord.Add(word);
            }
            return result;
        }
    }
}
