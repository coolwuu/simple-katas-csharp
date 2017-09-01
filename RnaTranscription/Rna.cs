using System.Collections.Generic;
using System.Net;

namespace RnaTranscription
{
    public class Rna
    {
        public static Dictionary<string, string> GeneMapping = new Dictionary<string, string>()
        {
            {"C","G" },
            {"G","C" },
            {"T","A" },
            {"A","U" },
        };
        public static string Transcribe(string input)
        {
            if (GeneMapping.ContainsKey(input))
                return GeneMapping[input];
            return string.Empty;
        }
    }
}