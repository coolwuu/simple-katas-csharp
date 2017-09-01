namespace TwoFer
{
    public class Twofer
    {
        public static string Say(string input)
        {
            if(input == "Alice")
                return "One for Alice, one for me.";
            return "One for you, one for me.";
        }
    }
}