using System;
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
        public static string Transcribe(string dnaStrand)
        {
            var rnaStrand = string.Empty;
            foreach (var nucleotide in dnaStrand)
            {
                if (!GeneMapping.ContainsKey(nucleotide))
                     throw new ArgumentException("Invalid input");
                rnaStrand += GeneMapping[nucleotide];
            }

            return rnaStrand;
        }
    }
}