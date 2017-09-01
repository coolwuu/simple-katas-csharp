namespace TwoFer
{
    public class Twofer
    {
        public static string Say(string input)
        {
            return input == string.Empty ? "One for you, one for me." : "One for " + input + ", one for me.";
        }
    }
}