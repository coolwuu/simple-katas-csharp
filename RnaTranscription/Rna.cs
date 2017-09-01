namespace RnaTranscription
{
    public class Rna
    {
        public static string Transcribe(string input)
        {
            if (input == "C")
                return "G";
            if (input == "G")
                return "C";
            if (input == "T")
                return "A";
            if (input == "A")
                return "U";
            return string.Empty;
        }
    }
}