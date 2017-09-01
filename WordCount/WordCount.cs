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
        public static List<string> AppearedWord = new List<string>();

        public static Dictionary<string, int> Count(string input)
        {
            Dictionary < string, int> result = new Dictionary<string, int>();
            if (String.IsNullOrEmpty(input))
                return new Dictionary<string, int>();

            var wordList = input.Split(' ');
            foreach (string word in wordList)
            {
                int count = 0;
                if (AppearedWord.Contains(word))
                    continue;
                for (var j = 0; j < wordList.Length; j++)
                {
                    if (wordList[j] == word)
                        count ++;
                }
                result.Add(word,count);
                AppearedWord.Add(word);
            }
            return result;
        }
    }
}
