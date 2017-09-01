namespace TwoFer
{
    public class Twofer
    {
        public static string Say(string input)
        {
            if (input is null)
                return "One for you, one for me.";
            return "One for " + input + ", one for me.";


        }
    }
}