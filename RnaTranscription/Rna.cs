using System.Collections.Generic;
using System.Net;

namespace RnaTranscription
{
    public class Rna
    {
        public static Dictionary<char, string> GeneMapping = new Dictionary<char, string>()
        {
            {'C',"G" },
            {'G',"C" },
            {'T',"A" },
            {'A',"U" },
        };
        public static string Transcribe(string input)
        {
            var result = string.Empty;
            foreach (var character in input)
            {
                if (GeneMapping.ContainsKey(character))
                    result += GeneMapping[character];
            }

            return result;
        }
    }
}